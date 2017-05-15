using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;                      //  version to send
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;


namespace Unified_Price_for_Var
{
    public partial class frmReports : Form
    {
        public DataTable _dataTableItems;
        public DataTable _dataTableItemsFrom;
        public DataTable _dataTableItemsTo;
        public DataTable _dataTableCustomer;
        public DataTable _dataTableCustomer1;
        public DataTable _dataTableSwing;
        public DataTable _dataTableCustomerFrom;
        public DataTable _dataTableCustomerTo;
        public DataTable _dataTableFamily;
        public DataTable _dataTableFamily1;
        public DataTable _dataTableCompItems;
        public DataTable _dataTableItemsFrom5;
        public DataTable _dataTableItemsTo5;
        public DataTable _dataTableCustomer5;
        public DataTable _dataTableSalesPerson;

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            _dataTableItemsFrom5 = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");
            cmbFrom5.DataSource = _dataTableItemsFrom5;
            cmbFrom5.DisplayMember = "Item Number";
            cmbFrom5.ValueMember = "Item Number";

            _dataTableItemsTo5 = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");
            cmbTo5.DataSource = _dataTableItemsTo5;
            cmbTo5.DisplayMember = "Item Number";
            cmbTo5.ValueMember = "Item Number";

            _dataTableCustomer = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] + ' (' + [Customer Number] + ')' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Bill Name] + ' (' + [Customer Number] + ')'");
            cmbCust.DataSource = _dataTableCustomer;
            cmbCust.DisplayMember = "Combinet Name";
            cmbCust.ValueMember = "Customer Number";

            _dataTableCustomer5 = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] + ' (' + [Customer Number] + ')' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Number]");
            cmbCust5.DataSource = _dataTableCustomer5;
            cmbCust5.DisplayMember = "Combinet Name";
            cmbCust5.ValueMember = "Customer Number";

            //Since we are not showing this report anymore so not populating the combobox
            // _dataTableSwing = Db.ExecuteDataTable("SELECT [Swing Number], [Swing Name], [Swing Number] + ' - ' + [Swing Name] AS [Header] FROM tblSwingNumbers ORDER BY [Swing Name]");
            /// cmbSwing.DataSource = _dataTableSwing;
            //cmbSwing.DisplayMember = "Header";
            ///cmbSwing.ValueMember = "Swing Number";

            _dataTableCustomerFrom = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] + ' (' + [Customer Number] + ')' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Number]");
            cmbCustFrom.DataSource = _dataTableCustomerFrom;
            cmbCustFrom.DisplayMember = "Combinet Name";
            cmbCustFrom.ValueMember = "Customer Number";

            _dataTableCustomerTo = Db.ExecuteDataTable("SELECT [Customer Number], [Customer Bill Name] + ' (' + [Customer Number] + ')' AS [Combinet Name] FROM tblCustomers ORDER BY [Customer Number]");
            cmbCustTo.DataSource = _dataTableCustomerTo;
            cmbCustTo.DisplayMember = "Combinet Name";
            cmbCustTo.ValueMember = "Customer Number";

            _dataTableCompItems = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");
            cmbCompItem.DataSource = _dataTableCompItems;
            cmbCompItem.DisplayMember = "Item Number";
            cmbCompItem.ValueMember = "Item Number";

            cmbSalesPerson.Visible = false;
            lblSelectSalesPerson.Visible = false;

            this.Visible = true;
        }
        //=========================================================================
        private void rdoPrintByItemNumb_CheckedChanged(object sender, EventArgs e)
        {
            _dataTableItems = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");
            cmbItem.DataSource = _dataTableItems;
            cmbItem.DisplayMember = "Item Number";
            cmbItem.ValueMember = "Item Number";

            cmbItem.Enabled = true;
            cmbFamily.Enabled = false;
            panel4.Visible = false;
            panel1.Visible = false;


            if (rdoPrintByItemNumb.Checked)
                rdoPrintByItemNumb.Font = new Font(rdoPrintByItemNumb.Font.FontFamily, rdoPrintByItemNumb.Font.Size, FontStyle.Bold);
            else
                rdoPrintByItemNumb.Font = new Font(rdoPrintByItemNumb.Font.FontFamily, rdoPrintByItemNumb.Font.Size, FontStyle.Regular);

        }
        //======================================================================

        private void rdoPrintByRange_CheckedChanged(object sender, EventArgs e)
        {
            _dataTableItemsFrom = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");
            cmbFrom.DataSource = _dataTableItemsFrom;
            cmbFrom.DisplayMember = "Item Number";
            cmbFrom.ValueMember = "Item Number";

            _dataTableItemsTo = Db.ExecuteDataTable("SELECT [Item Number] FROM tblItems ORDER BY [Item Number]");
            cmbTo.DataSource = _dataTableItemsTo;
            cmbTo.DisplayMember = "Item Number";
            cmbTo.ValueMember = "Item Number";

            panel4.BringToFront();
            panel4.Visible = true;
            panel1.Visible = false;
            cmbFamily.Enabled = false;
            cmbItem.Enabled = false;


            if (rdoPrintByRange.Checked)
                rdoPrintByRange.Font = new Font(rdoPrintByRange.Font.FontFamily, rdoPrintByRange.Font.Size, FontStyle.Bold);
            else
                rdoPrintByRange.Font = new Font(rdoPrintByRange.Font.FontFamily, rdoPrintByRange.Font.Size, FontStyle.Regular);


        }
        //==========================================================================================================
        private void rdoPrintAll_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            cmbFamily.Enabled = false;
            cmbItem.Enabled = false;

            if (rdoPrintAll.Checked)
                rdoPrintAll.Font = new Font(rdoPrintAll.Font.FontFamily, rdoPrintAll.Font.Size, FontStyle.Bold);
            else
                rdoPrintAll.Font = new Font(rdoPrintAll.Font.FontFamily, rdoPrintAll.Font.Size, FontStyle.Regular);

        }
        //==========================================================================================================
        private void rdoPrintByFamily_CheckedChanged(object sender, EventArgs e)
        {
            _dataTableFamily = Db.ExecuteDataTable("Select distinct [Family] FROM tblItems ORDER BY [Family]");
            cmbFamily.DataSource = _dataTableFamily;
            cmbFamily.DisplayMember = "Family";
            cmbFamily.ValueMember = "Family";

            panel1.Visible = false;
            panel4.Visible = false;
            cmbFamily.Enabled = true;
            cmbItem.Enabled = false;

            if (rdoPrintByFamily.Checked)
                rdoPrintByFamily.Font = new Font(rdoPrintByFamily.Font.FontFamily, rdoPrintByFamily.Font.Size, FontStyle.Bold);
            else
                rdoPrintByFamily.Font = new Font(rdoPrintByFamily.Font.FontFamily, rdoPrintByFamily.Font.Size, FontStyle.Regular);

        }
        //=========================================================================================================
        private void rdoPrintByCustFamily_CheckedChanged(object sender, EventArgs e)
        {
            _dataTableCustomer1 = Db.ExecuteDataTable("SELECT [Customer Number] FROM tblCustomers ORDER BY [Customer Number]");
            cmbCust1.DataSource = _dataTableCustomer1;
            cmbCust1.DisplayMember = "Customer Name";
            cmbCust1.ValueMember = "Customer Number";

            _dataTableFamily1 = Db.ExecuteDataTable("Select distinct [Family] FROM tblItems ORDER BY [Family]");
            cmbFamily1.DataSource = _dataTableFamily1;
            cmbFamily1.DisplayMember = "Family";
            cmbFamily1.ValueMember = "Family";

            panel4.Visible = false;
            panel1.Visible = true;
            cmbFamily.Enabled = false;
            cmbItem.Enabled = false;


            if (rdoPrintByCustFamily.Checked)
                rdoPrintByCustFamily.Font = new Font(rdoPrintByCustFamily.Font.FontFamily, rdoPrintByCustFamily.Font.Size, FontStyle.Bold);
            else
                rdoPrintByCustFamily.Font = new Font(rdoPrintByCustFamily.Font.FontFamily, rdoPrintByCustFamily.Font.Size, FontStyle.Regular);

        }


        //=========================================================================================================
        private void rdoPrintCustBySalesPer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPrintCustBySalesPer.Checked)
            {
                rdoPrintCustBySalesPer.Font = new Font(rdoSwing1.Font.FontFamily, rdoSwing1.Font.Size, FontStyle.Bold);
                _dataTableSalesPerson = Db.ExecuteDataTable("SELECT [Swing Number], [Swing Name], [Swing Number] + ' - ' + [Swing Name] AS [Header] FROM tblSwingNumbers ORDER BY [Swing Name]");
                cmbSalesPerson.DataSource = _dataTableSalesPerson;
                cmbSalesPerson.DisplayMember = "Header";
                cmbSalesPerson.ValueMember = "Swing Number";
                cmbSalesPerson.SelectedIndex = -1;
                cmbSalesPerson.Visible = true;
                lblSelectSalesPerson.Visible = true;
            }
            else
                rdoPrintCustBySalesPer.Font = new Font(rdoSwing1.Font.FontFamily, rdoSwing1.Font.Size, FontStyle.Regular);

        }

        //=========================================================================================================
        private void rdoSwing1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSwing1.Checked)
                rdoSwing1.Font = new Font(rdoSwing1.Font.FontFamily, rdoSwing1.Font.Size, FontStyle.Bold);
            else
                rdoSwing1.Font = new Font(rdoSwing1.Font.FontFamily, rdoSwing1.Font.Size, FontStyle.Regular);

        }
        //=========================================================================================================
        private void rdoSwing2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSwing2.Checked)
                rdoSwing2.Font = new Font(rdoSwing2.Font.FontFamily, rdoSwing2.Font.Size, FontStyle.Bold);
            else
                rdoSwing2.Font = new Font(rdoSwing2.Font.FontFamily, rdoSwing2.Font.Size, FontStyle.Regular);

        }
        //============================================================================================================
        private void btnCompareCust_CheckedChanged(object sender, EventArgs e)
        {
            pnlCompItems.Visible = false;
            if (rdoCompareCust.Checked)
                rdoCompareCust.Font = new Font(rdoCompareCust.Font.FontFamily, rdoCompareCust.Font.Size, FontStyle.Bold);
            else
                rdoCompareCust.Font = new Font(rdoCompareCust.Font.FontFamily, rdoCompareCust.Font.Size, FontStyle.Regular);

        }
        //=========================================================================================================
        private void rdoCompareItems_CheckedChanged(object sender, EventArgs e)
        {
            pnlCompItems.Visible = true;
            if (rdoCompareItems.Checked)
                rdoCompareItems.Font = new Font(rdoCompareItems.Font.FontFamily, rdoCompareItems.Font.Size, FontStyle.Bold);
            else
                rdoCompareItems.Font = new Font(rdoCompareItems.Font.FontFamily, rdoCompareItems.Font.Size, FontStyle.Regular);

        }

        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        private void btnViewReport1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Db.NonQuery("DELETE FROM tblByItem_Report");

            if (rdoPrintByItemNumb.Checked)
            {
                Db.NonQuery(String.Format("INSERT INTO tblByItem_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price], [InDistrGroup],[QuoteDate],[Last12MonthQTY]) SELECT [Item Number], [Item Description], a.[Customer Number], b.[Customer Bill Name],[Current price],'', [QuoteDate], iif(isnull([Last12MonthQTY]),0, a.[Last12MonthQTY])  as [Last12MonthQTYs] FROM tblPricing a inner join tblCustomers b on a.[Customer Number] = b.[Customer Number] WHERE [Item Number] = '{0}' ORDER BY [Current Price] DESC, [Item Number]", cmbItem.SelectedValue));

                //var items = Db.ExecuteDataTable("SELECT [Item Number], [Item Description], [Customer Number], [Current Price], [QuoteDate], IIF(ISNULL([Last12MonthQTY]), 0, [Last12MonthQTY]) as[Last12MonthQTY] FROM tblPricing WHERE [Item Number] = '{0}' ORDER BY [Current Price] DESC", cmbItem.SelectedValue);

                //foreach (DataRow row in items.Rows)
                //{

                //    var cust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", row["Customer Number"]);
                //    if (cust != null)
                //    {
                //        Db.NonQuery("INSERT INTO tblByItem_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price], [InDistrGroup],[QuoteDate],[Last12MonthQTY]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}')",
                //            row["Item Number"],
                //            row["Item Description"].ToString().Replace("'", "''"),
                //            row["Customer Number"],
                //            cust["Customer Bill Name"].ToString().Replace("'", "''"),
                //            row["Current Price"],
                //            " ",
                //            row["QuoteDate"],
                //            row["Last12MonthQTY"]
                //            //isInGroup
                //            );
                //    }
                //}
                Db.NonQuery("UPDATE tblByItem_Report a INNER JOIN tblDistributionGroupDetail b ON a.[Customer Number] = b.[Group_Customer_Name] SET a.[FullItemList] = 1 where b.[Group number] = '2'");

                Cursor.Current = Cursors.Default;
                ReportViewers.frmByItem_Viewer frm = new ReportViewers.frmByItem_Viewer();
                frm.Show();
            }

            //-------------------------------------------------------------------------------

            if (rdoPrintByRange.Checked)
            {

                Db.NonQuery(String.Format("INSERT INTO tblByItem_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price], [InDistrGroup],[QuoteDate],[Last12MonthQTY]) SELECT [Item Number], [Item Description], a.[Customer Number], b.[Customer Bill Name],[Current price],'', [QuoteDate], iif(isnull([Last12MonthQTY]),0, a.[Last12MonthQTY])  as [Last12MonthQTYs] FROM tblPricing a inner join tblCustomers b on a.[Customer Number] = b.[Customer Number] WHERE [Item Number] between '{0}' and '{1}' ORDER BY [Current Price] DESC, [Item Number]", cmbFrom.SelectedValue, cmbTo.SelectedValue));
                /* var items = Db.ExecuteDataTable("SELECT [Item Number], [Item Description], [Customer Number], [Current price], [QuoteDate], IIF(ISNULL( [Last12MonthQTY]), 0, [Last12MonthQTY]) as [Last12MonthQTY] FROM tblPricing WHERE [Item Number] between '{0}' and '{1}' ORDER BY [Current Price] DESC, [Item Number]", cmbFrom.SelectedValue, cmbTo.SelectedValue);
                 foreach (DataRow row in items.Rows)
                 {

                     var cust = Db.ExecuteDataRow("SELECT [Customer Bill Name] FROM tblCustomers WHERE [Customer Number] = '{0}'", row["Customer Number"]);
                     if (cust != null)
                     {
                         Db.NonQuery("INSERT INTO tblByItem_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price], [InDistrGroup],[QuoteDate],[Last12MonthQTY]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}')",
                             row["Item Number"],
                             row["Item Description"].ToString().Replace("'", "''"),
                             row["Customer Number"],
                             cust["Customer Bill Name"].ToString().Replace("'", "''"),
                             row["Current Price"],
                             " ",
                             row["QuoteDate"],
                             row["Last12MonthQTY"]
                             );
                     }
                 }*/
                Db.NonQuery("UPDATE tblByItem_Report a INNER JOIN tblDistributionGroupDetail b ON a.[Customer Number] = b.[Group_Customer_Name] SET a.[FullItemList] = 1 where b.[Group number] = '2'");

                Cursor.Current = Cursors.Default;
                ReportViewers.frmByItem_Viewer frm = new ReportViewers.frmByItem_Viewer();
                frm.Show();
            }
            //-------------------------------------------------------------------------------
            if (rdoPrintByFamily.Checked)
            {
                Db.NonQuery(string.Format("INSERT INTO tblByItem_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price], [InDistrGroup],[QuoteDate],[Last12MonthQTY]) SELECT  a.[Item Number], a.[Item Description], b.[Customer Number], c.[Customer Bill Name],[Current price],'', b.[QuoteDate] as [Qt_DATE], iif(isnull([Last12MonthQTY]),0, b.[Last12MonthQTY]) FROM ((tblItems a inner join tblPricing b on a.[Item Number] = b.[Item Number]) inner join tblCustomers c on c.[Customer Number] = b.[Customer Number]) where a.Family ='{0}' ORDER BY [Current Price] DESC, b.[Item Number]", cmbFamily.SelectedValue));
                /* var items = Db.ExecuteDataTable("Select [P.Item Number],[P.Customer Number], [P.Current Price], [I.Family], [I.Item Description], [QuoteDate], IIF(ISNULL( [Last12MonthQTY]), 0, [Last12MonthQTY]) as [Last12MonthQTY] From tblPricing P left join tblItems I on P.[Item Number] = I.[Item number] where I.[Family] = '{0}' order by [P.Current Price] DESC", cmbFamily.SelectedValue);

                 foreach (DataRow row in items.Rows)
                 {

                     var cust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", row["P.Customer Number"]);
                     if (cust != null)
                     {
                         Db.NonQuery("INSERT INTO tblByItem_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price], [InDistrGroup],[QuoteDate],[Last12MonthQTY]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}')",
                             row["P.Item Number"],
                             row["I.Item Description"].ToString().Replace("'", "''"),
                             row["P.Customer Number"],
                             cust["Customer Bill Name"].ToString().Replace("'", "''"),
                             row["P.Current Price"],
                             row["I.Family"],
                             row["QuoteDate"],
                             row["Last12MonthQTY"]

                             );
                     }
                 }*/
                Db.NonQuery("UPDATE tblByItem_Report a INNER JOIN tblDistributionGroupDetail b ON a.[Customer Number] = b.[Group_Customer_Name] SET a.[FullItemList] = 1 where b.[Group number] = '2'");

                Cursor.Current = Cursors.Default;
                ReportViewers.frmByItem_Viewer frm = new ReportViewers.frmByItem_Viewer();
                frm.Show();
            }

            //-------------------------------------------------------------------------------
            if (rdoPrintAll.Checked)
            {
                Db.NonQuery(String.Format("INSERT INTO tblByItem_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price], [InDistrGroup],[QuoteDate],[Last12MonthQTY]) SELECT [Item Number], [Item Description], a.[Customer Number], b.[Customer Bill Name],[Current price],'', [QuoteDate], iif(isnull([Last12MonthQTY]),0, a.[Last12MonthQTY])  as [Last12MonthQTYs] FROM tblPricing a inner join tblCustomers b on a.[Customer Number] = b.[Customer Number] ORDER BY [Current Price] DESC, [Item Number]"));

                /* var reallyItems = Db.ExecuteDataTable("SELECT * FROM tblItems");
                 Db.NonQuery("DELETE FROM tblByItem_Report");

                 foreach (DataRow itemRow in reallyItems.Rows)
                 {
                     var items = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Item Number] = '{0}' ORDER BY [Current Price] DESC", itemRow["Item Number"]);
                     foreach (DataRow row in items.Rows)
                     {

                         var cust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", row["Customer Number"]);
                         if (cust != null)
                         {
                             string Last12MonthQty = System.DBNull.Value.Equals(row["Last12MonthQTY"]) ? "0" : row["Last12MonthQTY"].ToString();
                             Db.NonQuery("INSERT INTO tblByItem_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price], [InDistrGroup],[QuoteDate],[Last12MonthQTY]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}')",
                                 row["Item Number"],
                                 row["Item Description"].ToString().Replace("'", "''"),
                                 row["Customer Number"],
                                 cust["Customer Bill Name"].ToString().Replace("'", "''"),
                                 row["Current Price"],
                                 " ",
                                 row["QuoteDate"],
                                 Last12MonthQty
                             );
                         }
                     }
                 }*/
                Db.NonQuery("UPDATE tblByItem_Report a INNER JOIN tblDistributionGroupDetail b ON a.[Customer Number] = b.[Group_Customer_Name] SET a.[FullItemList] = 1 where b.[Group number] = '2'");

                Cursor.Current = Cursors.Default;
                ReportViewers.frmByItem_Viewer frm = new ReportViewers.frmByItem_Viewer();
                frm.Show();
            }

            //-------------------------------------------------------------------------------
            if (rdoPrintByCustFamily.Checked)
            {
                var items = Db.ExecuteDataTable("Select [P.Item Number],[P.Customer Number], [P.Current Price], [I.Family], [I.Item Description], [P.QuoteDate] as [QuoteDate],  IIF(ISNULL([P.Last12MonthQTY]), 0, [P.Last12MonthQTY]) as [Last12MonthQTY] From tblPricing P left join tblItems I on P.[Item Number] = I.[Item number] where P.[Customer Number] = '{0}' and I.[Family] = '{1}' order by [P.Current Price] desc ", cmbCust1.SelectedValue, cmbFamily1.SelectedValue);

                foreach (DataRow row in items.Rows)
                {

                    var cust = Db.ExecuteDataRow("SELECT [Customer Bill Name] FROM tblCustomers WHERE [Customer Number] = '{0}'", row["P.Customer Number"]);
                    if (cust != null)
                    {
                        Db.NonQuery("INSERT INTO tblByItem_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price], [InDistrGroup],[QuoteDate],[Last12MonthQTY]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}')",
                            row["P.Item Number"],
                            row["I.Item Description"].ToString().Replace("'", "''"),
                            row["P.Customer Number"],
                            cust["Customer Bill Name"].ToString().Replace("'", "''"),
                            row["P.Current Price"],
                            row["I.Family"],
                            row["QuoteDate"],
                            row["Last12MonthQTY"]

                            );
                    }
                }
                Db.NonQuery("UPDATE tblByItem_Report a INNER JOIN tblDistributionGroupDetail b ON a.[Customer Number] = b.[Group_Customer_Name] SET a.[FullItemList] = 1 where b.[Group number] = '2'");

                Cursor.Current = Cursors.Default;
                ReportViewers.frmItemsByCustFamily_Viewer frm = new ReportViewers.frmItemsByCustFamily_Viewer();
                frm.Show();
            }
        }
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        private void btnViewReport2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var custPricings = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}'", cmbCust.SelectedValue);
            Db.NonQuery("DELETE FROM tblByCustomer_Report");
            string SwingNumber = "";
            for (int i = 0; i < custPricings.Rows.Count; i++)
            {
                decimal ASRCurrPriceDec = 0;
                decimal ASTCurrPriceDec = 0;
                var ASRCurrPrice = Db.ExecuteDataRow("SELECT TOP 1 [Current Price] FROM tblPricing WHERE [Customer Number] = 'ASR' AND [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);
                var ASTCurrPrice = Db.ExecuteDataRow("SELECT TOP 1 [Current Price] FROM tblPricing WHERE [Customer Number] = 'AST' AND [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);

                if (ASRCurrPrice != null)
                    ASRCurrPriceDec = (decimal)ASRCurrPrice[0];
                if (ASTCurrPrice != null)
                    ASTCurrPriceDec = (decimal)ASTCurrPrice[0];

                var cust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", custPricings.Rows[i]["Customer Number"]);
                string Last12MonthQty = System.DBNull.Value.Equals(custPricings.Rows[i]["Last12MonthQTY"]) ? "0" : custPricings.Rows[i]["Last12MonthQTY"].ToString();

                Db.NonQuery("INSERT INTO tblByCustomer_Report ([Customer Number], [Customer Name], [Item Number], [Item Description], [Current Price], [Customer Item Number], [IsNew], [ASR Current Price], [AST Current Price],[Last12MonthQTY]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}')",
                    custPricings.Rows[i]["Customer Number"],
                    cust["Customer Bill Name"].ToString().Replace("'", "''"),
                    custPricings.Rows[i]["Item Number"],
                    custPricings.Rows[i]["Item Description"].ToString().Replace("'", "''"),
                    custPricings.Rows[i]["Current Price"],
                    custPricings.Rows[i]["Customer Item Number"],
                    custPricings.Rows[i]["IsNew"],
                    ASRCurrPriceDec,
                    ASTCurrPriceDec,
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
            //        frmReportViewer frm = new frmReportViewer();
            frmReport2_all_Viewer frm = new frmReport2_all_Viewer();
            frm.DisplayManagerInfo = ManagerDisplay;
            frm.Show();

        }
        //------------------------------------------------------------------------------------------------
        private void btnViewReport3_Click(object sender, EventArgs e)
        {
            if (rdoSwing2.Checked)
            {
                Cursor.Current = Cursors.WaitCursor;
                Db.NonQuery("DELETE FROM tblBySwing_Report");
                string SwingNumber = "";
                string a = cmbSwing.SelectedText.ToString();
                string b = cmbSwing.Text;

                var cutomers = Db.ExecuteDataTable("SELECT * FROM tblCustomers WHERE [Swing Number] = '{0}'", cmbSwing.SelectedValue);
                SwingNumber = cmbSwing.SelectedValue.ToString();
                foreach (DataRow custRow in cutomers.Rows)
                {
                    Db.NonQuery("INSERT INTO tblBySwing_Report ([Swing Number], [Swing Name], [Customer Number], [Customer Name]) VALUES ('{0}', '{1}', '{2}', '{3}')",
                        cmbSwing.SelectedValue,
                        cmbSwing.Text,
                        custRow["Customer Number"],
                        custRow["Customer Bill Name"].ToString().Replace("'", "''")
                        );

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
                                ManagerDisplay += dtManagerDisplay.Rows[0]["CompanyName"] + " " +
                                    dtManagerDisplay.Rows[0]["ManagerName"] + Environment.NewLine;

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
                                ManagerDisplay += sameAddressCompanyName + " " +
                                                   sameAddressManagerName + Environment.NewLine;

                                DataView dv1 = new DataView(dtManagerDisplay);
                                dv1.RowFilter = "RowID <> 1 and SameAddress='False'";
                                foreach (DataRowView rw in dv1)
                                {
                                    ManagerDisplay += rw["CompanyName"] + " " +
                                                       rw["ManagerName"] + Environment.NewLine;

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
                                ManagerDisplay += obj.ManagerName + Environment.NewLine;


                            }
                            */

                        }
                    }
                    ReportViewers.frmBySwing_Report_Viewer frm = new ReportViewers.frmBySwing_Report_Viewer();
                    frm.DisplayManagerInfo = ManagerDisplay;
                    frm.Show();


                }

            }
            else if (rdoPrintCustBySalesPer.Checked)
            {
                if (cmbSalesPerson.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a sales person.");
                }
                else
                {
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
                    string swingNumber = cmbSalesPerson.SelectedValue.ToString();
                    Cursor.Current = Cursors.WaitCursor;
                    Db.NonQuery("DELETE FROM tblByCustomer_Report");
                    Db.NonQuery("INSERT INTO tblByCustomer_Report ([Customer Number], [Customer Name], [Item Number], [Item Description], [Current Price], [Customer Item Number], [IsNew], [QuoteDate],[Last12MonthQty])" +
                       "SELECT c.[Customer Number], c.[Customer Bill Name], i.[Item Number]" +
                       ", i.[Item Description],p.[Current Price], p.[Customer Item Number], IIF(p.[IsNew], 'True', 'False') AS [IsNew], p.[QuoteDate] ,p.[Last12MonthQty] " +
                       "FROM (tblCustomers c INNER JOIN tblPricing p on p.[Customer Number] = c.[Customer Number])" +
                       "INNER JOIN tblItems i on i.[Item Number] = p.[Item Number] where c.[Swing Number] = '" + swingNumber + "'");

                    string ManagerDisplay = "";
                    if (swingNumber.Length > 0)
                    {
                        DataTable dt = Db.ExecuteDataTable("SELECT * From tblSwingNumbers WHERE [Swing Number] ='{0}'", swingNumber);
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
                                                       (sameAddressPhone.Length > 0 ? "Phone: " + sameAddressPhone + Environment.NewLine : "") +
                                                       (sameAddressFax.Length > 0 ? "Fax: " + sameAddressFax + Environment.NewLine : "") +
                                                       (sameAddressCell.Length > 0 ? sameAddressCell + Environment.NewLine : "") +
                                                       (sameAddressEmail.Length > 0 ? sameAddressEmail + Environment.NewLine : "") + Environment.NewLine;
                                    DataView dv1 = new DataView(dtManagerDisplay);
                                    dv1.RowFilter = "RowID <> 1 and SameAddress='False'";
                                    foreach (DataRowView rw in dv1)
                                    {
                                        ManagerDisplay += rw["CompanyName"] + Environment.NewLine +
                                                           rw["ManagerName"] + Environment.NewLine +
                                                           (rw["ManagerPhone"].ReplaceNulls().Length > 0 ? "Phone:" + rw["ManagerPhone"] + Environment.NewLine : "") +
                                                          (rw["ManagerFax"].ReplaceNulls().Length > 0 ? "Fax:" + rw["ManagerFax"] + Environment.NewLine : "") +
                                                           (rw["ManagerCell"].ReplaceNulls().Length > 0 ? "Cell:" + rw["ManagerCell"] + Environment.NewLine : "") +
                                                          (rw["ManagerEmail"].ReplaceNulls().Length > 0 ? "Email:" + rw["ManagerEmail"] + Environment.NewLine : "") + Environment.NewLine;

                                    }
                                }
                            }
                        }



                    }
                    frmReport_Customer_BySalesPerson frm = new frmReport_Customer_BySalesPerson();
                    frm.reportType = reportType;
                    frm.DisplayManagerInfo = ManagerDisplay;
                    frm.Show();

                }
            }

            else
            {
                MessageBox.Show("Please, press the Swing radio button first.");
            }

        }

        //----------------------------------------------------------------------------------------------

        private void btnViewReport4_Click(object sender, EventArgs e)
        {
            if (rdoCompareCust.Checked)
            {
                Db.NonQuery("DELETE FROM tblByCustomerComparison_Report");

                var custFrom = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", cmbCustFrom.SelectedValue);
                var custTo = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", cmbCustTo.SelectedValue);

                var itemsFrom = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}'", custFrom["Customer Number"]);
                var itemsTo = Db.ExecuteDataTable("SELECT * FROM tblPricing WHERE [Customer Number] = '{0}'", custTo["Customer Number"]);

                foreach (DataRow itemFromRow in itemsFrom.Rows)
                {
                    var leadItem = itemsTo.AsEnumerable().Where(lt => lt.Field<string>("Item Number").Equals(itemFromRow["Item Number"])).SingleOrDefault();
                    if (leadItem == null)
                    {
                        Db.NonQuery("INSERT INTO tblByCustomerComparison_Report ([Customer1 Number], [Customer1 Name], [Item Number], [Item Description], [Current Price1], [Customer2 Number], [Customer2 Name], [Current Price2]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                            custFrom["Customer Number"],
                            custFrom["Customer Bill Name"],
                            itemFromRow["Item Number"],
                            itemFromRow["Item Description"].ToString().Replace("'", "''"),
                            itemFromRow["Current Price"],
                            custTo["Customer Number"],
                            custTo["Customer Bill Name"],
                            //    "Doesn’t Buy this Item"
                            0
                            );
                    }
                    else
                    {
                        Db.NonQuery("INSERT INTO tblByCustomerComparison_Report ([Customer1 Number], [Customer1 Name], [Item Number], [Item Description], [Current Price1], [Customer2 Number], [Customer2 Name], [Current Price2]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                            custFrom["Customer Number"],
                            custFrom["Customer Bill Name"],
                            itemFromRow["Item Number"],
                            itemFromRow["Item Description"].ToString().Replace("'", "''"),
                            itemFromRow["Current Price"],
                            custTo["Customer Number"],
                            custTo["Customer Bill Name"],
                            leadItem["Current Price"]
                            );


                    }
                }

                frmByCustomer_Comparison_Report_Viewer frm = new frmByCustomer_Comparison_Report_Viewer();
                frm.Show();
            }
            else
            {
                //    NOTES:  "chkAll" not active for now !!!!!!!
                // if (rdoCompareItems.Checked && chkAll.Checked)
                if (rdoCompareItems.Checked)
                {

                    Db.NonQuery("DELETE FROM tblByItemComparison_Report");
                    var itemPricing = Db.ExecuteDataRow("SELECT TOP 1 * FROM tblPricing WHERE [Item Number] = '{0}'", cmbCompItem.SelectedValue);

                    if (itemPricing == null)
                    {
                        MessageBox.Show("The Item you're comparing to is not exist in Pricing data Base.");
                    }
                    else
                    {
                        var cust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", itemPricing["Customer Number"]);
                        Db.NonQuery("INSERT INTO tblByItemComparison_Report ([Item Number], [Item Description], [Customer Number], [Customer Name], [Current Price]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                itemPricing["Item Number"],
                                itemPricing["Item Description"],
                                cust["Customer Number"],
                                cust["Customer Bill Name"],
                                itemPricing["Current Price"]);


                        ReportViewers.frmByItem_Comparison_Report_Viewer frm = new ReportViewers.frmByItem_Comparison_Report_Viewer();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please, select Compare Customer or Compare Items radio Button");
                }
            }
        }
        //--------------------------------------------------------------------------

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //----------------------------------------------------------------------------------

        private void btnViewReport5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var custPricings = Db.ExecuteDataTable("SELECT [Customer Number], [Item Number], [Current Price], [Customer Item Number],[IsNew] FROM tblPricing WHERE [Customer Number] = '{0}' and [Item Number] between '{1}' and '{2}'", cmbCust5.SelectedValue, cmbFrom5.SelectedValue, cmbTo5.SelectedValue);

            Db.NonQuery("DELETE FROM tblByCustomer_Report");
            string SwingNumber = "";
            for (int i = 0; i < custPricings.Rows.Count; i++)
            {
                decimal ASRCurrPriceDec = 0;
                decimal ASTCurrPriceDec = 0;
                var ASRCurrPrice = Db.ExecuteDataRow("SELECT TOP 1 [Current Price] FROM tblPricing WHERE [Customer Number] = 'ASR' AND [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);
                var ASTCurrPrice = Db.ExecuteDataRow("SELECT TOP 1 [Current Price] FROM tblPricing WHERE [Customer Number] = 'AST' AND [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);

                if (ASRCurrPrice != null)
                    ASRCurrPriceDec = (decimal)ASRCurrPrice[0];
                if (ASTCurrPrice != null)
                    ASTCurrPriceDec = (decimal)ASTCurrPrice[0];

                //            var cust = Db.ExecuteDataRow("SELECT * FROM tblCustomers WHERE [Customer Number] = '{0}'", custPricings.Rows[i]["Customer Number"]);
                var cust = Db.ExecuteDataRow("SELECT [Customer Bill Name],[Swing Number] FROM tblCustomers WHERE [Customer Number] = '{0}'", custPricings.Rows[i]["Customer Number"]);
                var itemDscr = Db.ExecuteDataRow("SELECT [Item Description] FROM tblItems WHERE [Item Number] = '{0}'", custPricings.Rows[i]["Item Number"]);

                Db.NonQuery("INSERT INTO tblByCustomer_Report ([Customer Number], [Customer Name], [Item Number], [Item Description], [Current Price], [Customer Item Number], [IsNew], [ASR Current Price], [AST Current Price]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                    custPricings.Rows[i]["Customer Number"],
                    cust["Customer Bill Name"].ToString().Replace("'", "''"),
                    custPricings.Rows[i]["Item Number"],
                    itemDscr["Item Description"].ToString().Replace("'", "''"),
                    custPricings.Rows[i]["Current Price"],
                    custPricings.Rows[i]["Customer Item Number"],
                    custPricings.Rows[i]["IsNew"],
                    ASRCurrPriceDec,
                    ASTCurrPriceDec
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
            frmReport2_all_Viewer frm = new frmReport2_all_Viewer();
            frm.DisplayManagerInfo = ManagerDisplay;
            frm.Show();

        }


        //--------------------------------------------------------------------------------------

    }
}
