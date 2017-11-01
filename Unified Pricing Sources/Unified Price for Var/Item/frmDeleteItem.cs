using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unified_Price_for_Var.Item
{
    public partial class frmDeleteItem : Form
    {
        public frmDeleteItem()
        {
            InitializeComponent();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
           
            if (chkMasterItemTable.Checked && !chkCustomerListing.Checked)
            {
                MessageBox.Show("\"Master Item table\" should be selected only with selection on \"Customer Listing\" . ");
                return;
            }
            if (!chkCustomerListing.Checked)
            {
                MessageBox.Show("Please select at least one option Customer Listing or Master Item Table. ");
                return;
            }

            var confirmResult = MessageBox.Show(String.Format("You selected to remove item {0} - {1} from all customer listings {2}" + Environment.NewLine + "Please Confirm.", cbItemFrom.SelectedValue, cbItemTo.SelectedValue, chkMasterItemTable.Checked ? "and from Item Master Table." : "." ),
                                      "Confirm Delete!!",
                                      MessageBoxButtons.YesNo);
            if (confirmResult == System.Windows.Forms.DialogResult.Yes)
            {
                if (chkCustomerListing.Checked)
                {
                    Db.NonQuery(String.Format("DELETE FROM tblPricing where [Item Number] BETWEEN '{0}' and '{1}' ", cbItemFrom.SelectedValue, cbItemTo.SelectedValue));
                }
                if (chkMasterItemTable.Checked)
                {
                    Db.NonQuery(String.Format("DELETE FROM tblItems where [Item Number] BETWEEN '{0}' and '{1}' ", cbItemFrom.SelectedValue, cbItemTo.SelectedValue));
                }
                MessageBox.Show("Items removed.","Success",MessageBoxButtons.OK);
                this.Close();
                return;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDeleteItem_Load(object sender, EventArgs e)
        {
            DataTable _dataTableItemsFrom = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");
            cbItemFrom.DisplayMember = "Item Number";
            cbItemFrom.ValueMember = "Item Number";
            cbItemFrom.DataSource = new DataView(_dataTableItemsFrom);


            cbItemTo.DisplayMember = "Item Number";
            cbItemTo.ValueMember = "Item Number";
            cbItemTo.DataSource = new DataView(_dataTableItemsFrom);

           

        }

   
    }
}
