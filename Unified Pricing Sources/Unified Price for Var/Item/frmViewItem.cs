using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unified_Price_for_Var.Pricing_for_Tanya_DataSetTableAdapters;

namespace Unified_Price_for_Var
{
    public partial class frmViewItem : Form
    {
        public frmViewItem()
        {
            InitializeComponent();

        }

        private void frmViewItem_Load(object sender, EventArgs e)
        {
            // this.Visible = false;
            RefreshDataset();
            pnlUseDescrip.Visible = false;
            //  this.Visible = true;

        }

        private void btnEdit_Item_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "        Edit Existing Items";
            lblComponent1.Visible = false;
            lblComponent2.Visible = true;
            txtItemDescription.ReadOnly = false;
            txtItemFamily.ReadOnly = false;
            txtComp1.ReadOnly = false;
            txtComp1.Visible = false;
            txtComp2.ReadOnly = false;
            txtComp2.Visible = true;
            txtOEM.ReadOnly = false;       //Igor
            txtOEM.Visible = true;          // Igor
            btnExit.Visible = true;
            btnAdd_Item.Visible = false;
            btnEdit_Item.Visible = false;
            btnDelete_Item.Visible = false;
            btnManage_Groups.Visible = false;
            btnCopy_Item.Visible = false;
            btnUpdate.Visible = true;
            btnUpdate.Location = new Point(btnDelete_Item.Location.X, btnDelete_Item.Location.Y);
            btnLookUp.Visible = true;

            btnLookUp.Enabled = true;
            btnExit.Visible = false;
            btnReturnToMain.Visible = true;  // Text of this buton is EXIT 
            btnReturnToMain.Location = new Point(btnExit.Location.X, btnExit.Location.Y);

        }

        private void btnAdd_Item_Click(object sender, EventArgs e)
        {
            btnLookUp.Enabled = true;
            lblComponent1.Visible = false;
            lblComponent2.Visible = true;
            txtItemDescription.ReadOnly = false;
            txtItemFamily.ReadOnly = false;
            txtComp1.ReadOnly = false;
            txtComp1.Visible = false;
            txtComp2.ReadOnly = false;
            txtComp2.Visible = true;
            txtItem_Number.ReadOnly = false;
            txtOEM.ReadOnly = false;        //Igor
            txtOEM.Visible = true;          //Igor

            btnAdd.Visible = true;
            btnAdd.TabIndex = 6;
            btnDelete_Item.Visible = false;
            btnEdit_Item.Visible = false;
            btnAdd_Item.Visible = false;
            btnManage_Groups.Visible = false;
            btnCopy_Item.Visible = false;
            cmbItems.Visible = false;
            lbl1.Visible = false;
            lblHeader.Text = "          Add New Item";
            ClearControls();
            btnAdd.Location = new Point(btnDelete_Item.Location.X, btnDelete_Item.Location.Y);

            btnExit.Visible = false;
            btnReturnToMain.Visible = true;
            btnReturnToMain.Location = new Point(btnExit.Location.X, btnExit.Location.Y);
            btnLookUp.Visible = true;

        }

        private void ClearControls()
        {
            txtItem_Number.Text = "";
            txtItemDescription.Text = "";
            txtItemFamily.Text = "";
            txtComp1.Text = "";
            txtComp2.Text = "";
            txtOEM.Text = " ";          //Igor 
        }

