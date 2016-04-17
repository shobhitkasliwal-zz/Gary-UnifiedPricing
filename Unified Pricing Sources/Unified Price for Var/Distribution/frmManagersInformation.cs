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
            pnlManagerInformation.Enabled = false;
            btnCancel.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnEdit.Visible = false;
            btnUpdate.Visible = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlManagerInformation.Enabled = false;
            pnlDataGrid.Enabled = true;
            btnCancel.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnEdit.Visible = false;
            btnUpdate.Visible = false;
            ResetForm();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            pnlManagerInformation.Enabled = true;
            ResetForm();
            btnSave.Visible = true;
            btnCancel.Visible = true;
            pnlDataGrid.Enabled = false;
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
            txtManagerName.Focus();

        }

    }
}
