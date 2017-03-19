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
    public partial class frmCopyPrices : Form
    {
        private string _copyToCustomerNumber;

        public frmCopyPrices(string copyToCustomerNumber, string copyToCustomerCombinetName)
        {
            InitializeComponent();
            _copyToCustomerNumber = copyToCustomerNumber;
            lblCopy_To.Text = copyToCustomerCombinetName;
            
        }

        public void FillGridByCustomer()
        {
            var prices = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}' ORDER BY [Item Number]", cmbCustomers.SelectedValue);
            gridPrices.Rows.Clear();
            foreach (DataRow price in prices.Rows)
            {
                gridPrices.Rows.Add(price["Item Number"], ((decimal)price["Current Price"]).ToString("0.0000"), ((decimal)price["Old Price"]).ToString("0.0000"), price["Item Description"], price["Customer Item Number"], price["ID"], price["QuoteDate"]);
            }
        }

        private void frmCopyPrices_Load(object sender, EventArgs e)
        {
            var dataTable = Db.ExecuteDataTable("SELECT *, [Customer Bill Name] + ' ( ' + [Customer Number] + ' ) ' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Bill Name]"); ;


            cmbCustomers.DataSource = dataTable;
            cmbCustomers.DisplayMember = "Combinet Name";
            cmbCustomers.ValueMember = "Customer Number";
            FillGridByCustomer();
        }

        private void cmbSelect_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridByCustomer();
        }
        //======================================================================================================
        private void btnCopy_Prices_Click(object sender, EventArgs e)
        {
            if (chbRepDup.Checked == false || rdoSkip.Checked == true)
            {
                foreach (DataGridViewRow row in gridPrices.SelectedRows)
                {
                    Db.NonQuery("INSERT INTO tblPricing ([Customer Number], [Item Number], [Item Description], [Current Price], [Old Price], [Customer Item Number], [QuoteDate]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}')",
                        _copyToCustomerNumber,
                        row.Cells["ItemNumber"].Value.ToString(),
                        Db.AddSlashes(row.Cells["ItemDescription"].Value.ToString()),
                        row.Cells["CurrentPrice"].Value.ToString(),
                        row.Cells["PreviousPrice"].Value.ToString(),
                        row.Cells["CustomerItemNumber"].Value.ToString(),
                        row.Cells["QuoteDate"].Value.ToString()
                        );
                }
            }
            else
            {
                if (rdoReplace.Checked)
                {
                    foreach (DataGridViewRow row in gridPrices.SelectedRows)
                    {
                        Db.NonQuery("DELETE FROM tblPricing WHERE [Customer Number] = '{0}' AND [Item Number] = '{1}", _copyToCustomerNumber, row.Cells["ItemNumber"].Value);
                        Db.NonQuery("INSERT INTO tblPricing ([Customer Number], [Item Number], [Item Description], [Current Price], [Old Price], [Customer Item Number], [QuoteDate]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                            _copyToCustomerNumber,
                            row.Cells["ItemNumber"].Value.ToString(),
                            Db.AddSlashes(row.Cells["ItemDescription"].Value.ToString()),
                            row.Cells["CurrentPrice"].Value.ToString(),
                            row.Cells["PreviousPrice"].Value.ToString(),
                            row.Cells["CustomerItemNumber"].Value.ToString(),
                            row.Cells["QuoteDate"].Value.ToString()

                            );
                    }
                }
                else if (rdoExcept.Checked)
                {
                    foreach (DataGridViewRow row in gridPrices.SelectedRows)
                    {
                        var c2 = Db.ExecuteDataRow("SELECT * FROM tblPricing WHERE [Item Number] = '{0}'", row.Cells["ItemNumber"].Value);
                        if (c2 != null)
                        {
                            if (Convert.ToDecimal(row.Cells["CurrentPrice"]) > Convert.ToDecimal(c2["Current Price"]))
                            {
                                Db.NonQuery("DELETE FROM tblPricing WHERE [Customer Number] = '{0}' AND [Item Number] = '{1}", _copyToCustomerNumber, c2["Item Number"]);
                                Db.NonQuery("INSERT INTO tblPricing ([Customer Number], [Item Number], [Item Description], [Current Price], [Old Price], [Customer Item Number], [QuoteDate]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                    _copyToCustomerNumber,
                                    row.Cells["ItemNumber"].Value.ToString(),
                                    Db.AddSlashes(row.Cells["ItemDescription"].Value.ToString()),
                                    row.Cells["CurrentPrice"].Value.ToString(),
                                    row.Cells["PreviousPrice"].Value.ToString(),
                                    row.Cells["CustomerItemNumber"].Value.ToString(),
                                    row.Cells["QuoteDate"].Value.ToString()

                                    );
                            }
                        }
                        else
                        {
                            Db.NonQuery("INSERT INTO tblPricing ([Customer Number], [Item Number], [Item Description], [Current Price], [Old Price], [Customer Item Number], [QuoteDate]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                _copyToCustomerNumber,
                                row.Cells["ItemNumber"].Value.ToString(),
                                Db.AddSlashes(row.Cells["ItemDescription"].Value.ToString()),
                                row.Cells["CurrentPrice"].Value.ToString(),
                                row.Cells["PreviousPrice"].Value.ToString(),
                                row.Cells["CustomerItemNumber"].Value.ToString(),
                                row.Cells["QuoteDate"].Value.ToString()

                                );
                        }
                    }
                }
            }

            if (chbDeleteAfterCopy.Checked)
            {
                Db.NonQuery("DELETE FROM tblCustomers WHERE [Customer Number] = '{0}'", cmbCustomers.SelectedValue);
            }

            MessageBox.Show(string.Format("Selected Items of Customer {0} copied to Customer {1}", cmbCustomers.Text, lblCopy_To.Text));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //====================================================================================================
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbRepDup_CheckedChanged(object sender, EventArgs e)
        {
            grpReplace.Enabled = chbRepDup.Checked;
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridPrices.Rows)
                row.Selected = true;
        }

        private void rdoReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoReplace.Checked)
                rdoReplace.Font = new Font(rdoReplace.Font.FontFamily, rdoReplace.Font.Size, FontStyle.Bold);
            else
                rdoReplace.Font = new Font(rdoReplace.Font.FontFamily, rdoReplace.Font.Size, FontStyle.Regular);
        }

        private void rdoExcept_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExcept.Checked)
                rdoExcept.Font = new Font(rdoExcept.Font.FontFamily, rdoExcept.Font.Size, FontStyle.Bold);
            else
                rdoExcept.Font = new Font(rdoExcept.Font.FontFamily, rdoExcept.Font.Size, FontStyle.Regular);
        }

        private void rdoSkip_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSkip.Checked)
                rdoSkip.Font = new Font(rdoSkip.Font.FontFamily, rdoSkip.Font.Size, FontStyle.Bold);
            else
                rdoSkip.Font = new Font(rdoSkip.Font.FontFamily, rdoSkip.Font.Size, FontStyle.Regular);
        }

        private void cmbCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }


    }
}