        private void btnDelete_Item_Click(object sender, EventArgs e)
        {
            DialogResult result4 = MessageBox.Show("Please confirm deletion of Item number :" +
            txtItem_Number.Text + ".", "Importent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result4 == DialogResult.Yes)
            {
                try
                {
                    Db.NonQuery("DELETE FROM tblItems WHERE [Item Number] = '{0}'", cmbItems.Text);
                    RefreshDataset();
                    MessageBox.Show("Item number " + txtItem_Number.Text + " deleted", "Importent");
                }
                catch
                {
                    MessageBox.Show("Item number " + txtItem_Number.Text + " NOT deleted", "Importent");
                }
            }
            ClearControls();
        }
        //------------------------------------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------------------------------------------
        private void btnManage_Groups_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmManageInventoryGroup nextScreen1 = new frmManageInventoryGroup();
            DialogResult result = nextScreen1.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        //-------------------------------------------------------------------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IsValid();
            try
            {
                Db.NonQuery("UPDATE tblItems SET [Item Number] = '{0}', [Item Description] = '{1}', [Family] = '{2}', [Item Component 1] = '{3}', [Item Component 2] = '{4}' , [OEM Number] = '{5}' WHERE [Item Number] = '{6}'", txtItem_Number.Text, txtItemDescription.Text, txtItemFamily.Text, txtComp1.Text, txtComp2.Text, txtOEM.Text, txtItem_Number.Text);
                MessageBox.Show("Item " + cmbItems.Text + " information changed.", "Information");

                ClearControls();

            }
            catch (Exception ex)
            {
                Log.Exception(ex);
            }
        }
        //---------------------------------------------------------------------------------------------
        private void RefreshDataset()
        {
            this.cmbItems.SelectedIndexChanged -= new System.EventHandler(this.cmbItems_SelectedIndexChanged);
            var dataTable = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");
            cmbItems.DataSource = dataTable;
            cmbItems.DisplayMember = "Item Number";
            cmbItems.ValueMember = "Item Number";
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.cmbItems_SelectedIndexChanged);
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid1())
            {
                try
                {
                    Db.NonQuery("INSERT INTO tblItems ([Item Number], [Item Description], [Family], [Item Component 1], [Item Component 2], [OEM Number]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txtItem_Number.Text, txtItemDescription.Text, txtItemFamily.Text, txtComp1.Text, txtComp2.Text, txtOEM.Text);

                    MessageBox.Show("Item number " + txtItem_Number.Text + " added.");

                    ClearControls();

                }
                catch
                {
                    MessageBox.Show("Can not insert duplicate Item Number");
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------

        private bool IsValid()
        {
            return Validation.IsPresent(txtItemDescription);
        }

        //-------------------------------------------------------------------------------------------------
        private bool IsValid1()
        {
            return Validation.IsPresent(txtItem_Number) && Validation.IsPresent(txtItemDescription);
        }
        //---------------------------------------------------------------------------------------------------
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var dataTable = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");

            comboBox1.DataSource = new DataView(dataTable);
            comboBox1.DisplayMember = "Item Number";
            comboBox1.ValueMember = "Item Number";
            comboBox3.DataSource = new DataView(dataTable);
            comboBox4.DisplayMember = "Item Number";
            comboBox3.ValueMember = "Item Number";
            comboBox4.DataSource = new DataView(dataTable);
            comboBox4.DisplayMember = "Item Number";
            comboBox4.ValueMember = "Item Number";
            pnl1.Visible = true;
            Cursor.Current = Cursors.Default;
        }
        //---------------------------------------------------------------------------------------------------
        private void btnCopy_Click_1(object sender, EventArgs e)
        {
            if (txtNewItem.Text != "" && comboBox1.Text != "")
            {
                //try
                //{
                //    var itemRow = Db.ExecuteDataRow("SELECT * FROM tblItems WHERE [Item Number] = '{0}'", comboBox1.Text);

                //    Db.NonQuery("INSERT INTO tblItems ([Item Number], [Item Description], [Family], [Item Component 1], [Item Component 2]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                //        txtNewItem.Text,
                //        itemRow["Item Description"].ToString(),
                //        itemRow["Family"].ToString(),
                //        itemRow["Item Component 1"].ToString(),
                //        itemRow["Item Component 2"].ToString());

                //    MessageBox.Show("Copy completed successfully.");
                //    RefreshDataset();
                //}
                //catch
                //{
                //   // MessageBox.Show("Item Number " + txtNewItem.Text + " NOT added.");
                //}
                var itemRows = Db.ExecuteDataRow("SELECT * FROM tblItems WHERE [Item Number] = '{0}'", txtNewItem.Text);

                if (itemRows == null)
                {
                    try
                    {

                        Db.NonQuery("UPDATE tblItems SET [Item Number] = '{0}' WHERE [Item Number] = '{1}'", txtNewItem.Text, comboBox1.Text);
                        Db.NonQuery("UPDATE tblPricing SET [Item Number] = '{0}' WHERE [Item Number] = '{1}'", txtNewItem.Text, comboBox1.Text);
                        MessageBox.Show("Item Number " + comboBox1.Text + " changed to Item Number " + txtNewItem.Text, "Information");
                        txtNewItem.Text = "";

                    }
                    catch (Exception ex)
                    {
                        Log.Exception(ex);
                    }
                }
                else
                {
                    MessageBox.Show("Item number " + txtNewItem.Text + " already exist. \n Please select the another Item to change to.", "Information");
                }
            }
            else
            {
                MessageBox.Show("New Item Number can not be Blank.");
            }
        }

        private void btnReplaceItem_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex < 0 || comboBox4.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the correct values.", "Repalce Inventory Item", MessageBoxButtons.OK);
                return;
            }
            if (comboBox3.SelectedValue == comboBox4.SelectedValue)
            {

                MessageBox.Show("The New and Old values selected are same. Please select differnt values.", "Repalce Inventory Item", MessageBoxButtons.OK);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure, you would like to replace the item number " + comboBox3.SelectedValue + " with item number " + comboBox4.SelectedValue + " ?", "Repalce Inventory Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Db.NonQuery("UPDATE tblPricing SET [Item Number] = '{0}' WHERE [Item Number] = '{1}'", comboBox4.SelectedValue, comboBox3.SelectedValue);
                Db.NonQuery("UPDATE tblCustomerItems SET [Our Item Number] = '{0}' WHERE [Our Item Number] = '{1}'", comboBox4.SelectedValue, comboBox3.SelectedValue);
                MessageBox.Show("Item Number " + comboBox3.SelectedValue + " changed to Item Number " + comboBox4.SelectedValue + " in tblPricing and tblCustomerItems Table.", "Information");

            }

        }
        //-------------------------------------------------------------------------------------------------------
        private void Exit1_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            RefreshDataset();
        }
        //-------------------------------------------------------------------------------------------------------
        private DataTable dataTable3 = null;

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            pnlUseDescrip.Visible = !pnlUseDescrip.Visible;
            if (dataTable3 == null)
                dataTable3 = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");

            comboBox2.DataSource = dataTable3;
            comboBox2.DisplayMember = "Item Number";
            comboBox2.ValueMember = "Item Number";
        }
        //-------------------------------------------------------------------------------------------------------
        private void btnCancelLookUp_Click_1(object sender, EventArgs e)
        {
            pnlUseDescrip.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------
        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemRow = Db.ExecuteDataRow("SELECT * FROM tblItems WHERE [Item Number] = '{0}'", cmbItems.Text);

            if (itemRow != null)
            {
                txtItem_Number.Text = itemRow["Item Number"].ToString();
                txtItemDescription.Text = itemRow["Item Description"].ToString();
                txtItemFamily.Text = itemRow["Family"].ToString();
                txtComp1.Text = itemRow["Item Component 1"].ToString();
                txtComp2.Text = itemRow["Item Component 2"].ToString();
                txtOEM.Text = itemRow["OEM Number"].ToString();
            }
        }

        private void btnUseItem_Click(object sender, EventArgs e)
        {
            var itemCopyFrom = Db.ExecuteDataRow("SELECT [Item Description] FROM tblItems WHERE [Item Number] = '{0}'", comboBox2.Text);
            txtItemDescription.Text = itemCopyFrom["Item Description"].ToString();
        }

        private void cmbItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        // {

        // }

        private void txtNewItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        //---------------------------------------------------------------------------

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            btnLookUp.Enabled = false;
            lblComponent1.Visible = false;
            lblComponent2.Visible = true;
            txtItemDescription.ReadOnly = true;
            txtItemFamily.ReadOnly = true;
            txtComp1.ReadOnly = true;
            txtComp1.Visible = false;
            txtComp2.ReadOnly = true;
            txtComp2.Visible = true;
            txtItem_Number.ReadOnly = true;
            txtOEM.ReadOnly = true;
            txtOEM.Visible = true;

            btnAdd.Visible = false;
            btnAdd_Item.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.TabIndex = 6;
            btnDelete_Item.Visible = true;
            btnEdit_Item.Visible = true;
            btnAdd_Item.Visible = true;
            btnManage_Groups.Visible = true;
            btnCopy_Item.Visible = true;
            cmbItems.Visible = true;
            lbl1.Visible = true;
            lblHeader.Text = "Items information and maintainence";

            RefreshDataset();
            ClearControls();

            btnExit.Visible = true;
            btnReturnToMain.Visible = false;
            pnlUseDescrip.Visible = false;
            btnLookUp.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }





    }
}