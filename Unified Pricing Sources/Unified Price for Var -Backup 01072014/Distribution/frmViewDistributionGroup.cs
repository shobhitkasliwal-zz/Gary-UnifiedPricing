using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unified_Price_for_Var
{
    public partial class frmViewDistributionGroup : Form
    {
        public frmViewDistributionGroup()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//=============================================================================
        public void RefreshGroupList()
        {
            var dataTable = Db.ExecuteDataTable("SELECT * FROM tblDistributionGroupMaster");
            lstDistMaster.DataSource = dataTable;
            lstDistMaster.DisplayMember = "Group Name";
            lstDistMaster.ValueMember = "ID";            
        }
//=======================================================================================
        public void FillCustomersBySelectedGroup()
        {
            if (lstDistMaster.SelectedValue != null)
            {
                lblGroupName.Text = lstDistMaster.Text;
                var details = Db.ExecuteDataTable("SELECT * FROM tblDistributionGroupDetail WHERE [Group number] = '{0}' ORDER BY [Percent]", lstDistMaster.SelectedValue);
                grdDetail.Rows.Clear();
                foreach (DataRow row in details.Rows)
                {
                    var custRow = Db.ExecuteDataRow("SELECT [Customer Bill Name] FROM tblCustomers WHERE [Customer Number] = '{0}'", row["Group_Customer_Name"]);

                    grdDetail.Rows.Add(row["ID"], custRow["Customer Bill Name"] + " (" + row["Group_Customer_Name"] + ")", row["Modifier"], Convert.ToDecimal(row["Percent"]).ToString("0.00") + "%");
                }

                grdDetail.Rows[0].Cells[2].Style.ForeColor = Color.Red;
            }
        }

        private void frmViewDistributionGroup_Load(object sender, EventArgs e)
        {
            RefreshGroupList();
            FillCustomersBySelectedGroup();
        }

        private void btnAdd_NewGroup_Click(object sender, EventArgs e)
        {
            pnlNewGroup.Visible = true;
        	btnEditGroup.Enabled = false;
            rdoIncrease.Checked = true;
			grdNewGroupCustomer.Rows.Clear();

            var dataTable = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] + ' (' + [Customer Number] + ')' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Bill Name]");
            cmbLeadCustomer.DataSource = dataTable;
            cmbLeadCustomer.DisplayMember = "Combinet Name";            
            cmbLeadCustomer.ValueMember = "Customer Number";

            var dataTable2 = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] + ' (' + [Customer Number] + ')' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Bill Name]");
            cmbSelectCustomer.DataSource = dataTable2;
            cmbSelectCustomer.DisplayMember = "Combinet Name";            
            cmbSelectCustomer.ValueMember = "Customer Number";    

            btnAdd_NewGroup.Enabled = false;
            btnDelete_Group.Enabled = false;
            btnReconcilidate.Enabled = false;
            btnPrint_Group.Enabled = false;
            btnExit.Enabled = false;
            lstDistMaster.Enabled = false;
            txtGroupName.Focus();
            txtPercent.Text = "0.00";
        }

        private void lstDistMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCustomersBySelectedGroup();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlNewGroup.Visible = false;
            btnAdd_NewGroup.Enabled = true;
            btnDelete_Group.Enabled = true;
            btnReconcilidate.Enabled = true;
            btnPrint_Group.Enabled = true;
            btnExit.Enabled = true;
            lstDistMaster.Enabled = true;
        	btnCancel.Text = "Cancel New Group";
			btnSave.Text = "Save New Group";
        	isInEditing = false;
			btnEditGroup.Enabled = true;
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("First enter new group name", "Information");
            }
            else
            {
                cmbLeadCustomer.Enabled = false;
                txtGroupName.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnAddCust.Enabled = false;
                btnRemoveCust.Enabled = false;
                btnSaveCust.Enabled = true;
                btnCancelCust.Enabled = true;
                groupBox2.Enabled = true;
                cmbSelectCustomer.Focus();
            }
        }

        private void btnCancelCust_Click(object sender, EventArgs e)
        {
            cmbLeadCustomer.Enabled = true;
            txtGroupName.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnAddCust.Enabled = true;
            btnRemoveCust.Enabled = true;
            btnSaveCust.Enabled = false;
            btnCancelCust.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            txtPercent.Text = txtPercent.Text.Replace(",", ".");
            decimal percent;
            if (decimal.TryParse(txtPercent.Text, NumberStyles.Any, new CultureInfo("en-US"), out percent) == false || percent <= 0)
            {
                MessageBox.Show("Please enter percent > 0");
                return;
            }

            string modifier = "";
            if (rdoIncrease.Checked)            
                modifier = "Increase";            
            else if (rdoDecrease.Checked)            
                modifier = "Decrease";            

            try
            {
                grdNewGroupCustomer.Rows.Add(cmbSelectCustomer.SelectedValue, cmbSelectCustomer.Text, modifier, percent + "%");

                MessageBox.Show("Customer " + cmbSelectCustomer.Text + " added to the group " + txtGroupName.Text);               
            }
            catch
            {
                MessageBox.Show("Customer NOT  added to the group " + txtGroupName.Text);
            }

            btnAddCust.Enabled = true;
            btnRemoveCust.Enabled = true;
            btnSaveCust.Enabled = false;
            btnCancelCust.Enabled = false;
            groupBox2.Enabled = false;
            txtGroupName.Enabled = true;
            cmbLeadCustomer.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtPercent.Text = "0.00";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (txtGroupName.Text == "" || cmbLeadCustomer.SelectedValue.ToString() == "")
			{
				MessageBox.Show("Group Number and Lead Customer can not be empty.", "Information");
				txtGroupName.Focus();
				return;
			}

			if (isInEditing)
			{
				isInEditing = false;
				btnEditGroup.Enabled = true;

				Db.NonQuery("UPDATE tblDistributionGroupMaster SET [Group Name] = '{0}' WHERE ID = {1}", txtGroupName.Text, lstDistMaster.SelectedValue);

				Db.NonQuery("UPDATE tblDistributionGroupDetail SET [Group_Customer_Name] = '{0}' WHERE [Group number] = '{1}' AND [Modifier] = 'Lead'",
					cmbLeadCustomer.SelectedValue,
					lstDistMaster.SelectedValue);

				Db.NonQuery("DELETE FROM tblDistributionGroupDetail WHERE [Group number] = '{0}' AND [Modifier] <> 'Lead'", lstDistMaster.SelectedValue);
				foreach (DataGridViewRow row in grdNewGroupCustomer.Rows)
				{
					Db.NonQuery("INSERT INTO tblDistributionGroupDetail ([Group number], [Group_Customer_Name], [Modifier], [Percent]) VALUES ('{0}', '{1}', '{2}', '{3}')",
						lstDistMaster.SelectedValue,
						row.Cells["ID2"].Value,
						row.Cells["Modifier2"].Value,
						row.Cells["Percent2"].Value.ToString().Replace("%", ""));
				}

				MessageBox.Show("Group " + txtGroupName.Text + " updated.");
			}
			else
			{
				//try
				{
					Db.NonQuery("INSERT INTO tblDistributionGroupMaster ([Group Name]) VALUES ('{0}')", txtGroupName.Text);
					var masterId = Db.ExecuteDataRow("SELECT MAX(ID) FROM tblDistributionGroupMaster")[0];

					// create lead cunstomer
					//var leadCust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", cmbLeadCustomer.SelectedValue);
					Db.NonQuery("INSERT INTO tblDistributionGroupDetail ([Group number], [Group_Customer_Name], [Modifier], [Percent]) VALUES ('{0}', '{1}', '{2}', '{3}')",
						masterId,
						cmbLeadCustomer.SelectedValue,
						"Lead",
						"0");

					// add other customers
					foreach (DataGridViewRow row in grdNewGroupCustomer.Rows)
					{
						Db.NonQuery("INSERT INTO tblDistributionGroupDetail ([Group number], [Group_Customer_Name], [Modifier], [Percent]) VALUES ('{0}', '{1}', '{2}', '{3}')",
							masterId,
							row.Cells["ID2"].Value,
							row.Cells["Modifier2"].Value,
							row.Cells["Percent2"].Value.ToString().Replace("%", ""));
					}


					MessageBox.Show("New group " + txtGroupName.Text + " added.");
				}
				/*catch
				{
					MessageBox.Show("New group NOT added. See system admilistrator.", "Warning");
				}*/
			}

			RefreshGroupList();
			pnlNewGroup.Visible = false;
			btnAdd_NewGroup.Enabled = true;
			btnDelete_Group.Enabled = true;
			btnReconcilidate.Enabled = true;
			btnPrint_Group.Enabled = true;
			btnExit.Enabled = true;
			lstDistMaster.Enabled = true;
        }

        private void btnDelete_Group_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete group: " + lstDistMaster.Text, "Important", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var details = Db.ExecuteDataTable("SELECT ID FROM tblDistributionGroupDetail WHERE [Group number] = '{0}'", lstDistMaster.SelectedValue);
                foreach (DataRow row in details.Rows)
                {
                    Db.NonQuery("DELETE FROM tblDistributionGroupDetail WHERE ID = {0}", row["ID"]);
                }
                Db.NonQuery("DELETE FROM tblDistributionGroupMaster WHERE ID = {0}", lstDistMaster.SelectedValue);
                RefreshGroupList();
                MessageBox.Show("Group was deleted.");
            }
        }
       
        private void btnReconcilidate_Click(object sender, EventArgs e)
        {
            frmReconc nextScreen = new frmReconc((int)lstDistMaster.SelectedValue, lstDistMaster.Text);
            DialogResult result = nextScreen.ShowDialog();
            
        }
 
        private void btnRemoveCust_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdNewGroupCustomer.SelectedRows)
            {
                grdNewGroupCustomer.Rows.RemoveAt(row.Index);
            }
        }

        private void grdNewGroupCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        	btnRemoveCust.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLeadCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

    	private bool isInEditing = false;

		private void btnEditGroup_Click(object sender, EventArgs e)
		{
			isInEditing = true;
			btnEditGroup.Enabled = false;
			var groupCustomers = Db.ExecuteDataTable("SELECT * FROM tblDistributionGroupDetail WHERE [Group number] = '{0}'", lstDistMaster.SelectedValue);

			grdNewGroupCustomer.Rows.Clear();

			txtGroupName.Text = lstDistMaster.Text;

			DataRow leadRow = null;
			foreach (DataRow gCust in groupCustomers.Rows)
			{
				if ((string)gCust["Modifier"] != "Lead")
				{
					var cust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", gCust["Group_Customer_Name"]);
					grdNewGroupCustomer.Rows.Add(gCust["Group_Customer_Name"], cust["Customer Bill Name"] + " (" + gCust["Group_Customer_Name"] + ")", gCust["Modifier"], Convert.ToDecimal(gCust["Percent"]).ToString("0.00") + "%");
				}
				else
					leadRow = gCust;
			}

			pnlNewGroup.Visible = true;
			rdoIncrease.Checked = true;

			var dataTable = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] + ' (' + [Customer Number] + ')' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Bill Name]");
			cmbLeadCustomer.DataSource = dataTable;
			cmbLeadCustomer.DisplayMember = "Combinet Name";
			cmbLeadCustomer.ValueMember = "Customer Number";
			cmbLeadCustomer.SelectedValue = leadRow["Group_Customer_Name"];

			var dataTable2 = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] + ' (' + [Customer Number] + ')' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Bill Name]");
			cmbSelectCustomer.DataSource = dataTable2;
			cmbSelectCustomer.DisplayMember = "Combinet Name";
			cmbSelectCustomer.ValueMember = "Customer Number";

			btnAdd_NewGroup.Enabled = false;
			btnDelete_Group.Enabled = false;
			btnReconcilidate.Enabled = false;
			btnPrint_Group.Enabled = false;
			btnExit.Enabled = false;
			lstDistMaster.Enabled = false;
			txtGroupName.Focus();
			txtPercent.Text = "0.00";
			//
			btnCancel.Text = "Cancel Edit Group";
			btnSave.Text = "Save Changes";
		}

		private void grdNewGroupCustomer_SelectionChanged(object sender, EventArgs e)
		{
			btnRemoveCust.Enabled = true;
		}
//=========================================================================
        private void btnPrint_Group_Click(object sender, EventArgs e)
        {
            Db.NonQuery("DELETE FROM tblByDistr_Group_Report");

            if (lstDistMaster.SelectedValue != null)
            {
                var details = Db.ExecuteDataTable("SELECT * FROM tblDistributionGroupDetail WHERE [Group number] = '{0}' ORDER BY [Percent]", lstDistMaster.SelectedValue);

               
                foreach (DataRow custRow in details.Rows)
                {
                    Db.NonQuery("INSERT INTO tblByDistr_Group_Report ([Group_Number], [Group_Name],[Group_Customer],[Modifier],[Percent]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    lstDistMaster.SelectedValue,
                    lstDistMaster.Text,
                    custRow["Group_Customer_Name"],
                    custRow["Modifier"],
                    custRow["Percent"]);
                }

                frmByDisrt_Group_Report_Viewer frm = new frmByDisrt_Group_Report_Viewer();
                frm.Show();
            }
        }
//========================================================
    }
}