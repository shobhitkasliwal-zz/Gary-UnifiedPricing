using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unified_Price_for_Var.Item;


namespace Unified_Price_for_Var
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmViewCustomer nextScreen = new frmViewCustomer();
            DialogResult result = nextScreen.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmViewItem nextScreen1 = new frmViewItem();
            DialogResult result = nextScreen1.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmViewPricing nextScreen2 = new frmViewPricing();
            DialogResult result = nextScreen2.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btnDistr_List_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmMyDistribution nextScreen3 = new frmMyDistribution();
            DialogResult result = nextScreen3.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btnGroup_Pricing_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmChangeGroupPricing nextScreen4 = new frmChangeGroupPricing();
            DialogResult result = nextScreen4.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmReports nextScreen5 = new frmReports();
            DialogResult result = nextScreen5.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            var users = Db.ExecuteDataTable("SELECT * FROM tblUsers");
            foreach (DataRow user in users.Rows)
            {
                txtUsername.Items.Add(user["Username"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var results = Db.ExecuteDataTable("SELECT * FROM tblUsers WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'");

            if (results.Rows.Count > 0)
                panel1.Visible = false;
            else
                MessageBox.Show("Username/Password incorrect");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            BackUp.frmBackUp nextScreen6 = new BackUp.frmBackUp();
            DialogResult result = nextScreen6.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ItemConversion nextScreen7 = new ItemConversion();
            DialogResult result = nextScreen7.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btnMainNetFull_Click(object sender, EventArgs e)
        {
            var InActiveQty = Db.ExecuteScalar(@"SELECT count('*') from tblPricing 
                                    where [Customer Number] ='AA-MN-FL' 
                                    and ([QuoteDate] is null or [QuoteDate] <=  DateAdd(""yyyy"",-1,Date())) 
                                    and iif(isnull(Last12MonthQty),0,Last12MonthQty) <=0 ");
            frmChangePricing frmChangePricing = new frmChangePricing();
            string type = "notavailable";
            if (Convert.ToInt32(InActiveQty) > 0)
            {
                frmChangePricing.CustomerId = "AA-MN-FL";
                frmChangePricing.CustomerName = "MAINTENANCE NETS, FULL LINE";
                frmChangePricing.ItemCount = Convert.ToInt32(InActiveQty);
                type = "changeprice";
            }
            frmChangePricing.LoadForm(type);
            frmChangePricing.ShowDialog();

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            frmDeleteItem frm = new frmDeleteItem();
            frm.ShowDialog();

        }

        private void btnSpreadNewESItems_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(String.Format("You are going to update members of \"Full Item group\"" + Environment.NewLine + "Please Confirm."),
                                      "Confirm Update!!",
                                      MessageBoxButtons.OKCancel);

            if (confirmResult == System.Windows.Forms.DialogResult.OK)
            {
                DataTable dtGroup = Db.ExecuteDataTable("SELECT b.[Group_Customer_Name], b.[Percent], b.Modifier from tblDistributionGroupMaster a Inner Join tblDistributionGroupDetail b on a.[Group Number] = b.[Group Number] where a.[Group Name] = 'Full Item List' ");
                DataTable dt = Db.ExecuteDataTable("Select [Item Number], [Std Pack QTY], [Price] from tbl_VAR_NEW_ES");
                foreach (DataRow row in dt.Rows)
                {
                    var iDesc = Db.ExecuteScalar(String.Format("SELECT [Item Description] from tblItems where [Item Number]='" + row["Item Number"].ToString() + "'"));
                    string itemDescription = iDesc != null && !string.IsNullOrEmpty(iDesc.ToString()) ? iDesc.ToString() : "";
                    foreach (DataRow group in dtGroup.Rows)
                    {

                        decimal newPrice = 0;
                        decimal percent = 0;
                        Decimal.TryParse(group["Percent"].ToString(), out percent);
                        if (Decimal.TryParse(row["Price"].ToString(), out newPrice))
                        {
                            switch (group["Modifier"].ToString().ToUpper())
                            {
                                case "LEAD":
                                    newPrice = newPrice * 1;
                                    break;
                                case "INCREASE":
                                    newPrice = newPrice * (1 + (percent / 100));
                                    break;
                                case "DECREASE":
                                    newPrice = newPrice * (1 - (percent / 100));
                                    break;
                            }
                            var itemCount = Db.ExecuteScalar(String.Format("select count('*') from tblPricing where [Customer Number]='{0}' and [Item Number] ='{1}'", group["Group_Customer_Name"].ToString(), row["Item Number"].ToString()));
                            if (Convert.ToInt32(itemCount) > 0)
                            {
                                Db.NonQuery(String.Format("UPDATE tblPricing set [Current Price]={0}, [Item Description]='{1}',[Break Pak Net]='{2}',[QuoteDate]='{3}' where [Customer Number]='{4}' and [Item Number] ='{5}'", newPrice.ToString(), itemDescription, row["Std Pack QTY"].ToString(), DateTime.Today.ToShortDateString(), group["Group_Customer_Name"].ToString(), row["Item Number"].ToString()));
                            }
                            else
                            {
                                Db.NonQuery(String.Format("INSERT INTO tblPricing ([Item Number], [Customer Number], [Current Price], [Item Description],[Notes],[QuoteDate]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}' )", row["Item Number"].ToString(), group["Group_Customer_Name"].ToString(), newPrice.ToString(), itemDescription, row["Std Pack QTY"].ToString(), DateTime.Today.ToShortDateString()));
                            }
                        }
                    }

                }

                MessageBox.Show("Members of group \"Full Item Group\" updated successfully.", "Success", MessageBoxButtons.OK);

            }

        }
    }
}
