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
    public partial class frmUpdateLast12MoQty : Form
    {
        public frmUpdateLast12MoQty()
        {
            InitializeComponent();
        }
        private void frmUpdateLast12MoQty_Load(object sender, EventArgs e)
        {
            var details = Db.ExecuteDataTable("SELECT [Customer Number], '(' + [Customer Number] + ') ' + [Customer Bill Name] as Customer FROM tblDistributionGroupDetail gd inner join tblCustomers cus on gd.Group_Customer_Name = cus.[Customer Number]  WHERE [Group number] = '2' ORDER BY [Percent]");

            cmbCustomer.DataSource = details;
            cmbCustomer.DisplayMember = "Customer";
            cmbCustomer.ValueMember = "Customer Number";
            cmbCustomer.Text = " -- Select One -- ";
            cmbCustomer.SelectedIndex = -1;



        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }
            else
            {
                Db.NonQuery(string.Format("UPDATE tblPricing set Last12MonthQTY = 1 where [Customer Number]='{0}'", cmbCustomer.SelectedValue));
                DialogResult dialog = MessageBox.Show("Last 12 month Qty Updated Successfully.", "", MessageBoxButtons.OK);
               
                this.Close();
            }
        }


    }
}
