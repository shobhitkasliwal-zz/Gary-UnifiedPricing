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
    public partial class frmChangePricing : Form
    {
        public frmChangePricing()
        {
            InitializeComponent();
        }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int ItemCount { get; set; }

        public void LoadForm(string type)
        {
            if (type == "changeprice")
            {
                lblCustomer.Text = string.Format("{0} ({1})", CustomerName, CustomerId);
                ShowMainPanel();
            }
            else if (type == "notavailable")
            {
                lblNotAvailableText.Text = "No items available for update.";
                lblSuccessText.Text = "";
                ShowSuccessNotAvailablePanel();
            }
        }



        private void ShowWarningPanel()
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel1.Visible = false;
            this.Size = new Size(475, 250);
            panel2.Location = new Point(50, 20);
        }

        private void ShowMainPanel()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
            this.Size = new Size(475, 450);
            panel1.Location = new Point(50, 20);

        }

        private void ShowSuccessNotAvailablePanel()
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel1.Visible = false;
            this.Size = new Size(475, 200);
            panel3.Location = new Point(50, 20);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter value for " + lblSelection.Text);
                return;
            }
            decimal changeVal = 0;
            if (!Decimal.TryParse(textBox1.Text, out changeVal))
            {
                MessageBox.Show("Please enter valid value for " + lblSelection.Text);
                return;
            }
            if (!rdoDecreaseAmount.Checked && !rdoDecreasePercent.Checked && !rdoIncreaseAmount.Checked && !rdoIncreasePercent.Checked)
            {
                MessageBox.Show("Please Select Increase/Decrease Type");
                return;
            }
            string changeType = (rdoDecreaseAmount.Checked || rdoDecreasePercent.Checked) ? "Decrease" : "Increase";
            string changeValueType = (rdoDecreaseAmount.Checked || rdoIncreaseAmount.Checked) ? "$ " + changeVal.ToString("n2") : changeVal.ToString("n2") + " %";

            lblWarningText.Text = String.Format("You are going to {0} \r\n the price by {1} \r\n This process is not reversible.", changeType, changeValueType);
            ShowWarningPanel();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblSuccessText.Text = String.Format("{0} Number of Items Updated.", ItemCount.ToString());
            lblNotAvailableText.Text = "No more items available for update.";
            decimal changeVal = 0;
            Decimal.TryParse(textBox1.Text, out changeVal);
            if (rdoDecreasePercent.Checked || rdoIncreasePercent.Checked)
                changeVal = changeVal / 100;
            string ChangePriceQuery  = String.Format(@"Update tblPricing
                                    set  QuoteDate = Date(), [old price]= [Current Price], [Current Price]= [Current Price] {0} {1} where [Customer Number] ='AA-MN-FL' 
                                    and ([QuoteDate] is null or [QuoteDate] <=  DateAdd(""yyyy"",-1,Date())) 
                                    and iif(isnull(Last12MonthQty),0,Last12MonthQty) <=0", (rdoDecreasePercent.Checked || rdoDecreaseAmount.Checked ? " - " : " + "),
                                                                                         (rdoDecreaseAmount.Checked || rdoIncreaseAmount.Checked ? changeVal.ToString() : "(" + changeVal.ToString() + " * [Current Price] )")
                                                                                         );

            Db.NonQuery(ChangePriceQuery);
            ShowSuccessNotAvailablePanel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWarningCancel_Click(object sender, EventArgs e)
        {
            ShowMainPanel();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoIncreasePercent_CheckedChanged(object sender, EventArgs e)
        {
            lblSelection.Text = "Increase %";
            textBox1.Visible = true;
        }

        private void rdoDecreasePercent_CheckedChanged(object sender, EventArgs e)
        {
            lblSelection.Text = "Decrease %";
            textBox1.Visible = true;
        }

        private void rdoIncreaseAmount_CheckedChanged(object sender, EventArgs e)
        {
            lblSelection.Text = "Increase $ amount";
            textBox1.Visible = true;
        }

        private void rdoDecreaseAmount_CheckedChanged(object sender, EventArgs e)
        {
            lblSelection.Text = "Decrease $ amount";
            textBox1.Visible = true;
        }

    }
}
