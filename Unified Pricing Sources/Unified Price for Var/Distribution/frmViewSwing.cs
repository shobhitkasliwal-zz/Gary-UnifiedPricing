using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unified_Price_for_Var
{
    public partial class frmViewSwing : Form
    {
        public frmViewSwing()
        {
            InitializeComponent();
        }

        private void FillCustomersInSelectedSwing()
        {
            if (cmbSwingNumber.SelectedValue != null)
            {
                var prices = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] FROM tblCustomers WHERE [Swing Number] = '{0}'", cmbSwingNumber.SelectedValue);
                grdCustInSwing.Rows.Clear();
                foreach (DataRow price in prices.Rows)
                {
                    grdCustInSwing.Rows.Add(price["Customer Number"], price["Customer Bill Name"]);
                }
            }
        }

        private void FillCustomersNotInSwing()
        {
            var prices = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] FROM tblCustomers WHERE [Swing Number] is null");
            grdAvilableCust.Rows.Clear();
            foreach (DataRow price in prices.Rows)
            {
                grdAvilableCust.Rows.Add(price["Customer Number"], price["Customer Bill Name"]);
            }
        }

        public void RefreshSwingNumbers()
        {
            var dataTable = Db.ExecuteDataTable("SELECT [Swing Number] FROM tblSwingNumbers ORDER BY [Swing Number]");
            cmbSwingNumber.DataSource = dataTable;
            cmbSwingNumber.DisplayMember = "Swing Number";
            cmbSwingNumber.ValueMember = "Swing Number";            
        }

        private void frmViewSwing_Load(object sender, EventArgs e)
        {
            RefreshSwingNumbers();
            FillCustomersNotInSwing();
        }

        private void cmbSwingNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSwingNumber.Text.Length > 0)
            {
                FillCustomersInSelectedSwing();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var swings = Db.ExecuteDataTable("SELECT * FROM tblSwingNumbers ORDER BY [Swing Number]");

            foreach (DataRow row in swings.Rows)
            {
                cmbSwing1.Items.Add(row["Swing Number"]);
                cmbSwing2.Items.Add(row["Swing Number"]);
            }

            panel1.Visible = true;
            cmbSwingNumber.Visible = grdCustInSwing.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelNew_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            cmbSwingNumber.Visible = grdCustInSwing.Visible = true;
        }

        private void btnCreateSwing_Click(object sender, EventArgs e)
        {
            if (txtNewSwingNumber.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Swing Number and Name can not be empty", "Information");
            }
            else
            {
                if (chkCombine.Checked == false)
                {
                    Db.NonQuery("INSERT INTO tblSwingNumbers ([Swing Number], [Swing Name]) VALUES ('{0}', '{1}')", txtNewSwingNumber.Text, txtDescription.Text);
                }
                else
                {
                    try
                    {
                        Db.NonQuery("INSERT INTO tblSwingNumbers ([Swing Number], [Swing Name]) VALUES ('{0}', '{1}')", txtNewSwingNumber.Text, txtDescription.Text);

                        var custs1 = Db.ExecuteDataTable("SELECT [Customer Number] FROM tblCustomers WHERE [Swing Number] = '{0}'", cmbSwing1.Text);
                        var custs2 = Db.ExecuteDataTable("SELECT [Customer Number] FROM tblCustomers WHERE [Swing Number] = '{0}'", cmbSwing2.Text);

                        foreach(DataRow row in custs1.Rows)
                            Db.NonQuery("UPDATE tblCustomers SET [Swing Number] = '{0}' WHERE [Customer Number] = '{1}'", txtNewSwingNumber.Text, row["Customer Number"]);

                        foreach (DataRow row in custs2.Rows)
                            Db.NonQuery("UPDATE tblCustomers SET [Swing Number] = '{0}' WHERE [Customer Number] = '{1}'", txtNewSwingNumber.Text, row["Customer Number"]);

                        if (chkDelete.Checked)
                        {
                            Db.NonQuery("DELETE FROM tblSwingNumbers WHERE [Swing Number] = '{0}'", cmbSwing1.Text);
                            Db.NonQuery("DELETE FROM tblSwingNumbers WHERE [Swing Number] = '{0}'", cmbSwing2.Text);
                        }

                        MessageBox.Show("Swing Number  " + txtNewSwingNumber.Text + "  Created", "Information");
                        txtDescription.Text = "";
                        txtNewSwingNumber.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("New Swing Number NOT Created. \n See system Administrator.", "Information");
                    }
                }
                RefreshSwingNumbers();
                FillCustomersNotInSwing();
                FillCustomersInSelectedSwing();
                this.panel1.Visible = false;
                cmbSwingNumber.Visible = grdCustInSwing.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdAvilableCust.SelectedRows)
            {
                Db.NonQuery("UPDATE tblCustomers SET [Swing Number] = '{0}' WHERE [Customer Number] = '{1}'", cmbSwingNumber.SelectedValue, row.Cells["CustNumber"].Value);
            }
            FillCustomersNotInSwing();
            FillCustomersInSelectedSwing();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdCustInSwing.SelectedRows)
            {
                Db.NonQuery("UPDATE tblCustomers SET [Swing Number] = null WHERE [Customer Number] = '{0}'", row.Cells["CustNumber2"].Value);
            }
            FillCustomersNotInSwing();
            FillCustomersInSelectedSwing();
        }

        private void cmbSwingNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string groupName = cmbSwingNumber.SelectedValue.ToString();
            DialogResult result4 = MessageBox.Show("Please confirm deletion of SwingNumber:  " +
                groupName + ".", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result4 == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in grdCustInSwing.Rows)
                {
                    Db.NonQuery("UPDATE tblCustomers SET [Swing Number] = null WHERE [Customer Number] = '{0}'", row.Cells["CustNumber2"].Value);
                }
                Db.NonQuery("DELETE FROM tblSwingNumbers WHERE [Swing Number] = '{0}'", groupName);

                MessageBox.Show("Swing number " + groupName + " deleted", "Important");
                RefreshSwingNumbers();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string groupName = cmbSwingNumber.SelectedValue.ToString();
            DialogResult result4 = MessageBox.Show("Do you really want to remove all customers from SwingNumber:  " +
                groupName + ".", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result4 == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in grdCustInSwing.Rows)
                {
                    Db.NonQuery("UPDATE tblCustomers SET [Swing Number] = null WHERE [Customer Number] = '{0}'", row.Cells["CustNumber2"].Value);
                }
                
                MessageBox.Show("All itms from Swing number " + groupName + " was removed", "Important");
                RefreshSwingNumbers();
                FillCustomersNotInSwing();
                FillCustomersInSelectedSwing();
            }
        }

        private void chkCombine_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = chkCombine.Checked;
        }
        private void txtNewSwingNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}