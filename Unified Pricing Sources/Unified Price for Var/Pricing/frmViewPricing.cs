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
using System.Linq;

namespace Unified_Price_for_Var
{
    public partial class frmViewPricing : Form
    {
        public DataTable _dataTableItems;

        public frmViewPricing()
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
            InitializeComponent();

        }

        public void FillGridByCustomer()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            //old	var prices = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}' ORDER BY [Item Number]", cmbCustomers.SelectedValue);

            var prices = Db.ExecuteDataTable("SELECT P.[ID] as IDn, P.[Customer Number], P.[Item Number] as [ItemN], P.[Current Price] , I.[Item Description] as [ItemDS], P.[Customer Item Number] as [CustIN], P.[Old Price], P.[Notes] as [NotesP], format(P.[QuoteDate],'mmm dd yyyy') as[QuoteDateP], IIF(ISNULL( P.[Last12MonthQTY]), 0, P.[Last12MonthQTY]) as [Last12MonthQTYP]  FROM tblPricing P left join tblItems I on P.[Item Number] = I.[Item Number] WHERE P.[Customer Number] = '{0}' ORDER BY P.[Item Number]", cmbCustomers.SelectedValue);

            gridPrices.Rows.Clear();
            foreach (DataRow price in prices.Rows)
            {
                //old      gridPrices.Rows.Add(price["Item Number"], ((decimal)price["Current Price"]).ToString("0.0000"), ((decimal)price["Old Price"]).ToString("0.0000"), price["Item Description"], price["Customer Item Number"], price["ID"]);
                decimal CurP = 0;
                Decimal.TryParse(price["Current Price"].ReplaceNulls("0"), out CurP);
                decimal OldP = 0;
                Decimal.TryParse(price["Old Price"].ReplaceNulls("0"), out OldP);

                gridPrices.Rows.Add(price["ItemN"], CurP.ToString("0.0000"), OldP.ToString("0.0000"), price["ItemDS"], price["NotesP"], price["CustIN"], price["Last12MonthQTYP"], price["QuoteDateP"], price["IDn"]);
            }
            lblTotalPricesForCust.Text = "Total: " + prices.Rows.Count;
            lbl11.Text = cmbCustomers.SelectedValue.ToString().Replace("&", "&&");  //Showing up customers number like: AS or CFT

        }

        private void frmViewPricing_Load(object sender, EventArgs e)
        {
            // this.Visible = false;

            var dataTable = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] + ' (' + [Customer Number] + ')' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Bill Name]");
            cmbCustomers.DataSource = dataTable;
            cmbCustomers.DisplayMember = "Combinet Name";
            cmbCustomers.ValueMember = "Customer Number";


            FillGridByCustomer();

            _dataTableItems = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");

            cmbQuick_Check.DataSource = _dataTableItems;
            cmbQuick_Check.DisplayMember = "Item Number";
            cmbQuick_Check.ValueMember = "Item Number";

            //  this.Visible = true;
        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {

            cmbCustomers.Enabled = false;
            gridPrices.Enabled = false;

            grpPriceChange.Visible = false;
            grpPriceInfo.Visible = true;

            cmbQuick_Check.Enabled = false;
            btnMarkAsOld.Enabled = false;
            btnCopy.Enabled = false;
            btnCheckDuplicate.Enabled = false;
            btnRollBack.Enabled = true;
            btnEmail.Enabled = true;
            btnChange_Price.Enabled = false;
            btnDeletePrice.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddPrice.Enabled = false;
            btnUpdSPQ.Enabled = false;

            cmbItemNumb.Enabled = true;
            txtCurrent_Price.Enabled = true;
            //               txtCurrent_Price.Text = "0.0000";
            txtCurrent_Price.Text = " ";
            //               txtItem_description.Enabled = true;
            txtItem_description.Enabled = false;
            txtItem_description.Text = " ";
            txtCustomer_Item_Number.Enabled = true;
            txtNotes.Enabled = true;
            txtNotes.Text = " ";
            txtStdQTY_Add.Enabled = true;
            txtStdQTY_Add.Text = "0";

            cmbItemNumb.DataSource = _dataTableItems;
            cmbItemNumb.DisplayMember = "Item Number";
            cmbItemNumb.ValueMember = "Item Number";
        }

        private void grpBox1_Enter(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------------------------
        private void txtChange_Price_Click(object sender, EventArgs e)
        {

            var change = MessageBox.Show("Are you sure you like to change this Item price?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            double num;
            bool isNumber = double.TryParse(txtNotes.Text, out num);
            if (isNumber)
            {
            }
            else
            {
                MessageBox.Show("Std Pac QTY - should be number");
                return;
            }


            if (change == DialogResult.Yes)
            {
                var rows = gridPrices.SelectedRows;

                if (rows.Count != 1)
                {
                    MessageBox.Show("You must select one price item.");
                    return;
                }

                var row = rows[0];


                decimal currentPrice;
                if (!Decimal.TryParse(textBox2.Text, out currentPrice))
                {
                    MessageBox.Show("Please enter the valid price.");
                    return;
                }

                if (txtNotes.Text == "")
                {
                    MessageBox.Show("Std Pak QTY can not be empty.");
                    return;
                }

                if (dateTimePicker2.Value == null)
                {
                    MessageBox.Show("Invalid Quote Date.");
                    return;
                }
                try
                {
                    row.Cells["PreviousPrice"].Value = row.Cells["CurrentPrice"].Value;
                    row.Cells["CurrentPrice"].Value = currentPrice;

                    Db.NonQuery("UPDATE tblPricing SET [Old Price] = [Current Price], [Current Price] = '{0}', IsNew = 1, Notes = '{1}', QuoteDate='{3}'  WHERE ID = {2}", currentPrice, txtNotes.Text, row.Cells["ID"].Value.ToString(), dateTimePicker2.Value.ToShortDateString());

                    var lead = Db.ExecuteDataRow("SELECT * FROM tblDistributionGroupDetail WHERE [Group_Customer_Name] = '{0}' AND Modifier = 'Lead'", cmbCustomers.SelectedValue);
                    if (lead != null)
                    {
                        var customers = Db.ExecuteDataTable("SELECT * FROM tblDistributionGroupDetail WHERE [Group number] = '{0}' AND Modifier <> 'Lead'", lead["Group number"]);
                        foreach (DataRow custRow in customers.Rows)
                        {
                            var price = Db.ExecuteDataRow("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}' AND [Item Number] = '{1}'", custRow["Group_Customer_Name"], row.Cells["ItemNumber"].Value.ToString());

                            decimal dec = Convert.ToDecimal(custRow["Percent"]) / 100;

                            Db.NonQuery("UPDATE tblPricing SET [Old Price] = [Current Price], [Current Price] = '{0}', IsNew = 1, QuoteDate='{2}' WHERE ID = {1}", custRow["Modifier"].ToString().Equals("Increase") ? (currentPrice + (currentPrice * dec)) : (currentPrice - (currentPrice * dec)), price["ID"], dateTimePicker2.Value.ToShortDateString());
                        }
                    }

                }
                catch (Exception ex)
                {
                    Log.Exception(ex);
                }
            }

            txtNotes.Text = "";
            FillGridByCustomer();
        }
        //================================================================================
        private void txtDelete_Click(object sender, EventArgs e)
        {
            var numbersStr = string.Empty;
            var idsStr = "IN (";

            foreach (DataGridViewRow row in gridPrices.SelectedRows)
            {
                numbersStr += row.Cells["ItemNumber"].Value + ", ";
                idsStr += row.Cells["ID"].Value + ", ";
            }
            if (numbersStr.Length > 0)
                numbersStr = numbersStr.Substring(0, numbersStr.Length - 2);
            if (idsStr.Length > 0)
                idsStr = idsStr.Substring(0, idsStr.Length - 2);
            idsStr += ")";

            var result = MessageBox.Show("You are going to delete selected items: " + numbersStr + "\n Please, confirm this process.", "Important", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    Db.NonQuery("DELETE * FROM tblPricing WHERE ID {0}", idsStr);

                    foreach (DataGridViewRow row in gridPrices.SelectedRows)
                    {
                        gridPrices.Rows.RemoveAt(row.Index);
                    }

                    MessageBox.Show("Item Deleted.", "Good News");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("Item NOT Deleted", "Error");
                }
            }
        }
        //========================================================================================================
        private void btnMarkAsOld_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedValue.ToString().Equals("-1"))
            {
                MessageBox.Show("Please select customer");
                return;
            }

            var check = MessageBox.Show("Please, confirm to 'MARK All PRICES AS OLD' for selected customer.", "Conformation", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new OleDbConnection(Db._connectionString))
                    {
                        connection.Open();
                        OleDbCommand command = connection.CreateCommand();
                        foreach (DataGridViewRow row in gridPrices.Rows)
                        {
                            command.CommandText = string.Format("UPDATE tblPricing SET [Old Price] = 0, IsNew = 0 WHERE ID = {0}", row.Cells["ID"].Value);
                            command.ExecuteNonQuery();
                            row.Cells["PreviousPrice"].Value = "0,000";
                        }
                    }
                    MessageBox.Show("Item  price(s) for selected customer was MARKED AS OLD.");
                }
                catch (Exception ex)
                {
                    Log.Exception(ex);
                }
            }
        }
        //====================================================
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedValue.ToString().Equals("-1"))
            {
                MessageBox.Show("Please select customer");
                return;
            }
            this.Visible = false;
            frmCopyPrices nextScreen = new frmCopyPrices(cmbCustomers.SelectedValue.ToString(), cmbCustomers.Text);
            DialogResult result = nextScreen.ShowDialog();
            if (result == DialogResult.OK)
                FillGridByCustomer();
            this.Visible = true;
        }
        //===========================================================
        private void btnCheckDuplicate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be done on the next stage.");
        }

        //=============================================================        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ReportTypeDialog frmReportTypeSelection = new ReportTypeDialog();
            frmReportTypeSelection.StartPosition = FormStartPosition.CenterParent;
            frmReportTypeSelection.ShowDialog();
            ReportType reportType = ReportType.BOTH;
            switch (frmReportTypeSelection.DialogResult)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    reportType = ReportType.ACTIVE;
                    break;
                case System.Windows.Forms.DialogResult.No:
                    reportType = ReportType.INACTIVE;
                    break;

            }
            var custPricings = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}' ORDER BY [Item Number] ASC", cmbCustomers.SelectedValue);
            Db.NonQuery("DELETE FROM tblByCustomer_Report");
            string SwingNumber = "";
            for (int i = 0; i < custPricings.Rows.Count; i++)
            {
                decimal ASRCurrPriceDec = 0;
                decimal ASTCurrPriceDec = 0;

                //          var ASRCurrPrice = Db.ExecuteDataRow("SELECT TOP 1 [Current Price] FROM tblPricing WHERE [Customer Number] = 'ASR' AND [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);
                //          var ASTCurrPrice = Db.ExecuteDataRow("SELECT TOP 1 [Current Price] FROM tblPricing WHERE [Customer Number] = 'AST' AND [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);

                //          if (ASRCurrPrice != null)
                //              ASRCurrPriceDec = (decimal)ASRCurrPrice[0];
                //          if (ASTCurrPrice != null)
                //              ASTCurrPriceDec = (decimal)ASTCurrPrice[0];

                var cust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", custPricings.Rows[i]["Customer Number"]);
                decimal curPrice = 0;
                Decimal.TryParse(custPricings.Rows[i]["Current Price"].ReplaceNulls(), out curPrice);
                DateTime QuoteDate = new DateTime(2000, 1, 1);
                DateTime.TryParse(custPricings.Rows[i]["QuoteDate"].ReplaceNulls(), out QuoteDate);
                Db.NonQuery("INSERT INTO tblByCustomer_Report ([Customer Number], [Customer Name], [Item Number], [Item Description], [Current Price], [Customer Item Number], [IsNew], [ASR Current Price], [AST Current Price], [Notes],[Last12MonthQTY],[QuoteDate]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}','{10}','{11}')",
                    custPricings.Rows[i]["Customer Number"],
                    cust["Customer Bill Name"].ToString().Replace("'", "''"),
                    custPricings.Rows[i]["Item Number"],
                    custPricings.Rows[i]["Item Description"].ToString().Replace("'", "''"),
                    curPrice,
                    custPricings.Rows[i]["Customer Item Number"],
                    custPricings.Rows[i]["IsNew"],
                    ASRCurrPriceDec,
                    ASTCurrPriceDec,
                    custPricings.Rows[i]["Notes"],
                    custPricings.Rows[i]["Last12MonthQTY"],
                    QuoteDate
                    );
                SwingNumber = cust["Swing Number"].ReplaceNulls();
            }

            Cursor.Current = Cursors.Default;
            string ManagerDisplay = "";
            if (SwingNumber.Length > 0)
            {
                DataTable dt = Db.ExecuteDataTable("SELECT * From tblSwingNumbers WHERE [Swing Number] ='{0}'", SwingNumber);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataTable Mgr = Db.ExecuteDataTable("Select * From tblManagerInformation where ManagerID in ({0},{1},{2},{3})", dt.Rows[0]["Manager1"].ReplaceNulls("-1"), dt.Rows[0]["Manager2"].ReplaceNulls("-1"), dt.Rows[0]["Manager3"].ReplaceNulls("-1"), dt.Rows[0]["Manager4"].ReplaceNulls("-1"));
                    if (Mgr != null && Mgr.Rows.Count > 0)
                    {
                        DataTable dtManagerDisplay = new DataTable();
                        dtManagerDisplay.Columns.Add("RowID", System.Type.GetType("System.Int16"));
                        dtManagerDisplay.Columns.Add("CompanyName");
                        dtManagerDisplay.Columns.Add("ManagerName");
                        dtManagerDisplay.Columns.Add("ManagerPhone");
                        dtManagerDisplay.Columns.Add("ManagerFax");
                        dtManagerDisplay.Columns.Add("ManagerCell");
                        dtManagerDisplay.Columns.Add("ManagerEmail");
                        dtManagerDisplay.Columns.Add("SameAddress");
                        for (int i = 1; i < 5; i++)
                        {
                            Int16 MgrID = -1;

                            if (Int16.TryParse(dt.Rows[0]["Manager" + i].ReplaceNulls(), out MgrID))
                            {
                                DataView dvMgr = new DataView(Mgr);
                                dvMgr.RowFilter = "ManagerID =" + MgrID.ToString();
                                if (dvMgr.Count > 0)
                                {
                                    DataRow dr = dtManagerDisplay.NewRow();
                                    dr["RowID"] = i;
                                    dr["CompanyName"] = (dvMgr[0]["CompanyName"].ReplaceNulls());
                                    dr["ManagerName"] = (dvMgr[0]["ManagerName"].ReplaceNulls());
                                    dr["ManagerPhone"] = (dvMgr[0]["ManagerPhone"].ReplaceNulls());
                                    dr["ManagerEmail"] = (dvMgr[0]["ManagerEmail"].ReplaceNulls());
                                    dr["ManagerFax"] = (dvMgr[0]["ManagerFax"].ReplaceNulls());
                                    dr["ManagerCell"] = (dvMgr[0]["ManagerCell"].ReplaceNulls());
                                    bool SameAddress = false;
                                    Boolean.TryParse(dvMgr[0]["SameAddress"].ReplaceNulls(), out SameAddress);
                                    dr["SameAddress"] = SameAddress;
                                    dtManagerDisplay.Rows.Add(dr);
                                }
                            }

                        }
                        if (dtManagerDisplay != null && dtManagerDisplay.Rows.Count > 0)
                        {
                            ManagerDisplay += dtManagerDisplay.Rows[0]["CompanyName"] + Environment.NewLine +
                                dtManagerDisplay.Rows[0]["ManagerName"] + Environment.NewLine +
                                 "Phone:" + dtManagerDisplay.Rows[0]["ManagerPhone"] + Environment.NewLine +
                                                  "Fax:" + dtManagerDisplay.Rows[0]["ManagerFax"] + Environment.NewLine +
                                                   "Cell:" + dtManagerDisplay.Rows[0]["ManagerCell"] + Environment.NewLine +
                                                   "Email:" + dtManagerDisplay.Rows[0]["ManagerEmail"] + Environment.NewLine + Environment.NewLine;
                            DataView dv = new DataView(dtManagerDisplay);
                            dv.RowFilter = "RowID <> 1 and SameAddress='True'";
                            string sameAddressCompanyName = "";
                            string sameAddressManagerName = "";
                            string sameAddressPhone = "";
                            string sameAddressCell = "";
                            string sameAddressFax = "";
                            string sameAddressEmail = "";
                            foreach (DataRowView rw in dv)
                            {
                                if (sameAddressCompanyName.Length == 0)
                                {
                                    sameAddressCompanyName = rw["CompanyName"].ReplaceNulls();
                                }
                                if (!sameAddressCompanyName.Equals(rw["CompanyName"].ReplaceNulls()))
                                {
                                    MessageBox.Show("Company Name does not match.");
                                    this.Close();
                                    return;
                                }
                                if (rw["ManagerName"].ReplaceNulls().Length == 0) sameAddressManagerName = rw["ManagerName"].ReplaceNulls();
                                else if (!sameAddressManagerName.Contains(rw["ManagerName"].ReplaceNulls())) sameAddressManagerName += ", " + rw["ManagerName"].ReplaceNulls();

                                if (rw["ManagerPhone"].ReplaceNulls().Length == 0) sameAddressPhone = rw["ManagerPhone"].ReplaceNulls();
                                else if (!sameAddressPhone.Contains(rw["ManagerPhone"].ReplaceNulls())) sameAddressPhone += ", " + rw["ManagerPhone"].ReplaceNulls();

                                if (rw["ManagerFax"].ReplaceNulls().Length == 0) sameAddressFax = rw["ManagerFax"].ReplaceNulls();
                                else if (!sameAddressFax.Contains(rw["ManagerFax"].ReplaceNulls())) sameAddressFax += ", " + rw["ManagerFax"].ReplaceNulls();


                                sameAddressCell += rw["ManagerName"] + " Cell:" + rw["ManagerCell"] + Environment.NewLine;
                                sameAddressEmail += rw["ManagerName"] + " Email:" + rw["ManagerEmail"] + Environment.NewLine;

                            }
                            ManagerDisplay += sameAddressCompanyName + Environment.NewLine +
                                               sameAddressManagerName + Environment.NewLine +
                                               "Phone: " + sameAddressPhone + Environment.NewLine +
                                               "Fax: " + sameAddressFax + Environment.NewLine +
                                               sameAddressCell + sameAddressEmail + Environment.NewLine + Environment.NewLine;
                            DataView dv1 = new DataView(dtManagerDisplay);
                            dv1.RowFilter = "RowID <> 1 and SameAddress='False'";
                            foreach (DataRowView rw in dv1)
                            {
                                ManagerDisplay += rw["CompanyName"] + Environment.NewLine +
                                                   rw["ManagerName"] + Environment.NewLine +
                                                  "Phone:" + rw["ManagerPhone"] + Environment.NewLine +
                                                  "Fax:" + rw["ManagerFax"] + Environment.NewLine +
                                                   "Cell:" + rw["ManagerCell"] + Environment.NewLine +
                                                   "Email:" + rw["ManagerEmail"] + Environment.NewLine + Environment.NewLine;

                            }
                        }
                        /*
                        var groupedUsers = from row in dtManagerDisplay.AsEnumerable()
                                           orderby row.Field<Int16>("RowID")
                                           group row
                                           by new
                                           {
                                               ManagerPhone = row.Field<string>("ManagerPhone"),
                                               ManagerFax = row.Field<string>("ManagerFax"),
                                           } into grp

                                           select new
                                           {
                                               ManagerName = String.Join(", ", grp.Select(m => m.Field<string>("ManagerName")).ToArray()),
                                               ManagerPhone = grp.Key.ManagerPhone,
                                               ManagerFax = grp.Key.ManagerFax,
                                               ManagerCell = String.Join(Environment.NewLine + "Cell:", grp.Select(m => m.Field<string>("ManagerCell")).Where(y => !string.IsNullOrEmpty(y)).ToArray()),
                                               ManagerEmail = String.Join(Environment.NewLine + "Email:", grp.Select(m => m.Field<string>("ManagerEmail")).Where(y => !string.IsNullOrEmpty(y)).ToArray()),

                                           };


                        foreach (var obj in groupedUsers)
                        {
                            ManagerDisplay += obj.ManagerName + Environment.NewLine +
                                            "Phone:" + obj.ManagerPhone + Environment.NewLine +
                                            "Fax:" + obj.ManagerFax + Environment.NewLine +
                                             "Cell:" + obj.ManagerCell + Environment.NewLine +
                                             "Email:" + obj.ManagerEmail + Environment.NewLine + Environment.NewLine;

                        }
                        */

                    }
                }

            }
            var result = MessageBox.Show("\"Click on YES to print only NEW / CHANGED prices, or click NO to print all\"", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmReport2_all_Viewer frm = new frmReport2_all_Viewer();
                frm.DisplayManagerInfo = ManagerDisplay;
                frm.reportType = reportType;
                frm.Show();
                Cursor.Current = Cursors.Default;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                frmReport2_new_Viewer frm = new frmReport2_new_Viewer();
                frm.DisplayManagerInfo = ManagerDisplay;
                frm.reportType = reportType;
                frm.Show();
                Cursor.Current = Cursors.Default;

            }
        }
        //==============================================================================================

        private void btnChangePrices_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            ReportTypeDialog frmReportTypeSelection = new ReportTypeDialog();
            frmReportTypeSelection.StartPosition = FormStartPosition.CenterParent;
            frmReportTypeSelection.ShowDialog();
            ReportType reportType = ReportType.BOTH;
            switch (frmReportTypeSelection.DialogResult)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    reportType = ReportType.ACTIVE;
                    break;
                case System.Windows.Forms.DialogResult.No:
                    reportType = ReportType.INACTIVE;
                    break;

            }
            var custPricings = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}' ORDER BY [Item Number] ASC", cmbCustomers.SelectedValue);
            Db.NonQuery("DELETE FROM tblByCustomer_Report");
            Db.NonQuery("Delete from tblAST");
            Db.NonQuery("Delete from tblASR");

            Db.NonQuery("insert into tblAst ([Item Number], [Current price]) select tblPricing.[Item Number],  tblPricing.[Current Price] from tblPricing where tblPricing.[Customer number] = 'AST' ");
            Db.NonQuery("insert into tblAsr ([Item Number], [Current price]) select tblPricing.[Item Number],  tblPricing.[Current Price] from tblPricing where tblPricing.[Customer number] = 'ASR' ");

            string SwingNumber = "";
            for (int i = 0; i < custPricings.Rows.Count; i++)
            {
                decimal ASRCurrPriceDec = 0;
                decimal ASTCurrPriceDec = 0;

                //     var ASRCurrPrice = Db.ExecuteDataRow("SELECT TOP 1 [Current Price] FROM tblPricing WHERE [Customer Number] = 'ASR' AND [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);
                //     var ASTCurrPrice = Db.ExecuteDataRow("SELECT TOP 1 [Current Price] FROM tblPricing WHERE [Customer Number] = 'AST' AND [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);

                var ASRCurrPrice = Db.ExecuteDataRow("SELECT [Current Price] FROM tblASR WHERE [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);
                var ASTCurrPrice = Db.ExecuteDataRow("SELECT [Current Price] FROM tblAST WHERE [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);

                if (ASRCurrPrice != null)
                    ASRCurrPriceDec = (decimal)ASRCurrPrice[0];
                if (ASTCurrPrice != null)
                    ASTCurrPriceDec = (decimal)ASTCurrPrice[0];

                var cust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", custPricings.Rows[i]["Customer Number"]);
                string Last12MonthQty = System.DBNull.Value.Equals(custPricings.Rows[i]["Last12MonthQTY"]) ? "0" : custPricings.Rows[i]["Last12MonthQTY"].ToString();
                decimal curPrice = 0;
                Decimal.TryParse(custPricings.Rows[i]["Current Price"].ReplaceNulls(), out curPrice);
                DateTime QuoteDate = new DateTime(2000, 1, 1);
                DateTime.TryParse(custPricings.Rows[i]["QuoteDate"].ReplaceNulls(), out QuoteDate);

                Db.NonQuery("INSERT INTO tblByCustomer_Report ([Customer Number], [Customer Name], [Item Number], [Item Description], [Current Price], [Customer Item Number], [IsNew], [ASR Current Price], [AST Current Price], [Notes], [QuoteDate], [Last12MonthQTY]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}','{10}','{11}')",
                    custPricings.Rows[i]["Customer Number"],
                    cust["Customer Bill Name"].ToString().Replace("'", "''"),
                    custPricings.Rows[i]["Item Number"],
                    custPricings.Rows[i]["Item Description"].ToString().Replace("'", "''"),
                    curPrice,
                    custPricings.Rows[i]["Customer Item Number"],
                    custPricings.Rows[i]["IsNew"],
                    ASRCurrPriceDec,
                    ASTCurrPriceDec,
                    custPricings.Rows[i]["Notes"],
                    QuoteDate,
                    Last12MonthQty
                    );
                SwingNumber = cust["Swing Number"].ReplaceNulls();
            }
            Cursor.Current = Cursors.Default;
            string ManagerDisplay = "";
            if (SwingNumber.Length > 0)
            {
                DataTable dt = Db.ExecuteDataTable("SELECT * From tblSwingNumbers WHERE [Swing Number] ='{0}'", SwingNumber);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataTable Mgr = Db.ExecuteDataTable("Select * From tblManagerInformation where ManagerID in ({0},{1},{2},{3})", dt.Rows[0]["Manager1"].ReplaceNulls("-1"), dt.Rows[0]["Manager2"].ReplaceNulls("-1"), dt.Rows[0]["Manager3"].ReplaceNulls("-1"), dt.Rows[0]["Manager4"].ReplaceNulls("-1"));
                    if (Mgr != null && Mgr.Rows.Count > 0)
                    {
                        DataTable dtManagerDisplay = new DataTable();
                        dtManagerDisplay.Columns.Add("RowID", System.Type.GetType("System.Int16"));
                        dtManagerDisplay.Columns.Add("CompanyName");
                        dtManagerDisplay.Columns.Add("ManagerName");
                        dtManagerDisplay.Columns.Add("ManagerPhone");
                        dtManagerDisplay.Columns.Add("ManagerFax");
                        dtManagerDisplay.Columns.Add("ManagerCell");
                        dtManagerDisplay.Columns.Add("ManagerEmail");
                        dtManagerDisplay.Columns.Add("SameAddress");
                        for (int i = 1; i < 5; i++)
                        {
                            Int16 MgrID = -1;

                            if (Int16.TryParse(dt.Rows[0]["Manager" + i].ReplaceNulls(), out MgrID))
                            {
                                DataView dvMgr = new DataView(Mgr);
                                dvMgr.RowFilter = "ManagerID =" + MgrID.ToString();
                                if (dvMgr.Count > 0)
                                {
                                    DataRow dr = dtManagerDisplay.NewRow();
                                    dr["RowID"] = i;
                                    dr["CompanyName"] = (dvMgr[0]["CompanyName"].ReplaceNulls());
                                    dr["ManagerName"] = (dvMgr[0]["ManagerName"].ReplaceNulls());
                                    dr["ManagerPhone"] = (dvMgr[0]["ManagerPhone"].ReplaceNulls());
                                    dr["ManagerEmail"] = (dvMgr[0]["ManagerEmail"].ReplaceNulls());
                                    dr["ManagerFax"] = (dvMgr[0]["ManagerFax"].ReplaceNulls());
                                    dr["ManagerCell"] = (dvMgr[0]["ManagerCell"].ReplaceNulls());
                                    bool SameAddress = false;
                                    Boolean.TryParse(dvMgr[0]["SameAddress"].ReplaceNulls(), out SameAddress);
                                    dr["SameAddress"] = SameAddress;
                                    dtManagerDisplay.Rows.Add(dr);
                                }
                            }

                        }

                        if (dtManagerDisplay != null && dtManagerDisplay.Rows.Count > 0)
                        {
                            ManagerDisplay += dtManagerDisplay.Rows[0]["CompanyName"] + Environment.NewLine +
                                dtManagerDisplay.Rows[0]["ManagerName"] + Environment.NewLine +
                                 "Phone:" + dtManagerDisplay.Rows[0]["ManagerPhone"] + Environment.NewLine +
                                                  "Fax:" + dtManagerDisplay.Rows[0]["ManagerFax"] + Environment.NewLine +
                                                   "Cell:" + dtManagerDisplay.Rows[0]["ManagerCell"] + Environment.NewLine +
                                                   "Email:" + dtManagerDisplay.Rows[0]["ManagerEmail"] + Environment.NewLine + Environment.NewLine;
                            DataView dv = new DataView(dtManagerDisplay);
                            dv.RowFilter = "RowID <> 1 and SameAddress='True'";
                            string sameAddressCompanyName = "";
                            string sameAddressManagerName = "";
                            string sameAddressPhone = "";
                            string sameAddressCell = "";
                            string sameAddressFax = "";
                            string sameAddressEmail = "";
                            foreach (DataRowView rw in dv)
                            {
                                if (sameAddressCompanyName.Length == 0)
                                {
                                    sameAddressCompanyName = rw["CompanyName"].ReplaceNulls();
                                }
                                if (!sameAddressCompanyName.Equals(rw["CompanyName"].ReplaceNulls()))
                                {
                                    MessageBox.Show("Company Name does not match.");
                                    this.Close();
                                    return;
                                }
                                if (rw["ManagerName"].ReplaceNulls().Length == 0) sameAddressManagerName = rw["ManagerName"].ReplaceNulls();
                                else if (!sameAddressManagerName.Contains(rw["ManagerName"].ReplaceNulls())) sameAddressManagerName += ", " + rw["ManagerName"].ReplaceNulls();

                                if (rw["ManagerPhone"].ReplaceNulls().Length == 0) sameAddressPhone = rw["ManagerPhone"].ReplaceNulls();
                                else if (!sameAddressPhone.Contains(rw["ManagerPhone"].ReplaceNulls())) sameAddressPhone += ", " + rw["ManagerPhone"].ReplaceNulls();

                                if (rw["ManagerFax"].ReplaceNulls().Length == 0) sameAddressFax = rw["ManagerFax"].ReplaceNulls();
                                else if (!sameAddressFax.Contains(rw["ManagerFax"].ReplaceNulls())) sameAddressFax += ", " + rw["ManagerFax"].ReplaceNulls();


                                sameAddressCell += rw["ManagerName"] + " Cell:" + rw["ManagerCell"] + Environment.NewLine;
                                sameAddressEmail += rw["ManagerName"] + " Email:" + rw["ManagerEmail"] + Environment.NewLine;

                            }
                            ManagerDisplay += sameAddressCompanyName + Environment.NewLine +
                                               sameAddressManagerName + Environment.NewLine +
                                               "Phone: " + sameAddressPhone + Environment.NewLine +
                                               "Fax: " + sameAddressFax + Environment.NewLine +
                                               sameAddressCell + sameAddressEmail + Environment.NewLine + Environment.NewLine;
                            DataView dv1 = new DataView(dtManagerDisplay);
                            dv1.RowFilter = "RowID <> 1 and SameAddress='False'";
                            foreach (DataRowView rw in dv1)
                            {
                                ManagerDisplay += rw["CompanyName"] + Environment.NewLine +
                                                   rw["ManagerName"] + Environment.NewLine +
                                                  "Phone:" + rw["ManagerPhone"] + Environment.NewLine +
                                                  "Fax:" + rw["ManagerFax"] + Environment.NewLine +
                                                   "Cell:" + rw["ManagerCell"] + Environment.NewLine +
                                                   "Email:" + rw["ManagerEmail"] + Environment.NewLine + Environment.NewLine;

                            }
                        }
                        /*
                        var groupedUsers = from row in dtManagerDisplay.AsEnumerable()
                                           orderby row.Field<Int16>("RowID")
                                           group row
                                           by new
                                           {
                                               ManagerPhone = row.Field<string>("ManagerPhone"),
                                               ManagerFax = row.Field<string>("ManagerFax"),
                                           } into grp

                                           select new
                                           {
                                               ManagerName = String.Join(", ", grp.Select(m => m.Field<string>("ManagerName")).ToArray()),
                                               ManagerPhone = grp.Key.ManagerPhone,
                                               ManagerFax = grp.Key.ManagerFax,
                                               ManagerCell = String.Join(Environment.NewLine + "Cell:", grp.Select(m => m.Field<string>("ManagerCell")).Where(y => !string.IsNullOrEmpty(y)).ToArray()),
                                               ManagerEmail = String.Join(Environment.NewLine + "Email:", grp.Select(m => m.Field<string>("ManagerEmail")).Where(y => !string.IsNullOrEmpty(y)).ToArray()),

                                           };


                        foreach (var obj in groupedUsers)
                        {
                            ManagerDisplay += obj.ManagerName + Environment.NewLine +
                                            "Phone:" + obj.ManagerPhone + Environment.NewLine +
                                            "Fax:" + obj.ManagerFax + Environment.NewLine +
                                             "Cell:" + obj.ManagerCell + Environment.NewLine +
                                             "Email:" + obj.ManagerEmail + Environment.NewLine + Environment.NewLine;

                        }
                        */

                    }
                }

            }
            var result = MessageBox.Show("\"Click on YES to print only NEW / CHANGED prices, or click NO to print all\"", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmReport1_all_Viewer frm = new frmReport1_all_Viewer();
                frm.DisplayManagerInfo = ManagerDisplay;
                frm.reportType = reportType;
                frm.Show();
                Cursor.Current = Cursors.Default;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                frmReport1_new_Viewer frm = new frmReport1_new_Viewer();
                frm.DisplayManagerInfo = ManagerDisplay;
                frm.reportType = reportType;
                frm.Show();
                Cursor.Current = Cursors.Default;

            }
        }
        //================================================================================================
        private void btnRollBack_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Please confirm to Roll Back All prices for selected customer", "Conformation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                var rollback = Db.ExecuteDataRow("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}' AND IsNew = Yes ", cmbCustomers.SelectedValue);

                if (rollback != null)
                {
                    var rollbackTable = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}' AND IsNew = Yes ", cmbCustomers.SelectedValue);

                    foreach (DataRow itemRow in rollbackTable.Rows)
                    {
                        var eachRow = Db.ExecuteDataRow("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}' AND IsNew = Yes ", cmbCustomers.SelectedValue);

                        Db.NonQuery("UPDATE tblPricing SET [Current Price] = [Old Price], [Old Price] = 0, IsNew = No WHERE ID = {0}", eachRow["ID"]);

                    }
                }
                FillGridByCustomer();
            }
        }
        //================================================================================================
        private void btnEmail_Click(object sender, EventArgs e)
        {

            var custInformation = Db.ExecuteDataRow("Select [Email Address] From tblCustomers Where [Customer Number] = '{0}'", cmbCustomers.SelectedValue.ToString());

            TextBox tB = new TextBox();
            tB.Text = custInformation["Email Address"].ToString();

            if (tB.Text != "")
            {
                if (Validation.IsValidEmail(tB))
                {
                    frmEmail1 nextScreen = new frmEmail1(tB.Text);
                    DialogResult result = nextScreen.ShowDialog();
                }
            }
            else
            {
                var answer = MessageBox.Show("Customer does not have Email address. \n Would you like to process anyway?", "Importent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    //       frmEmail1 nextScreen = new frmEmail1(tB.Text);
                    frmEmail1 nextScreen = new frmEmail1("empty");
                    DialogResult result = nextScreen.ShowDialog();
                }
            }
        }
        //============================================================================================

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            cmbCustomers.Enabled = true;
            gridPrices.Enabled = true;

            grpPriceChange.Visible = true;
            grpPriceInfo.Visible = false;

            cmbQuick_Check.Enabled = true;
            btnMarkAsOld.Enabled = true;
            btnCopy.Enabled = true;
            btnCheckDuplicate.Enabled = true;
            btnRollBack.Enabled = true;
            btnEmail.Enabled = true;
            btnChange_Price.Enabled = true;
            btnDeletePrice.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAddPrice.Enabled = true;
            btnUpdSPQ.Enabled = true;

            cmbItemNumb.Enabled = false;
            txtCurrent_Price.Enabled = false;
            txtCurrent_Price.Text = "0.0000";
            txtItem_description.Enabled = false;
            txtCustomer_Item_Number.Enabled = false;
        }
        //==============================================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            var existsItem = Db.ExecuteDataTable("SELECT * FROM tblItems WHERE [Item Number] = '{0}'", cmbItemNumb.Text);
            if (existsItem.Rows.Count == 0)
            {
                MessageBox.Show("Item not exists in item master table. Before pricing new item ADD it to master table.", "Warning");
                return;
            }

            var exists = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}' and [Item Number] = '{1}'", cmbCustomers.SelectedValue, cmbItemNumb.Text);
            if (exists.Rows.Count > 0)
            {
                MessageBox.Show("Item already exists in customer list");
                return;
            }

            int existsForAAMNFL = (int)Db.ExecuteScalar("SELECT count([Item Number]) FROM tblPricing WHERE [Customer Number] = 'AA-MN-FL' and [Item Number] = '{1}'", cmbCustomers.SelectedValue, cmbItemNumb.Text);
            if (existsForAAMNFL == 0)
            {
                MessageBox.Show("!! STOP !! " + Environment.NewLine + "Item does not exists for AA-MN-FL Customer.");
                return;
            }

            if (cmbItemNumb.Text == "")
            {
                MessageBox.Show("You must select the Item to quote this Customer a Price for. \n Please select an Item");
                return;
            }

            //		if (txtItem_description.Text == "")
            //		{
            //			MessageBox.Show("You must enter Item Description");
            //			return;
            //		}

            if (txtCurrent_Price.Text.Length == 0)
            {
                MessageBox.Show("You must enter Current Price");
                return;
            }

            var strPrice = txtCurrent_Price.Text;
            if (strPrice.Contains("."))
            {
                if (strPrice.Substring(strPrice.IndexOf(".")).Length > 5)
                {
                    MessageBox.Show("Digits after '.' could not be more than 4");
                    return;
                }
            }

            if (strPrice.Contains(","))
            {
                if (strPrice.Substring(strPrice.IndexOf(",")).Length > 5)
                {
                    MessageBox.Show("Digits after ',' could not be more than 4");
                    return;
                }
            }

            decimal currentPrice;
            if (!Decimal.TryParse(txtCurrent_Price.Text, out currentPrice))
            {
                MessageBox.Show("Please enter currect price.");
                return;
            }


            {
                //  Db.NonQuery("INSERT INTO tblPricing ([Customer Number], [Item Number], [Item Description], [Current Price], [Customer Item Number], [IsNew]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )",
                Db.NonQuery("INSERT INTO tblPricing ([Customer Number], [Item Number], [Current Price], [Customer Item Number], [IsNew], [Notes], QuoteDate) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}',Now() )",

                 cmbCustomers.SelectedValue.ToString(),
                 cmbItemNumb.SelectedValue.ToString(),
                    //    txtItem_description.Text,
                    //    txtCurrent_Price.Text.Replace('.', ','),
                 txtCurrent_Price.Text,
                 txtCustomer_Item_Number.Text,
                 1,
                 txtStdQTY_Add.Text
                 );

                var lead = Db.ExecuteDataRow("SELECT * FROM tblDistributionGroupDetail WHERE [Group_Customer_Name] = '{0}' AND Modifier = 'Lead'", cmbCustomers.SelectedValue);
                if (lead != null)
                {
                    var customers = Db.ExecuteDataTable("SELECT * FROM tblDistributionGroupDetail WHERE [Group number] = '{0}' AND Modifier <> 'Lead'", lead["Group number"]);
                    foreach (DataRow custRow in customers.Rows)
                    {
                        decimal dec = Convert.ToDecimal(custRow["Percent"]) / 100;

                        Db.NonQuery("INSERT INTO tblPricing ([Customer Number], [Item Number], [Item Description], [Current Price],QuoteDate) VALUES ('{0}', '{1}', '{2}', '{3}',Now())",
                            custRow["Group_Customer_Name"],
                            cmbItemNumb.SelectedValue.ToString(),
                            txtItem_description.Text,
                            custRow["Modifier"].ToString().Equals("Increase") ? (currentPrice + (currentPrice * dec)) : (currentPrice - (currentPrice * dec)));
                    }
                }

                cmbCustomers.Enabled = true;
                gridPrices.Enabled = true;

                grpPriceChange.Visible = true;
                grpPriceInfo.Visible = false;

                cmbQuick_Check.Enabled = true;
                btnMarkAsOld.Enabled = true;
                btnCopy.Enabled = true;
                btnCheckDuplicate.Enabled = true;
                btnRollBack.Enabled = true;
                btnEmail.Enabled = true;
                btnChange_Price.Enabled = true;
                btnDeletePrice.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnAddPrice.Enabled = true;
                btnUpdSPQ.Enabled = true;

                cmbItemNumb.Enabled = false;
                cmbItemNumb.Text = "";
                txtCurrent_Price.Enabled = false;
                txtCurrent_Price.Text = string.Format("#.0000");
                txtItem_description.Enabled = false;
                txtItem_description.Text = "";
                txtCustomer_Item_Number.Enabled = false;
                txtCustomer_Item_Number.Text = "";
                txtStdQTY_Add.Text = "";

                FillGridByCustomer();
            }
        }
        //==============================================================================================================
        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridByCustomer();
        }

        private void gridPrices_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var rows = gridPrices.SelectedRows;

            if (rows.Count != 1)
            {
                grpPriceChange.Enabled = false;
            }
            else if (rows.Count == 1)
            {
                grpPriceChange.Enabled = true;
                var row = rows[0];
                textBox1.Text = row.Cells["ItemNumber"].Value.ToString();
                textBox2.Text = row.Cells["CurrentPrice"].Value.ToString();
                textBox3.Text = row.Cells["ItemDescription"].Value.ToString();
                textBox4.Text = row.Cells["CustomerItemNumber"].Value.ToString();
                txtNotes.Text = row.Cells["Notes"].Value.ToString();
                DateTime dtQuote;
                if (DateTime.TryParse(row.Cells["QuoteDate"].Value.ToString(), out dtQuote))
                    dateTimePicker2.Value = dtQuote;
            }
        }

        private void cmbQuick_Check_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                foreach (DataGridViewRow row in gridPrices.Rows)
                    if (row.Cells["ItemNumber"].Value.ToString().Equals(cmbQuick_Check.Text))
                    {
                        row.Selected = true;
                        gridPrices.FirstDisplayedScrollingRowIndex = row.Index;
                    }
        }

        private void txtItem_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cmbQuick_Check_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cmbItemNumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtCustomer_Item_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //=====================================================================================================
        private void cmbQuick_Check_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridPrices.Rows)
                if (row.Cells["ItemNumber"].Value.ToString().Equals(cmbQuick_Check.Text))
                {
                    row.Selected = true;
                    gridPrices.FirstDisplayedScrollingRowIndex = row.Index;
                }
        }
        //====================================================================================================
        private void cmbItemNumb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = Db.ExecuteDataRow("SELECT * FROM tblItems WHERE [Item Number] = '{0}'", cmbItemNumb.SelectedValue);
            if (item != null)
                txtItem_description.Text = item["Item Description"].ToString();
        }

        private void lstBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------
        //--------------- Change Notes column (Standard Pack QTY)
        //----------------------------------------------------------------


        private void btnUpdSPQ_Click(object sender, EventArgs e)
        {

            var change = MessageBox.Show("Are you sure you like to change Std Pak Qty?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            double num;
            bool isNumber = double.TryParse(txtNotes.Text, out num);
            if (isNumber)
            {
            }
            else
            {
                MessageBox.Show("Std Pac QTY - should be number");
                return;
            }



            if (change == DialogResult.Yes)
            {
                var rows = gridPrices.SelectedRows;

                if (rows.Count != 1)
                {
                    MessageBox.Show("You must select one item.");
                    return;
                }

                var row = rows[0];

                if (txtNotes.Text == "")
                {
                    MessageBox.Show("Std Pak QTY can not be empty.");
                    return;
                }

                Db.NonQuery("UPDATE tblPricing SET Notes = '{0}'  WHERE ID = {1}", txtNotes.Text, row.Cells["ID"].Value.ToString());

                txtNotes.Text = "";
                FillGridByCustomer();

            }
        }

        private void item_DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateLast12MoQtyTo1_Click(object sender, EventArgs e)
        {
            frmUpdateLast12MoQty frm = new frmUpdateLast12MoQty();
            frm.ShowDialog();
        }

       
        //===================================================================================================
    }
}
