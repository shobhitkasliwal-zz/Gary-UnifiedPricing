using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using Unified_Price_for_Var.Properties;

namespace Unified_Price_for_Var
{
    public partial class ItemConversion : Form
    {
        public DataTable FromDataTable;
        public DataTable ToDataTable;

        public ItemConversion()
        {
            InitializeComponent();
            Load += new System.EventHandler(ItemConversion_Load);
        }

        private void ItemConversion_Load(object sender, EventArgs e)
        {
            FromDataTable = Db.ExecuteDataTable("Select [Item Number] From tblItems ORDER BY [Item Number]");
            cmbFrom.DataSource = FromDataTable;
            cmbFrom.DisplayMember = "Item Number";
            cmbFrom.ValueMember = "Item Number";

            ToDataTable = Db.ExecuteDataTable("Select [Item Number] From tblItems ORDER BY [Item Number]");
            cmbTo.DataSource = ToDataTable;
            cmbTo.DisplayMember = "Item Number";
            cmbTo.ValueMember = "Item Number";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------------------------------------------------
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cmbFrom.SelectedValue == cmbTo.SelectedValue)
            {
                MessageBox.Show("Item FROM and TO can not be the same.", "Information");
                return;
            }

            if (MessageBox.Show("You are going to change Item number to ALL customers in the COMPANY. \n It is very dangerous process. Are you sure you like to continue???", "Important questions", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    
                    Cursor.Current = Cursors.WaitCursor;
                    var NewItemData = Db.ExecuteDataRow("Select * from tblItems where [Item Number] = '{0}'", cmbTo.SelectedValue); 
                    
                    Db.NonQuery("Update tblPricing Set [Item Number] = '{0}', [Item Description] = '{1}'  where [Item Number] = '{2}'",
               //             cmbTo.SelectedValue.ToString(),
                            NewItemData["Item Number"],
                            NewItemData["Item Description"],
                           cmbFrom.SelectedValue.ToString());        
            
              //      Db.NonQuery("UPDATE tblPricing SET [Item Number] = '{0}' WHERE [Item Number] = {1}", cmbTo.SelectedValue, cmbFrom.SelectedValue);
                    Cursor.Current = Cursors.Default;
                }
                catch
                {
                    MessageBox.Show("Data base was not updated. See System Administrator.", "Info");
                }

            }
            MessageBox.Show("Item numbers updated.", "Information");
        }

        private void ItemConversion_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pricing_for_Tanya_DataSet.tblCustomers' table. You can move, or remove it, as needed.
            this.tblCustomersTableAdapter.Fill(this.pricing_for_Tanya_DataSet.tblCustomers);

        }

    }

}
