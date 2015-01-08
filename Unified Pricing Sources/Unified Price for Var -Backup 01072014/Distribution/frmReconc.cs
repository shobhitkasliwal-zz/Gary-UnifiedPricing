using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Unified_Price_for_Var
{
    public partial class frmReconc : Form
    {
        private int groupId;
        private string leadCustomerNumber;

        public frmReconc(int _groupId, string _groupName)
        {
            InitializeComponent();
            btnReconErrors.Enabled = false;

            lblSelectedGroup.Text = _groupName;
            groupId = _groupId;
            leadCustomerNumber = (string)Db.ExecuteScalar("SELECT [Group_Customer_Name] FROM tblDistributionGroupDetail WHERE [Group number] = '{0}' AND Modifier = 'Lead'", groupId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            btnAnalyze.Enabled = false;
            btnReconErrors.Enabled = false;

            Thread th = new Thread(Analyze);
            th.Start();
        }

        public void Analyze()
        {
            var leadItems = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}'", leadCustomerNumber);
            var membersCustomersNumgers = Db.ExecuteDataTable("SELECT * FROM tblDistributionGroupDetail WHERE [Group number] = '{0}' AND Modifier <> 'Lead'", groupId);
            
            if (leadItems.Rows.Count <= 0)
                pgrBar1.Invoke(new Action(() => pgrBar1.Maximum = membersCustomersNumgers.Rows.Count));
            else if (membersCustomersNumgers.Rows.Count <= 0)
                pgrBar1.Invoke(new Action(() => pgrBar1.Maximum = leadItems.Rows.Count));
            else
                pgrBar1.Invoke(new Action(() => pgrBar1.Maximum = leadItems.Rows.Count * membersCustomersNumgers.Rows.Count));

            var i = 0;
            var errors = 0;
            foreach (DataRow memCustNum in membersCustomersNumgers.Rows)
            {               
                var memberItems = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}'", memCustNum["Group_Customer_Name"]);
                progressBar2.Invoke(new Action(() => progressBar2.Value = 0));
                progressBar2.Invoke(new Action(() => progressBar2.Maximum = memberItems.Rows.Count));                
                var i2 = 0;
                foreach (DataRow memberItem in memberItems.Rows)
                {
                    i++;
                    i2++;
                    var leadItem = leadItems.AsEnumerable().Where(lt => lt.Field<string>("Item Number").Equals(memberItem["Item Number"])).SingleOrDefault();
                    if (leadItem == null)
                    {                        
                        dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add("MISSING", memberItem["Item Number"], memCustNum["Group_Customer_Name"], "The Item appears in the Customer list but NOT in the Lead Customer List", memCustNum["Group_Customer_Name"])));
                        errors++;
                    }
                    else
                    {
                        var leadCurrentPrice = Math.Round((decimal)leadItem["Current Price"], 4);
                        decimal dec = Convert.ToDecimal(memCustNum["Percent"]) / 100;

                        if (memCustNum["Modifier"].ToString().Equals("Increase"))
                        {
                            decimal needToBe = Math.Round((leadCurrentPrice + (leadCurrentPrice * dec)), 4);
                            decimal memberCurrentPrice = Math.Round((decimal) memberItem["Current Price"], 4);
                            decimal percentError = Math.Round(((memberCurrentPrice - needToBe) / needToBe * 100), 2);
                            decimal memCustPercent = Math.Round((decimal)memCustNum["Percent"], 2);
                            // x = ((1150 - 1000) / 1000 * 100)
                            if (needToBe != memberCurrentPrice && percentError != 0)
                            {
                                dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add("HIGH", memberItem["Item Number"], memCustNum["Group_Customer_Name"], string.Format("The Price should increase by {0}%, but has been increased by {1}%", memCustPercent, (memCustPercent + percentError)), memCustNum["Group_Customer_Name"], needToBe)));
                                errors++;
                            }
                        }
                        else if (memCustNum["Modifier"].ToString().Equals("Decrease"))
                        {
                            decimal needToBe = Math.Round((leadCurrentPrice - (leadCurrentPrice * dec)), 4);
                            decimal memberCurrentPrice = Math.Round((decimal)memberItem["Current Price"], 4);
                            decimal percentError = Math.Round(((memberCurrentPrice - needToBe) / needToBe * 100), 2);
                            decimal memCustPercent = Math.Round((decimal)memCustNum["Percent"], 2);
                            // x = ((1150 - 1000) / 1000 * 100)
                            if (needToBe != memberCurrentPrice && percentError != 0)
                            {
                                dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add("LOW", memberItem["Item Number"], memCustNum["Group_Customer_Name"], string.Format("The Price should decrease by {0}%, but has been decreased by {1}%", memCustPercent, (memCustPercent + percentError)), memCustNum["Group_Customer_Name"], needToBe)));
                                errors++;
                            }
                        }
                    }

                    try
                    {
                        pgrBar1.Invoke(new Action(() => pgrBar1.Value = i));
                        progressBar2.Invoke(new Action(() => progressBar2.Value = i2));
                        lblTotalErrors.Invoke(new Action(() => lblTotalErrors.Text = errors.ToString()));
                    }
                    catch
                    {
                        pgrBar1.Invoke(new Action(() => pgrBar1.Value = pgrBar1.Maximum));
                        progressBar2.Invoke(new Action(() => progressBar2.Value = progressBar2.Maximum));
                        lblTotalErrors.Invoke(new Action(() => lblTotalErrors.Text = errors.ToString()));
                    }
                }
            }

            pgrBar1.Invoke(new Action(() => pgrBar1.Value = pgrBar1.Maximum));
            progressBar2.Invoke(new Action(() => progressBar2.Value = progressBar2.Maximum));

            btnAnalyze.Invoke(new Action(() => btnAnalyze.Enabled = true));
            btnReconErrors.Invoke(new Action(() => btnReconErrors.Enabled = true));
        }

        private void btnReconErrors_Click(object sender, EventArgs e)
        {
            grpAnalysis.Visible = true;
            btnReconErrors.Enabled = false;
            btnAnalyze.Enabled = false;
            progressBar2.Maximum = dataGridView1.Rows.Count;

            Thread th = new Thread(ReconErrors);
            th.Start();
        }

        public void ReconErrors()
        {
            var i = 0;
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Db.NonQuery("UPDATE tblPricing SET [Current Price] = '{0}' WHERE [Customer Number] = '{1}' AND [Item Number] = '{2}'",
                    Math.Round(Convert.ToDecimal(row.Cells["NeedToBe"].Value), 4),
                    row.Cells["CustomerNumber"].Value,
                    row.Cells["ItemNumber"].Value
                    );
                i++;

                try
                {
                    progressBar2.Invoke(new Action(() => progressBar2.Value = i));
                }
                catch
                {
                    progressBar2.Invoke(new Action(() => progressBar2.Value = progressBar2.Maximum));
                }
            }

            progressBar2.Invoke(new Action(() => progressBar2.Value = progressBar2.Maximum));

            btnReconErrors.Invoke(new Action(() => btnReconErrors.Enabled = true));
            btnAnalyze.Invoke(new Action(() => btnAnalyze.Enabled = true));      
        }
    }
}