using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Unified_Price_for_Var.Properties;

namespace Unified_Price_for_Var
{
    public partial class frmChangeGroupPricing : Form
    {
        public DataTable _dataTableFamily;
        public DataTable _dataTableFamily6;

        public frmChangeGroupPricing()
        {
            InitializeComponent();

            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            rdoChange_Price1.Checked = true;

            if (rdoChange_Price1.Checked)
                rdoChange_Price1.Font = new Font(rdoChange_Price1.Font.FontFamily, rdoChange_Price1.Font.Size, FontStyle.Bold);


            _dataTableFamily6 = Db.ExecuteDataTable("Select distinct [Family] FROM tblItems ORDER BY [Family]");
            cmbFamily6.DataSource = _dataTableFamily6;
            cmbFamily6.DisplayMember = "Family";
            cmbFamily6.ValueMember = "Family";

            _dataTableFamily = Db.ExecuteDataTable("Select distinct [Family] FROM tblItems ORDER BY [Family]");
            cmbFamily.DataSource = _dataTableFamily;
            cmbFamily.DisplayMember = "Family";
            cmbFamily.ValueMember = "Family";



        }
        //==================================================================
        private void ChangeGroupPricing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pricing_for_Tanya_DataSet.tblGroupMaster' table. You can move, or remove it, as needed.
            this.tblGroupMasterTableAdapter.Fill(this.pricing_for_Tanya_DataSet.tblGroupMaster);

            // TODO: This line of code loads data into the 'pricing_for_Tanya_DataSet.tblPricing' table. You can move, or remove it, as needed.
            this.tblPricingTableAdapter.Fill(this.pricing_for_Tanya_DataSet.tblPricing);


            // TODO: This line of code loads data into the 'pricing_for_Tanya_DataSet.tblCustomers' table. You can move, or remove it, as needed.
            this.tblCustomersTableAdapter.Fill(this.pricing_for_Tanya_DataSet.tblCustomers);

            this.tblItemsTableAdapter.Fill(this.pricing_for_Tanya_DataSet.tblItems);


            // TODO: This line of code loads data into the 'pricing_for_Tanya_DataSet.tblSwingNumbers' table. You can move, or remove it, as needed.
            this.tblSwingNumbersTableAdapter.Fill(this.pricing_for_Tanya_DataSet.tblSwingNumbers);


        }

        //====================================================================       
        private void rdoChange_Price1_CheckedChanged(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;

            if (rdoChange_Price1.Checked)
                rdoChange_Price1.Font = new Font(rdoChange_Price1.Font.FontFamily, rdoChange_Price1.Font.Size, FontStyle.Bold);
            else
                rdoChange_Price1.Font = new Font(rdoChange_Price1.Font.FontFamily, rdoChange_Price1.Font.Size, FontStyle.Regular);

        }

        //==================================================================    
        private void rdoChange_Price2_CheckedChanged(object sender, EventArgs e)
        {
            pnl2.Visible = true;
            pnl1.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;

            if (rdoChange_Price2.Checked)
                rdoChange_Price2.Font = new Font(rdoChange_Price2.Font.FontFamily, rdoChange_Price2.Font.Size, FontStyle.Bold);
            else if (rdoChange_Price_Active_ByCust.Checked)
                rdoChange_Price_Active_ByCust.Font = new Font(rdoChange_Price_Active_ByCust.Font.FontFamily, rdoChange_Price_Active_ByCust.Font.Size, FontStyle.Bold);
            else if (rdoChange_Price_InActive_ByCust.Checked)
                rdoChange_Price_InActive_ByCust.Font = new Font(rdoChange_Price_InActive_ByCust.Font.FontFamily, rdoChange_Price_InActive_ByCust.Font.Size, FontStyle.Bold);
            else
            {
                rdoChange_Price2.Font = new Font(rdoChange_Price2.Font.FontFamily, rdoChange_Price2.Font.Size, FontStyle.Regular);
                rdoChange_Price_InActive_ByCust.Font = new Font(rdoChange_Price_InActive_ByCust.Font.FontFamily, rdoChange_Price_InActive_ByCust.Font.Size, FontStyle.Regular);
                rdoChange_Price_Active_ByCust.Font = new Font(rdoChange_Price_Active_ByCust.Font.FontFamily, rdoChange_Price_Active_ByCust.Font.Size, FontStyle.Regular);
            }


        }
        //=======================================================================
        private void rdoChange_Price3_CheckedChanged(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;

            if (rdoChange_Price3.Checked)
                rdoChange_Price3.Font = new Font(rdoChange_Price3.Font.FontFamily, rdoChange_Price3.Font.Size, FontStyle.Bold);
            else
                rdoChange_Price3.Font = new Font(rdoChange_Price3.Font.FontFamily, rdoChange_Price3.Font.Size, FontStyle.Regular);

        }
        //==========================================================================
        private void rdoChange_Price4_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pnl4.Visible = true;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            Cursor.Current = Cursors.Default;

