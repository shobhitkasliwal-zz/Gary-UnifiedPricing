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
    public partial class frmViewCustomer : Form
    {
        public frmViewCustomer()
        {
            InitializeComponent();

        }

        private void frmViewCustomer_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'pricing_for_Tanya_DataSet.tblCustomers' table. You can move, or remove it, as needed.
            this.tblCustomersTableAdapter.qryCustomerCombinedName(this.pricing_for_Tanya_DataSet.tblCustomers);
            cmbCustomers.DisplayMember = "Combinet Name";
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            txtViewSwing_Number.Visible = true;
            cmbSwing.Visible = false;

        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load SWING combo box
            //       var dataTable1 = Db.ExecuteDataTable("Select [Swing Number],[Swing Name] From tblSwingNumbers"); 
            //        cmbSwing.DataSource = dataTable1;           
            //        cmbSwing.DisplayMember = "Swing Number";        
            //        cmbSwing.ValueMember = "Swing Number";      
            //        cmbSwing.Visible = false;                    
            //        int index = cmbSwing.FindString(txtViewSwing_Number.Text);
            //        cmbSwing.SelectedIndex = index;    

        }

        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            //Load SWING combo box
            //        var dataTable1 = Db.ExecuteDataTable("Select [Swing Number],[Swing Name] From tblSwingNumbers"); 
            //        cmbSwing.DataSource = dataTable1;           
            //        cmbSwing.DisplayMember = "Swing Number";
            //        cmbSwing.ValueMember = "Swing Number";      
            //        cmbSwing.Visible = false;
            //        int index = cmbSwing.FindString(txtViewSwing_Number.Text);
            //        cmbSwing.SelectedIndex = index;   

            btnUpdate.Visible = true;
            btnAddCustomer.Visible = false;
            btnDelCustomer.Visible = false;
            btnModifyCustomer.Visible = false;
            btnAdd.Visible = false;

            txtViewbill_Address_1.ReadOnly = false;
            txtViewBill_Address_2.ReadOnly = false;
            txtViewBill_City.ReadOnly = false;
            txtViewBill_Country.ReadOnly = false;
            txtViewBill_State.ReadOnly = false;
            txtViewBill_Zip.ReadOnly = false;
            txtViewContact_Person.ReadOnly = false;
            txtViewCustomer_Bill_Name.ReadOnly = false;
            txtViewCustomer_Credit_Limit.ReadOnly = false;
            //   txtViewCustomer_Number.ReadOnly = false;
            txtViewCustomer_Ship_Name.ReadOnly = false;
            txtViewDays_Due.ReadOnly = false;
            txtViewDiscount_Days_Due.ReadOnly = false;
            txtViewDiscount_Percent.ReadOnly = false;
            txtViewEmail_Address.ReadOnly = false;
            txtViewFax_Number.ReadOnly = false;
            txtViewPhone_Number.ReadOnly = false;
            txtViewShip_Address_1.ReadOnly = false;
            txtViewShip_Address_2.ReadOnly = false;
            txtViewShip_City.ReadOnly = false;
            txtViewShip_Country.ReadOnly = false;
            txtViewShip_State.ReadOnly = false;
            txtViewShip_Zip.ReadOnly = false;
            txtViewSwing_Number.ReadOnly = false;
            txtViewSwing_Number.Visible = true;

            txtViewTerritory.ReadOnly = false;
            txtFreight.ReadOnly = false;
            txtMinPerLine.ReadOnly = false;
            txtMinPerOrder.ReadOnly = false;
            txtMinPerLine1.ReadOnly = false;
            txtMinPerOrder1.ReadOnly = false;
            txtViewContact_Person.Focus();
            //  btnExit.Location = new Point(782,341);
            btnUpdate.Location = new Point(675, 385);
        }

        //-----------------------------------------------
        //     Press button ADD Customer
        //-----------------------------------------------
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Loading SWING combo box
            var dataTable1 = Db.ExecuteDataTable("Select [Swing Number],[Swing Name] From tblSwingNumbers");
            cmbSwing.DataSource = dataTable1;
            cmbSwing.DisplayMember = "Swing Number";
            cmbSwing.ValueMember = "Swing Number";
            cmbSwing.Visible = true;

            txtViewDays_Due.Text = "0";
            txtViewDiscount_Days_Due.Text = "0";
            txtViewDiscount_Percent.Text = "0";
            txtViewCustomer_Credit_Limit.Text = "0";
            txtViewBill_Zip.Text = "0";
            txtViewShip_Zip.Text = "0";
            txtMinPerLine.Text = " ";
            txtMinPerOrder.Text = " ";
            txtMinPerLine1.Text = " ";
            txtMinPerOrder1.Text = " ";

            cmbCustomers.Visible = false;
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnAddCustomer.Visible = false;
            btnDelCustomer.Visible = false;
            btnModifyCustomer.Visible = false;

            label1.Text = "Add New Customer Information";
            lbl2.Visible = false;

            txtViewbill_Address_1.ReadOnly = false;
            txtViewBill_Address_2.ReadOnly = false;
            txtViewBill_City.ReadOnly = false;
            txtViewBill_Country.ReadOnly = false;
            txtViewBill_State.ReadOnly = false;
            txtViewBill_Zip.ReadOnly = false;
            txtViewContact_Person.ReadOnly = false;
            txtViewCustomer_Bill_Name.ReadOnly = false;
            txtViewCustomer_Credit_Limit.ReadOnly = false;
            txtViewCustomer_Number.ReadOnly = false;
            txtViewCustomer_Ship_Name.ReadOnly = false;
            txtViewDays_Due.ReadOnly = false;
            txtViewDiscount_Days_Due.ReadOnly = false;
            txtViewDiscount_Percent.ReadOnly = false;
            txtViewEmail_Address.ReadOnly = false;
            txtViewFax_Number.ReadOnly = false;
            txtViewPhone_Number.ReadOnly = false;
            txtViewShip_Address_1.ReadOnly = false;
            txtViewShip_Address_2.ReadOnly = false;
            txtViewShip_City.ReadOnly = false;
            txtViewShip_Country.ReadOnly = false;
            txtViewShip_State.ReadOnly = false;
            txtViewShip_Zip.ReadOnly = false;
            txtViewTerritory.ReadOnly = false;
            txtFreight.ReadOnly = false;
            txtMinPerLine.ReadOnly = false;
            txtMinPerOrder.ReadOnly = false;
            txtMinPerLine1.ReadOnly = false;
            txtMinPerOrder1.ReadOnly = false;
            ClearControls();

            txtViewCustomer_Number.Focus();
            btnAdd.Location = new Point(675, 385);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //----------------------------------------
        //----  Button DELETE CUSTOMER
        //----------------------------------------

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are going to delete customer " +
           cmbCustomers.SelectedValue.ToString() + ". Please, comfirm delete process. ", "Important", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    this.tblCustomersBindingSource.EndEdit();
                    this.tblCustomersTableAdapter.qryDeleteCustomer(cmbCustomers.SelectedValue.ToString());
                    MessageBox.Show("Customer Number " + cmbCustomers.SelectedValue.ToString() + " deleted.", "Information");
                    RefreshDataset();
                }
                catch
                {
                    MessageBox.Show("Customer Number " + cmbCustomers.SelectedValue.ToString() + " NOT deleted.", "Information");
                }
            }
        }

        //-------------------------------------
        //     Refresh table Customers
        //--------------------------------------
        private void RefreshDataset()
        {
            this.tblCustomersTableAdapter.qryCustomerCombinedName(this.pricing_for_Tanya_DataSet.tblCustomers);
            cmbCustomers.DisplayMember = "Combinet Name";
        }

        //------------------------------------
        //     Validation routine
        //------------------------------------
        private bool IsValid()
        {
            return
                Validation.IsPresent(txtViewCustomer_Number) &&
                //       Validation.IsPresent(txtViewContact_Person) &&
                //       Validation.IsPresent(txtViewCustomer_Bill_Name) &&
                Validation.IsWithinRange(txtViewDays_Due, 0, 32000) &&
                Validation.IsWithinRange(txtViewDiscount_Days_Due, 0, 32000) &&
                Validation.IsInt16(txtViewDays_Due) &&
                Validation.IsInt16(txtViewDiscount_Days_Due) &&
                Validation.IsInt32(txtViewDiscount_Percent) &&
                Validation.IsValidEmail(txtViewEmail_Address);

        }

        //----------------------------
        // Update table tblCustomers
        //----------------------------

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //       if ( txtMinPerLine.Text  == "")
            //       {
            //           MessageBox.Show("Min Per Line has to be number.");
            //           return;
            //       }

            //       if (txtMinPerOrder.Text == "")
            //       {
            //           MessageBox.Show("Min Per Order has to be number.");
            //           return;
            //       }

            try
            {
                if (this.IsValid())
                {

                    //                Db.NonQuery("Update tblCustomers SET [Customer Number] = '{0}',[Customer Bill Name] = '{1}', [Bill Address 1]= '{2}', [Bill Address 2] = '{3}', [Bill City] = '{4}',  [Bill State] = '{5}', [Bill Zip] = '{6}', [Bill Country] = '{7}', [Customer Ship Name] = '{8}', [Ship Address 1] = '{9}', [Ship Address 2] = '{10}', [Ship City] = '{11}', [Ship State]= '{12}', [Ship Zip] = '{13}', [Ship Country]= '{14}', [Days Due] = '{15}', [Discount Days Due] = '{16}', [Discount Percent] = '{17}', [Phone Number] = '{18}', [Fax Number] = '{19}', [Contact Person] = '{20}', [Email Address] = '{21}', [Territory] = '{22}', [Freight Terms] = '{23}', [Min Per Line] = '{24}', [Min Per Order] = '{25}', [Swing Number] = '{26}', [Customer Credit Limit] = '{27}' where [Customer Number] = '{28}'",
                    //                   txtViewCustomer_Number.Text, txtViewCustomer_Bill_Name.Text, txtViewbill_Address_1.Text, txtViewBill_Address_2.Text, txtViewBill_City.Text, txtViewBill_State.Text, txtViewBill_Zip.Text, txtViewBill_Country.Text, txtViewCustomer_Ship_Name.Text, txtViewShip_Address_1.Text, txtViewShip_Address_2.Text, txtViewShip_City.Text, txtViewShip_State.Text, txtViewShip_Zip.Text, txtViewShip_Country.Text, Convert.ToInt16(txtViewDays_Due.Text), Convert.ToInt16(txtViewDiscount_Days_Due.Text), Convert.ToInt32(txtViewDiscount_Percent.Text), txtViewPhone_Number.Text, txtViewFax_Number.Text, txtViewContact_Person.Text, txtViewEmail_Address.Text, txtViewTerritory.Text, txtFreight.Text, txtMinPerLine.Text, txtMinPerOrder.Text, txtViewSwing_Number.Text, txtViewCustomer_Credit_Limit.Text, cmbCustomers.SelectedValue.ToString());

                    string CustBillName = txtViewCustomer_Bill_Name.Text.Replace("'", "''");
                    string CustShipName = txtViewCustomer_Ship_Name.Text.Replace("'", "''");

                    Db.NonQuery("Update tblCustomers SET [Customer Number] = '{0}',[Customer Bill Name] = '{1}', [Bill Address 1]= '{2}', [Bill Address 2] = '{3}', [Bill City] = '{4}',  [Bill State] = '{5}', [Bill Zip] = '{6}', [Bill Country] = '{7}', [Customer Ship Name] = '{8}', [Ship Address 1] = '{9}', [Ship Address 2] = '{10}', [Ship City] = '{11}', [Ship State]= '{12}', [Ship Zip] = '{13}', [Ship Country]= '{14}', [Days Due] = '{15}', [Discount Days Due] = '{16}', [Discount Percent] = '{17}', [Phone Number] = '{18}', [Fax Number] = '{19}', [Contact Person] = '{20}', [Email Address] = '{21}', [Territory] = '{22}', [Freight Terms] = '{23}', [Min Per Line] = '{24}', [Min Per Order] = '{25}', [Min Per Line1] = '{26}', [Min Per Order1] = '{27}', [Swing Number] = '{28}', [Customer Credit Limit] = '{29}' where [Customer Number] = '{30}'",
                                    txtViewCustomer_Number.Text, CustBillName, txtViewbill_Address_1.Text, txtViewBill_Address_2.Text, txtViewBill_City.Text, txtViewBill_State.Text, txtViewBill_Zip.Text, txtViewBill_Country.Text, CustShipName, txtViewShip_Address_1.Text, txtViewShip_Address_2.Text, txtViewShip_City.Text, txtViewShip_State.Text, txtViewShip_Zip.Text, txtViewShip_Country.Text, Convert.ToInt16(txtViewDays_Due.Text), Convert.ToInt16(txtViewDiscount_Days_Due.Text), Convert.ToInt32(txtViewDiscount_Percent.Text), txtViewPhone_Number.Text, txtViewFax_Number.Text, txtViewContact_Person.Text, txtViewEmail_Address.Text, txtViewTerritory.Text, txtFreight.Text, txtMinPerLine.Text, txtMinPerOrder.Text, txtMinPerLine1.Text, txtMinPerOrder1.Text, txtViewSwing_Number.Text, txtViewCustomer_Credit_Limit.Text, cmbCustomers.SelectedValue.ToString());


                    //                 this.tblCustomersBindingSource.EndEdit();
                    //                 this.tblCustomersTableAdapter.Update(this.pricing_for_Tanya_DataSet.tblCustomers);

                    MessageBox.Show("Customer " + txtViewCustomer_Number.Text + " information changed.", "Good News");

                    ClearControls();
                    RefreshDataset();
                    ReadOnlyTrue();

                    label1.Text = "Customer Information screen";
                    cmbCustomers.Visible = true;
                    btnAdd.Visible = false;
                    btnUpdate.Visible = false;
                    btnAddCustomer.Visible = true;
                    btnDelCustomer.Visible = true;
                    btnModifyCustomer.Visible = true;
                    btnExit.Location = new Point(790, 385);

                    //            this.pricing_for_Tanya_DataSet.AcceptChanges();
                    txtViewSwing_Number.Visible = true;
                    cmbSwing.Visible = false;

                }
            }
            catch
            {
                MessageBox.Show("Update failed.", "Error");
            }
        }


        //                  


        //---------------------------------------------------------------------------------------------
        //      Add NEW customer       
        //--------------------------------------------------------------------------------------------- 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            short strWhoEntered = 4;
            decimal DecPoints = 4;
            short Territory = 4;
            try
            {
                if (this.IsValid())
                {

                    txtViewSwing_Number.Text = cmbSwing.SelectedValue.ToString();

                    this.tblCustomersBindingSource.EndEdit();
                    tblCustomersTableAdapter.qryAddCustomer(

                    txtViewCustomer_Number.Text,
                    txtViewCustomer_Bill_Name.Text,
                    txtViewbill_Address_1.Text,
                    txtViewBill_Address_2.Text,
                    txtViewBill_City.Text,
                    txtViewBill_State.Text,
                    txtViewBill_Zip.Text,
                    txtViewBill_Country.Text,
                    txtViewCustomer_Ship_Name.Text,
                    txtViewShip_Address_1.Text,
                    txtViewShip_Address_2.Text,
                    txtViewShip_City.Text,
                    txtViewShip_State.Text,
                    txtViewShip_Zip.Text,
                    txtViewShip_Country.Text,
                    Convert.ToInt16(txtViewDays_Due.Text),               // Days Due
                    Convert.ToInt16(txtViewDiscount_Days_Due.Text),      //Disount Days
                    Convert.ToInt32(txtViewDiscount_Percent.Text),       //Discount Procent

                    txtViewPhone_Number.Text,
                    txtViewFax_Number.Text,
                    txtViewContact_Person.Text,
                    txtViewEmail_Address.Text,
                    txtViewSwing_Number.Text,
                        //                 cmbSwing.SelectedValue.ToString(),               
                    txtViewCustomer_Credit_Limit.Text,
                    strWhoEntered,             //   Not in form
                    DecPoints,                 //   Not in form
                    Territory,
                    txtFreight.Text,
                    txtMinPerLine.Text,
                    txtMinPerOrder.Text,
                    txtMinPerLine1.Text,
                    txtMinPerOrder1.Text);


                    MessageBox.Show("Customer Number " + txtViewCustomer_Number.Text + " information added.", "Good News");
                    ClearControls();
                    RefreshDataset();
                    txtViewSwing_Number.Visible = true;
                    cmbSwing.Visible = false;

                    ReadOnlyTrue();
                    label1.Text = "Customer Information screen";
                    cmbCustomers.Visible = true;
                    btnAdd.Visible = false;
                    btnAddCustomer.Visible = true;
                    btnDelCustomer.Visible = true;
                    btnModifyCustomer.Visible = true;
                    btnExit.Location = new Point(790, 385);
                }
            }
            catch
            {
                MessageBox.Show("Customer Number " + txtViewCustomer_Number.Text + " NOT added.Customer number already exists.", "Error");
            }
        }
        //-------------------------------------------------------------------------
        private void ClearControls()
        {
            txtViewContact_Person.Text = "";
            txtViewCustomer_Credit_Limit.Text = "0";
            txtViewCustomer_Number.Text = "";
            txtViewDays_Due.Text = "0";
            txtViewDiscount_Days_Due.Text = "0";
            txtViewDiscount_Percent.Text = "0";
            txtViewEmail_Address.Text = "";
            txtViewFax_Number.Text = "";
            txtViewPhone_Number.Text = "";
            txtViewSwing_Number.Text = "";
            txtViewTerritory.Text = "0";
            txtViewShip_Address_1.Text = "";
            txtViewShip_Address_2.Text = "";
            txtViewShip_City.Text = "";
            txtViewShip_Country.Text = "";
            txtViewShip_State.Text = "";
            txtViewShip_Zip.Text = "";
            txtViewbill_Address_1.Text = "";
            txtViewBill_Address_2.Text = "";
            txtViewBill_City.Text = "";
            txtViewBill_Country.Text = "";
            txtViewBill_State.Text = "";
            txtViewBill_Zip.Text = "";
            txtViewCustomer_Bill_Name.Text = "";
            txtViewCustomer_Ship_Name.Text = "";
            txtFreight.Text = " ";
            //    txtMinPerLine.Text = "0";
            //    txtMinPerOrder.Text = "0";
        }

        private void ReadOnlyTrue()
        {
            txtViewbill_Address_1.ReadOnly = true;
            txtViewBill_Address_2.ReadOnly = true;
            txtViewBill_City.ReadOnly = true;
            txtViewBill_Country.ReadOnly = true;
            txtViewBill_State.ReadOnly = true;
            txtViewBill_Zip.ReadOnly = true;
            txtViewContact_Person.ReadOnly = true;
            txtViewCustomer_Bill_Name.ReadOnly = true;
            txtViewCustomer_Credit_Limit.ReadOnly = true;
            txtViewCustomer_Number.ReadOnly = true;
            txtViewCustomer_Ship_Name.ReadOnly = true;
            txtViewDays_Due.ReadOnly = true;
            txtViewDiscount_Days_Due.ReadOnly = true;
            txtViewDiscount_Percent.ReadOnly = true;
            txtViewEmail_Address.ReadOnly = true;
            txtViewFax_Number.ReadOnly = true;
            txtViewPhone_Number.ReadOnly = true;
            txtViewShip_Address_1.ReadOnly = true;
            txtViewShip_Address_2.ReadOnly = true;
            txtViewShip_City.ReadOnly = true;
            txtViewShip_Country.ReadOnly = true;
            txtViewShip_State.ReadOnly = true;
            txtViewShip_Zip.ReadOnly = true;
            txtViewSwing_Number.ReadOnly = true;
            txtViewTerritory.ReadOnly = true;
            txtFreight.ReadOnly = true;
            txtMinPerLine.ReadOnly = true;
            txtMinPerOrder.ReadOnly = true;
            txtMinPerLine1.ReadOnly = true;
            txtMinPerOrder1.ReadOnly = true;
        }
        private void cmbCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

    }
}
