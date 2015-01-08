using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unified_Price_for_Var
{
    public partial class frmManageInventoryGroup : Form
    {
        public frmManageInventoryGroup()
        {
            InitializeComponent();

            FillItemNotInGroup();
            RefreshDataset();
        }

        private void frmManageInventoryGroup_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            groupBox2.Enabled = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_New_Group_Click(object sender, EventArgs e)
        {
            txtNew_Group.Text = "";
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox2.Enabled = true;
            groupBox3.Visible = true;
            groupBox3.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox1.Visible = true;
            RefreshDataset();
        }

        private void RefreshDataset()
        {
            var dataTable = Db.ExecuteDataTable("SELECT * FROM tblGroupMaster");
            lstGroups.DataSource = dataTable;
            lstGroups.DisplayMember = "Group Name";
            lstGroups.ValueMember = "Group Name";
        }

        private void FillItemInSelectedGroup()
        {
            if (lstGroups.SelectedValue != null)
            {
                lstItems_In_Group.Items.Clear();
                var dataTable = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems WHERE Family = '{0}' ORDER BY [Item Number]", lstGroups.Text);
                foreach (DataRow row in dataTable.Rows)
                {
                    lstItems_In_Group.Items.Add(row["Item Number"].ToString());
                }
                lblNumberOfItems.Text = dataTable.Rows.Count.ToString();
            }            
        }

        private void FillItemNotInGroup()
        {
            lstItems_NotIn_Group.Items.Clear();
            var dataTable2 = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems WHERE [Family] = '' ORDER BY [Item Number]");
            foreach (DataRow row in dataTable2.Rows)
                lstItems_NotIn_Group.Items.Add(row["Item Number"].ToString());           
        }

        private void lstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillItemInSelectedGroup();
        }

        private void btnRemove_Group_Click(object sender, EventArgs e)
        {
            string groupName = lstGroups.SelectedValue.ToString();
            DialogResult result4 = MessageBox.Show("Please confirm deletion of Group:  " +
                groupName + ".", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result4 == DialogResult.Yes)
            {
                foreach (var item in lstItems_In_Group.Items)
                {
                    Db.NonQuery("UPDATE tblItems SET Family = '' WHERE [Item Number] = '{0}'", item);
                }
                Db.NonQuery("DELETE FROM tblGroupMaster WHERE [Group Name] = '{0}'", groupName);
                
                RefreshDataset();
                MessageBox.Show("Group " + groupName + " deleted", "Important");
                
            }
        }

        private void btnAdd_Group_Click(object sender, EventArgs e)
        {
            if (txtNew_Group.Text.Trim().Length > 0)
            {
                try
                {
                    Db.NonQuery("INSERT INTO tblGroupMaster ([Group Name]) VALUES ('{0}')", txtNew_Group.Text);
                    MessageBox.Show("Group  :  " + txtNew_Group.Text + " added", "Information");
                    txtNew_Group.Text = "";
                    RefreshDataset();
                    groupBox3.Visible = false;
                    groupBox1.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Group  :  " + txtNew_Group.Text + " NOT added", "Importent");
                }
            }
            else
            {
                MessageBox.Show("Group name field can not be empty");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in lstItems_NotIn_Group.SelectedItems)
            {
                Db.NonQuery("UPDATE tblItems SET Family = '{0}' WHERE [Item Number] = '{1}'", lstGroups.Text, item);
                lstItems_In_Group.Items.Add(item);
            }
            FillItemNotInGroup();
            MessageBox.Show("Items was added to group " + lstGroups.Text, "Information");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in lstItems_In_Group.SelectedItems)
            {
                Db.NonQuery("UPDATE tblItems SET Family = '' WHERE [Item Number] = '{0}'", item);
                lstItems_NotIn_Group.Items.Add(item);
            }
            FillItemInSelectedGroup();
            MessageBox.Show("Items was removed from the group " + lstGroups.Text, "Information");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string groupName = lstGroups.SelectedValue.ToString();
            DialogResult result4 = MessageBox.Show("Do ypu really want to remove all itesm from Group:  " +
                groupName + ".", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result4 == DialogResult.Yes)
            {
				Cursor.Current = Cursors.WaitCursor;
				using (var connection = new OleDbConnection(Db._connectionString))
				{
					connection.Open();
					OleDbCommand command = connection.CreateCommand();
					foreach (var item in lstItems_In_Group.Items)
					{						
						command.CommandText = string.Format("UPDATE tblItems SET Family = '' WHERE [Item Number] = '{0}'", item);
						command.ExecuteNonQuery();
					}   
				}
				Cursor.Current = Cursors.Default;

                MessageBox.Show("Items from group " + groupName + " was removed", "Important");
                RefreshDataset();
                FillItemInSelectedGroup();
                FillItemNotInGroup();
            }
        }
    }
}
