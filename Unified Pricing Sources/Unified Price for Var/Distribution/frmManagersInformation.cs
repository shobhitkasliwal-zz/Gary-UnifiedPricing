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
    public partial class frmManagersInformation : Form
    {
        public frmManagersInformation()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManagersInformation_Load(object sender, EventArgs e)
        {
            ddlState.DataSource = StateArray.DropDownDisplay();

            btnCancel.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnEdit.Visible = false;
            btnUpdate.Visible = false;
            LoadGrid();
            ChangeGridWidth("big");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtManagerName.Text.Length == 0)
            {
                MessageBox.Show("Please enter name for manager");
                return;
            }
            string query = string.Format("INSERT INTO tblManagerInformation(ManagerName,ManagerEmail,ManagerPhone,ManagerFax,ManagerCell,MailingAddress,City,State,Zip,SameAddress) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", txtManagerName.Text, txtManagerEmail.Text, txtWorkPhone.Text, txtFax.Text, txtCellPhone.Text, txtMailingAddress.Text, txtCity.Text, ddlState.SelectedValue, txtZipCode.Text, (rbSameAddressYes.Checked ? "1" : "0"));
            Db.ExecuteScalar(query);

            MessageBox.Show("Manager Added successfully.");
            LoadGrid();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want delete " + txtManagerName.Text + " ?", "Delete Manager", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                string query = "DELETE FROM tblManagerInformation where ID= " + lblManagerID.Text;
                MessageBox.Show("Manager Deleted Successfully");
                LoadGrid();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnEdit.Visible = false;
            btnUpdate.Visible = false;
            ChangeGridWidth("big");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            ResetForm();
            btnSave.Visible = true;
            btnCancel.Visible = true;

            ChangeGridWidth("small");
        }


        private void ResetForm()
        {
            txtManagerName.Text = string.Empty;
            txtManagerEmail.Text = string.Empty;
            txtWorkPhone.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtCellPhone.Text = string.Empty;
            txtMailingAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            rbSameAddressYes.Checked = false;
            rbSameAddressNo.Checked = false;
            ddlState.SelectedIndex = ddlState.Items.IndexOf("IL - Illinois");
            lblManagerID.Text = "";
            txtManagerName.Focus();

        }

        private void LoadGrid()
        {

            DataTable dt = Db.ExecuteDataTable("Select * from tblManagerInformation");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

            btnCancel.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnEdit.Visible = false;
            btnUpdate.Visible = false;
            ResetForm();
            ChangeGridWidth("big");

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetForm();
            //  you can perform (any operation) delete action on selected row like
            lblManagerID.Text = (dataGridView1.Rows[e.RowIndex]).Cells[0].Value.ReplaceNulls();
            txtManagerName.Text = (dataGridView1.Rows[e.RowIndex]).Cells[1].Value.ReplaceNulls();
            txtManagerEmail.Text = (dataGridView1.Rows[e.RowIndex]).Cells[2].Value.ReplaceNulls();
            txtWorkPhone.Text = (dataGridView1.Rows[e.RowIndex]).Cells[3].Value.ReplaceNulls();
            txtFax.Text = (dataGridView1.Rows[e.RowIndex]).Cells[4].Value.ReplaceNulls();
            txtCellPhone.Text = (dataGridView1.Rows[e.RowIndex]).Cells[5].Value.ReplaceNulls();
            txtMailingAddress.Text = (dataGridView1.Rows[e.RowIndex]).Cells[6].Value.ReplaceNulls();
            txtCity.Text = (dataGridView1.Rows[e.RowIndex]).Cells[7].Value.ReplaceNulls();
            if ((dataGridView1.Rows[e.RowIndex]).Cells[8].Value.ReplaceNulls().Length > 0)
                ddlState.SelectedIndex = ddlState.Items.IndexOf((dataGridView1.Rows[e.RowIndex]).Cells[8].Value.ReplaceNulls());
            txtZipCode.Text = (dataGridView1.Rows[e.RowIndex]).Cells[9].Value.ReplaceNulls();
            bool sameaddress = false;
            if (Boolean.TryParse((dataGridView1.Rows[e.RowIndex]).Cells[10].Value.ReplaceNulls(), out sameaddress))
            {
                if (sameaddress)
                    rbSameAddressYes.Checked = true;
                else
                    rbSameAddressNo.Checked = true;
            }
            btnCancel.Visible = true;
            btnDelete.Visible = true;
            btnSave.Visible = false;
            btnEdit.Visible = false;
            btnUpdate.Visible = true;
            ChangeGridWidth("small");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtManagerName.Text.Length == 0)
            {
                MessageBox.Show("Please enter name for manager");
                return;
            }
            string query = "UPDATE tblManagerInformation ";
            query += "SET ManagerName ='" + txtManagerName.Text + "'";
            query += ",ManagerEmail ='" + txtManagerEmail.Text + "'";
            query += ",ManagerPhone ='" + txtWorkPhone.Text + "'";
            query += ",ManagerFax ='" + txtFax.Text + "'";
            query += ",ManagerCell ='" + txtCellPhone.Text + "'";
            query += ",MailingAddress ='" + txtMailingAddress.Text + "'";
            query += ",City ='" + txtCity.Text + "'";
            query += ",State ='" + ddlState.SelectedValue + "'";
            query += ",Zip ='" + txtZipCode.Text + "'";
            query += ",SameAddress ='" + (rbSameAddressYes.Checked ? "1" : "0") + "'";
            query += " WHERE ManagerID = " + lblManagerID.Text;
            Db.NonQuery(query);

            MessageBox.Show("Manager information updated successfully.");

            LoadGrid();

        }

        private void ChangeGridWidth(string type = "big")
        {
            if (type == "big")
            {
                pnlDataGrid.Width = 650;
                dataGridView1.Width = 630;
                pnlManagerInformation.Visible = false;
                pnlDataGrid.Enabled = true;
                pnlManagerInformation.Enabled = true;
            }
            else
            {
                pnlDataGrid.Width = 274;
                dataGridView1.Width = 270;
                pnlManagerInformation.Visible = true;
                pnlDataGrid.Enabled = false;
            }
        }
    }
}