            if (rdoChange_Price4.Checked)
                rdoChange_Price4.Font = new Font(rdoChange_Price4.Font.FontFamily, rdoChange_Price4.Font.Size, FontStyle.Bold);
            else
                rdoChange_Price4.Font = new Font(rdoChange_Price4.Font.FontFamily, rdoChange_Price4.Font.Size, FontStyle.Regular);


        }
        //=============================================================================
        private void rdoChangePrice5_CheckedChanged(object sender, EventArgs e)
        {
            pnl5.Visible = true;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl4.Visible = false;
            pnl6.Visible = false;

            if (rdoChangePrice5.Checked)
                rdoChangePrice5.Font = new Font(rdoChangePrice5.Font.FontFamily, rdoChangePrice5.Font.Size, FontStyle.Bold);
            else
                rdoChangePrice5.Font = new Font(rdoChangePrice5.Font.FontFamily, rdoChangePrice5.Font.Size, FontStyle.Regular);

        }
        //============================================================================
        private void rdoChange_Price6_CheckedChanged(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = true;

            if (rdoChange_Price6.Checked)
                rdoChange_Price6.Font = new Font(rdoChange_Price6.Font.FontFamily, rdoChange_Price6.Font.Size, FontStyle.Bold);
            else
                rdoChange_Price6.Font = new Font(rdoChange_Price6.Font.FontFamily, rdoChange_Price6.Font.Size, FontStyle.Regular);
        }

        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //=======================================================================================
        public void btnChange_Price_Click_1(object sender, EventArgs e)
        {

            if (this.IsValid())
            {
                decimal numberOfChange = Convert.ToDecimal(txtIncr_Decr.Text);
                decimal priceAfter = 0;
                //==========================================================================================
                //=============== rdoChange1 Checked =======================================================
                //==========================================================================================

                if (rdoChange_Price1.Checked)      //Change price by Item number
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter aPricing =
                       new Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter();

                    for (int i = 0; i < this.ItemGrid.Rows.Count; i++)
                    {
                        if (this.ItemGrid.Rows[i].Selected == true)
                        {

                            Pricing_for_Tanya_DataSet.tblPricingDataTable machItems =
                             aPricing.GetDataByItem(this.ItemGrid.Rows[i].Cells[0].Value.ToString());

                            machItems.Rows.Count.ToString();    // Just for verification


                            for (int x = 0; x < machItems.Rows.Count; x++)
                            {
                                machItems[x].Current_Price.ToString();
                                string custNumber = machItems[x].Customer_Number.ToString();

                                //-----------------------------------                
                                if (rdoIncrease_byPercent.Checked || rdoDecrease_byPercent.Checked)
                                {
                                    if (rdoIncrease_byPercent.Checked)
                                    { priceAfter = (1 + Convert.ToDecimal(txtIncr_Decr.Text) / 100); }
                                    if (rdoDecrease_byPercent.Checked)
                                    { priceAfter = (1 - Convert.ToDecimal(txtIncr_Decr.Text) / 100); }

                                    try
                                    {
                                        var result1 = Math.Round((machItems[x].Current_Price * priceAfter), 4);
                                        this.tblPricingBindingSource.EndEdit();
                                        //   aPricing.UpdatePriceByItemAndCustomer((machItems[x].Current_Price * priceAfter),
                                        aPricing.UpdatePriceByItemAndCustomer(result1,
                                          machItems[x].Current_Price, 0, true, this.ItemGrid.Rows[i].Cells[0].Value.ToString(), custNumber);
                                        //MessageBox.Show("Update Completed.", "Information");
                                    }
                                    catch
                                    {
                                        MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                    }
                                }
                                //---------------------------------
                                if (rdoIncrease_byFixedNumber.Checked || rdoDecrease_byFixedNumber.Checked)
                                {
                                    if (rdoIncrease_byFixedNumber.Checked)
                                    { priceAfter = (Convert.ToDecimal(numberOfChange)); }
                                    if (rdoDecrease_byFixedNumber.Checked)
                                    { priceAfter = -(Convert.ToDecimal(numberOfChange)); }

                                    try
                                    {
                                        this.tblPricingBindingSource.EndEdit();
                                        aPricing.UpdatePriceByItemAndCustomer((machItems[x].Current_Price + priceAfter),
                                                     machItems[x].Current_Price, 0, true, this.ItemGrid.Rows[i].Cells[0].Value.ToString(), custNumber);
                                        //MessageBox.Show("Update Completed.", "Information");
                                    }
                                    catch
                                    {
                                        MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                    }
                                }
                                //----------------------------
                            }
                            //  ---- END LOOP  -----
                        }

                    }
                    Cursor.Current = Cursors.Default;
                }

                //==========================================================================================
                //=============== rdoChange2 Checked =======================================================
                //==========================================================================================

                if (rdoChange_Price2.Checked || rdoChange_Price_Active_ByCust.Checked || rdoChange_Price_InActive_ByCust.Checked)     //Change price by Selected CUSTOMER number
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string customerNumber = cmbCustomer.SelectedValue.ToString();
                    customerNumber = "";

                    Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter aPricing =
                        new Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter();

                    // Grid in loop
                    for (int i = 0; i < this.CustomGrid.Rows.Count; i++)      //Loop over grid
                    {
                        if (this.CustomGrid.Rows[i].Selected == true)
                        {
                            Pricing_for_Tanya_DataSet.tblPricingDataTable machItem =
                                aPricing.GetDataBy(this.CustomGrid.Rows[i].Cells[0].Value.ToString());

                            machItem.Rows.Count.ToString();  // just for verification
                            //-------------------------------------------

                            for (int x = 0; x < machItem.Rows.Count; x++)   // Read in loop table machItem
                            {
                                string itemNumber = machItem[x].Item_Number.ToString();
                                customerNumber = machItem[x].Customer_Number.ToString();
                                DateTime dtQtDate = machItem[x].QuoteDate;
                                double Last12MonthQty = machItem[x].Last12MonthQTY;

                                bool blContinue = false;
                                if (rdoChange_Price2.Checked) blContinue = true;
                                else if (rdoChange_Price_Active_ByCust.Checked)
                                {
                                    if (Last12MonthQty > 0 || dtQtDate >= DateTime.Now.AddYears(-1))
                                        blContinue = true;

                                }
                                else if (rdoChange_Price_InActive_ByCust.Checked)
                                {
                                    if (Last12MonthQty <= 0 && dtQtDate < DateTime.Now.AddYears(-1))
                                        blContinue = true;
                                }

                                if (blContinue)
                                {
                                    if (rdoIncrease_byPercent.Checked || rdoDecrease_byPercent.Checked)
                                    {
                                        if (rdoIncrease_byPercent.Checked)
                                        { priceAfter = (1 + Convert.ToDecimal(txtIncr_Decr.Text) / 100); }
                                        if (rdoDecrease_byPercent.Checked)
                                        { priceAfter = (1 - Convert.ToDecimal(txtIncr_Decr.Text) / 100); }
                                        try
                                        {
                                            var result2 = Math.Round((machItem[x].Current_Price * priceAfter), 4);
                                            this.tblPricingBindingSource.EndEdit();
                                            //    aPricing.UpdatePriceByItemAndCustomer((machItem[x].Current_Price * priceAfter),
                                            aPricing.UpdatePriceByItemAndCustomer(result2,
                                            machItem[x].Current_Price, 0, true, itemNumber, customerNumber);

                                        }
                                        catch
                                        {
                                            MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                        }
                                    }
                                    //---------------------------------
                                    if (rdoIncrease_byFixedNumber.Checked || rdoDecrease_byFixedNumber.Checked)
                                    {
                                        if (rdoIncrease_byFixedNumber.Checked)
                                        { priceAfter = (Convert.ToDecimal(numberOfChange)); }
                                        if (rdoDecrease_byFixedNumber.Checked)
                                        { priceAfter = -(Convert.ToDecimal(numberOfChange)); }

                                        try
                                        {
                                            this.tblPricingBindingSource.EndEdit();
                                            aPricing.UpdatePriceByItemAndCustomer((machItem[x].Current_Price + priceAfter),
                                               machItem[x].Current_Price, 0, true, itemNumber, customerNumber);

                                            //  
                                        }
                                        catch
                                        {
                                            MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                        }
                                    }
                                }
                            }
                        }
                    }

                    Cursor.Current = Cursors.Default;
                    //MessageBox.Show("Update Completed.", "Information");
                }
                //==========================================================================================
                //=============== rdoChange3 Checked =======================================================
                //==========================================================================================

                if (rdoChange_Price3.Checked)    // Change price for All Items in table
                {
                    if (MessageBox.Show("You are going to change prices on ALL COMPANY items. \n It is very dangerous process. Are you sure you like to continue???", "Important questions", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        Cursor.Current = Cursors.WaitCursor;
                        Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter aPricing =
                          new Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter();

                        ItemGrid.SelectAll();

                        Pricing_for_Tanya_DataSet.tblPricingDataTable machItems =
                            new Pricing_for_Tanya_DataSet.tblPricingDataTable();
                        aPricing.Fill(machItems);

                        machItems.Rows.Count.ToString();  // just for verification

                        for (int x = 0; x < machItems.Rows.Count; x++)
                        {
                            string currPrice = machItems[x].Current_Price.ToString();
                            string custNumber = machItems[x].Customer_Number.ToString();
                            string itemNumber = machItems[x].Item_Number.ToString();
                            //-----------------------------------                
                            if (rdoIncrease_byPercent.Checked || rdoDecrease_byPercent.Checked)
                            {
                                if (rdoIncrease_byPercent.Checked)
                                { priceAfter = (1 + Convert.ToDecimal(txtIncr_Decr.Text) / 100); }
                                if (rdoDecrease_byPercent.Checked)
                                { priceAfter = (1 - Convert.ToDecimal(txtIncr_Decr.Text) / 100); }

                                try
                                {
                                    var result3 = Math.Round((machItems[x].Current_Price * priceAfter), 4);
                                    this.tblPricingBindingSource.EndEdit();
                                    //   aPricing.UpdatePriceByItemAndCustomer((machItems[x].Current_Price * priceAfter),
                                    aPricing.UpdatePriceByItemAndCustomer(result3,
                                       machItems[x].Current_Price, 0, true, itemNumber, custNumber);

                                }
                                catch
                                {
                                    MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                }
                            }
                            //---------------------------------
                            if (rdoIncrease_byFixedNumber.Checked || rdoDecrease_byFixedNumber.Checked)
                            {
                                if (rdoIncrease_byFixedNumber.Checked)
                                { priceAfter = (Convert.ToDecimal(numberOfChange)); }
                                if (rdoDecrease_byFixedNumber.Checked)
                                { priceAfter = -(Convert.ToDecimal(numberOfChange)); }

                                try
                                {
                                    this.tblPricingBindingSource.EndEdit();
                                    aPricing.UpdatePriceByItemAndCustomer((machItems[x].Current_Price + priceAfter),
                                                 machItems[x].Current_Price, 0, true, itemNumber, custNumber);
                                    // MessageBox.Show("Update Completed.", "Information");
                                }
                                catch
                                {
                                    MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                }
                            }
                            //----------------------------
                        }
                        //  ---- END LOOP  -----
                    }
                    Cursor.Current = Cursors.Default;
                }
                //       }

                //   }

                //==========================================================================================
                //=============== rdoChange4 Checked =======================================================
                //==========================================================================================

                if (rdoChange_Price4.Checked)   //  By Family or Component number
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string familyName = cmbFamily.SelectedValue.ToString();

                    var machItems = Db.ExecuteDataTable("Select p.[Customer Number], p.[Current Price], p.[Item Number] from tblPricing as P  left join tblItems as I  on P.[Item Number] = I.[Item Number] where I.[Family] = '{0}'", cmbFamily.SelectedValue);

                    machItems.Rows.Count.ToString();  // just for verification

                    for (int x = 0; x < machItems.Rows.Count; x++)
                    {

                        string currPrice = machItems.Rows[x]["Current Price"].ToString();
                        string custNumber = machItems.Rows[x]["Customer Number"].ToString();
                        string itemNumber = machItems.Rows[x]["Item number"].ToString();

                        //-----------------------------------                
                        if (rdoIncrease_byPercent.Checked || rdoDecrease_byPercent.Checked)
                        {
                            if (rdoIncrease_byPercent.Checked)
                            { priceAfter = (1 + Convert.ToDecimal(txtIncr_Decr.Text) / 100); }

                            if (rdoDecrease_byPercent.Checked)
                            { priceAfter = (1 - Convert.ToDecimal(txtIncr_Decr.Text) / 100); }

                            try
                            {
                                decimal result4 = Convert.ToDecimal(currPrice);
                                result4 = result4 * priceAfter;
                                result4 = Math.Round(result4, 4);

                                Db.NonQuery("Update tblPricing Set [Old Price] = [Current Price], [Current price] = '{0}', [IsNew] = true, [New Price] = '{0}'  where [Customer Number] = '{1}' and [Item Number] = '{2}' ", result4, custNumber, itemNumber);

                            }
                            catch
                            {
                                MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                            }
                        }
                        //---------------------------------------------------------------------------------------------------
                        if (rdoIncrease_byFixedNumber.Checked || rdoDecrease_byFixedNumber.Checked)
                        {
                            if (rdoIncrease_byFixedNumber.Checked)
                            { priceAfter = (Convert.ToDecimal(numberOfChange)); }

                            if (rdoDecrease_byFixedNumber.Checked)
                            { priceAfter = -(Convert.ToDecimal(numberOfChange)); }

                            try
                            {
                                decimal result4 = Convert.ToDecimal(currPrice);
                                result4 = result4 + priceAfter;
                                result4 = Math.Round(result4, 4);

                                Db.NonQuery("Update tblPricing Set [Old Price] = [Current Price], [Current price] = '{0}', [IsNew] = true, [New Price] = '{0}'  where [Customer Number] = '{1}' and [Item Number] = '{2}' ", result4, custNumber, itemNumber);

                            }
                            catch
                            {
                                MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                            }
                        }

                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Update Completed.", "Information");
                }
                //==========================================================================================
                //=============== rdoChange5 Checked =======================================================
                //==========================================================================================

                if (rdoChangePrice5.Checked)   // Territory or Swing
                {
                    string customerNumber;

                    if (cmbTerritioy.SelectedIndex > -1)
                    {
                        string territory = cmbTerritioy.SelectedValue.ToString();

                        Pricing_for_Tanya_DataSetTableAdapters.tblCustomersTableAdapter aCustomers =
                            new Pricing_for_Tanya_DataSetTableAdapters.tblCustomersTableAdapter();

                        Pricing_for_Tanya_DataSet.tblCustomersDataTable machCust =
                            aCustomers.GetByTerritory(Convert.ToInt16(territory));

                        machCust.Rows.Count.ToString();  // just for verification

                        for (int i = 0; i < machCust.Rows.Count; i++)   // Read in loop table machItem
                        {
                            customerNumber = machCust[i].Customer_Number.ToString();

                            Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter aPricing =
                                new Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter();

                            Pricing_for_Tanya_DataSet.tblPricingDataTable machItems =
                               aPricing.GetDataBy(customerNumber);

                            machItems.Rows.Count.ToString();  // just for verification

                            for (int x = 0; x < machItems.Rows.Count; x++)   // Read in loop table machItem
                            {
                                string itemNumber = machItems[x].Item_Number.ToString();
                                customerNumber = machItems[x].Customer_Number.ToString();

                                if (rdoIncrease_byPercent.Checked || rdoDecrease_byPercent.Checked)
                                {
                                    if (rdoIncrease_byPercent.Checked)
                                    { priceAfter = (1 + Convert.ToDecimal(txtIncr_Decr.Text) / 100); }
                                    if (rdoDecrease_byPercent.Checked)
                                    { priceAfter = (1 - Convert.ToDecimal(txtIncr_Decr.Text) / 100); }
                                    try
                                    {
                                        var result5 = Math.Round((machItems[x].Current_Price * priceAfter), 4);
                                        this.tblPricingBindingSource.EndEdit();
                                        //     aPricing.UpdatePriceByItemAndCustomer((machItems[x].Current_Price * priceAfter),
                                        aPricing.UpdatePriceByItemAndCustomer(result5,
                                        machItems[x].Current_Price, 0, true, itemNumber, customerNumber);

                                    }
                                    catch
                                    {
                                        MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                    }
                                }
                                //---------------------------------
                                if (rdoIncrease_byFixedNumber.Checked || rdoDecrease_byFixedNumber.Checked)
                                {
                                    if (rdoIncrease_byFixedNumber.Checked)
                                    { priceAfter = (Convert.ToDecimal(numberOfChange)); }
                                    if (rdoDecrease_byFixedNumber.Checked)
                                    { priceAfter = -(Convert.ToDecimal(numberOfChange)); }

                                    try
                                    {
                                        this.tblPricingBindingSource.EndEdit();
                                        aPricing.UpdatePriceByItemAndCustomer((machItems[x].Current_Price + priceAfter),
                                           machItems[x].Current_Price, 0, true, itemNumber, customerNumber);

                                        //  
                                    }
                                    catch
                                    {
                                        MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                    }
                                }

                            }
                        }
                    }
                    //-----------------------------------
                    if (cmbSwing.SelectedIndex > -1)
                    {
                        string swingNumber = cmbSwing.SelectedValue.ToString();
                        Pricing_for_Tanya_DataSetTableAdapters.tblCustomersTableAdapter aCustomers =
                            new Pricing_for_Tanya_DataSetTableAdapters.tblCustomersTableAdapter();

                        Pricing_for_Tanya_DataSet.tblCustomersDataTable machCust =
                            aCustomers.GetBySwing(swingNumber);

                        machCust.Rows.Count.ToString();  // just for verification

                        for (int i = 0; i < machCust.Rows.Count; i++)   // Read in loop table machItem
                        {
                            customerNumber = machCust[i].Customer_Number.ToString();

                            Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter aPricing =
                                new Pricing_for_Tanya_DataSetTableAdapters.tblPricingTableAdapter();

                            Pricing_for_Tanya_DataSet.tblPricingDataTable machItems =
                               aPricing.GetDataBy(customerNumber);

                            machItems.Rows.Count.ToString();  // just for verification

                            for (int x = 0; x < machItems.Rows.Count; x++)   // Read in loop table machItem
                            {
                                string itemNumber = machItems[x].Item_Number.ToString();
                                customerNumber = machItems[x].Customer_Number.ToString();

                                if (rdoIncrease_byPercent.Checked || rdoDecrease_byPercent.Checked)
                                {
                                    if (rdoIncrease_byPercent.Checked)
                                    { priceAfter = (1 + Convert.ToDecimal(txtIncr_Decr.Text) / 100); }
                                    if (rdoDecrease_byPercent.Checked)
                                    { priceAfter = (1 - Convert.ToDecimal(txtIncr_Decr.Text) / 100); }
                                    try
                                    {
                                        var result6 = Math.Round((machItems[x].Current_Price * priceAfter), 4);
                                        this.tblPricingBindingSource.EndEdit();
                                        //     aPricing.UpdatePriceByItemAndCustomer((machItems[x].Current_Price * priceAfter),
                                        aPricing.UpdatePriceByItemAndCustomer(result6,
                                        machItems[x].Current_Price, 0, true, itemNumber, customerNumber);

                                    }
                                    catch
                                    {
                                        MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                    }
                                }
                                //---------------------------------
                                if (rdoIncrease_byFixedNumber.Checked || rdoDecrease_byFixedNumber.Checked)
                                {
                                    if (rdoIncrease_byFixedNumber.Checked)
                                    { priceAfter = (Convert.ToDecimal(numberOfChange)); }
                                    if (rdoDecrease_byFixedNumber.Checked)
                                    { priceAfter = -(Convert.ToDecimal(numberOfChange)); }

                                    try
                                    {
                                        this.tblPricingBindingSource.EndEdit();
                                        aPricing.UpdatePriceByItemAndCustomer((machItems[x].Current_Price + priceAfter),
                                           machItems[x].Current_Price, 0, true, itemNumber, customerNumber);

                                        //  
                                    }
                                    catch
                                    {
                                        MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                                    }
                                }

                            }
                        }
                    }

                }
                //-----------------------------------

                //==========================================================================================
                //=============== rdoChange6 Checked =======================================================
                //==========================================================================================

                if (rdoChange_Price6.Checked)    // Chamge price by Customer By Family
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string familyName = cmbFamily6.SelectedValue.ToString();
                    string CustNumb = cmbCust6.SelectedValue.ToString();

                    var machItems = Db.ExecuteDataTable("Select p.[Customer Number], p.[Current Price], p.[Item Number] from tblPricing as P  left join tblItems as I  on P.[Item Number] = I.[Item Number] where I.[Family] = '{0}' and p.[Customer Number] = '{1}'", cmbFamily6.SelectedValue, cmbCust6.SelectedValue.ToString());

                    machItems.Rows.Count.ToString();  // just for verification

                    for (int x = 0; x < machItems.Rows.Count; x++)
                    {

                        string currPrice = machItems.Rows[x]["Current Price"].ToString();
                        string custNumber = machItems.Rows[x]["Customer Number"].ToString();
                        string itemNumber = machItems.Rows[x]["Item number"].ToString();

                        //-----------------------------------                
                        if (rdoIncrease_byPercent.Checked || rdoDecrease_byPercent.Checked)
                        {
                            if (rdoIncrease_byPercent.Checked)
                            { priceAfter = (1 + Convert.ToDecimal(txtIncr_Decr.Text) / 100); }

                            if (rdoDecrease_byPercent.Checked)
                            { priceAfter = (1 - Convert.ToDecimal(txtIncr_Decr.Text) / 100); }

                            try
                            {
                                decimal result6 = Convert.ToDecimal(currPrice);
                                result6 = result6 * priceAfter;
                                result6 = Math.Round(result6, 4);

                                Db.NonQuery("Update tblPricing Set [Old Price] = [Current Price], [Current price] = '{0}', [IsNew] = true, [New Price] = '{0}'  where [Customer Number] = '{1}' and [Item Number] = '{2}' ", result6, custNumber, itemNumber);

                            }
                            catch
                            {
                                MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                            }
                        }
                        //---------------------------------------------------------------------------------------------------
                        if (rdoIncrease_byFixedNumber.Checked || rdoDecrease_byFixedNumber.Checked)
                        {
                            if (rdoIncrease_byFixedNumber.Checked)
                            { priceAfter = (Convert.ToDecimal(numberOfChange)); }

                            if (rdoDecrease_byFixedNumber.Checked)
                            { priceAfter = -(Convert.ToDecimal(numberOfChange)); }

                            try
                            {
                                decimal result6 = Convert.ToDecimal(currPrice);
                                result6 = result6 + priceAfter;
                                result6 = Math.Round(result6, 4);

                                Db.NonQuery("Update tblPricing Set [Old Price] = [Current Price], [Current price] = '{0}', [IsNew] = true, [New Price] = '{0}'  where [Customer Number] = '{1}' and [Item Number] = '{2}' ", result6, custNumber, itemNumber);

                            }
                            catch
                            {
                                MessageBox.Show("DataBase was not updated. See SysAdmin.", "Info");
                            }
                        }

                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Update Completed.", "Information");
                }
                //-----------------------------------
            }
        }

        //==================================================

        private bool IsValid()
        {
            return
                Validation.IsDecimal(txtIncr_Decr);
        }

        //===============================================


        private void rdoIncrease_byFixedNumber_CheckedChanged_1(object sender, EventArgs e)
        {
            lblSign.Text = "$";

            if (rdoIncrease_byFixedNumber.Checked)
                rdoIncrease_byFixedNumber.Font = new Font(rdoIncrease_byFixedNumber.Font.FontFamily, rdoIncrease_byFixedNumber.Font.Size, FontStyle.Bold);
            else
                rdoIncrease_byFixedNumber.Font = new Font(rdoIncrease_byFixedNumber.Font.FontFamily, rdoIncrease_byFixedNumber.Font.Size, FontStyle.Regular);

        }

        private void rdoDecrease_byFixedNumber_CheckedChanged_1(object sender, EventArgs e)
        {
            lblSign.Text = "$";

            if (rdoDecrease_byFixedNumber.Checked)
                rdoDecrease_byFixedNumber.Font = new Font(rdoDecrease_byFixedNumber.Font.FontFamily, rdoDecrease_byFixedNumber.Font.Size, FontStyle.Bold);
            else
                rdoDecrease_byFixedNumber.Font = new Font(rdoDecrease_byFixedNumber.Font.FontFamily, rdoDecrease_byFixedNumber.Font.Size, FontStyle.Regular);

        }

        private void rdoIncrease_byPercent_CheckedChanged_1(object sender, EventArgs e)
        {
            lblSign.Text = "%";

            if (rdoIncrease_byPercent.Checked)
                rdoIncrease_byPercent.Font = new Font(rdoIncrease_byPercent.Font.FontFamily, rdoIncrease_byPercent.Font.Size, FontStyle.Bold);
            else
                rdoIncrease_byPercent.Font = new Font(rdoIncrease_byPercent.Font.FontFamily, rdoIncrease_byPercent.Font.Size, FontStyle.Regular);

        }

        private void rdoDecrease_byPercent_CheckedChanged(object sender, EventArgs e)
        {
            lblSign.Text = "%";

            if (rdoDecrease_byPercent.Checked)
                rdoDecrease_byPercent.Font = new Font(rdoDecrease_byPercent.Font.FontFamily, rdoDecrease_byPercent.Font.Size, FontStyle.Bold);
            else
                rdoDecrease_byPercent.Font = new Font(rdoDecrease_byPercent.Font.FontFamily, rdoDecrease_byPercent.Font.Size, FontStyle.Regular);

        }

        private void btnCheckAll2_Click_1(object sender, EventArgs e)
        {
            this.CustomGrid.SelectAll();
        }

        private void btnCheckAll1_Click_1(object sender, EventArgs e)
        {
            this.ItemGrid.SelectAll();
        }



    }
}
