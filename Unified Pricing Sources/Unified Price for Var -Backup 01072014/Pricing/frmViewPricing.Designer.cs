namespace Unified_Price_for_Var
{
    partial class frmViewPricing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label item_NumberLabel;
            System.Windows.Forms.Label current_PriceLabel;
            System.Windows.Forms.Label item_DescriptionLabel;
            System.Windows.Forms.Label customer_Item_NumberLabel;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label12;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPricing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbItemNumb = new System.Windows.Forms.ComboBox();
            this.txtCurrent_Price = new System.Windows.Forms.TextBox();
            this.txtCustomer_Item_Number = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem_description = new System.Windows.Forms.TextBox();
            this.grpPriceInfo = new System.Windows.Forms.GroupBox();
            this.txtStdQTY_Add = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnChange_Price = new System.Windows.Forms.Button();
            this.btnDeletePrice = new System.Windows.Forms.Button();
            this.btnAddPrice = new System.Windows.Forms.Button();
            this.cmbQuick_Check = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarkAsOld = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCheckDuplicate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnChangePrices = new System.Windows.Forms.Button();
            this.btnRollBack = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHidden_CustomerNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpPriceChange = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.gridPrices = new System.Windows.Forms.DataGridView();
            this.lblTotalPricesForCust = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.btnUpdSPQ = new System.Windows.Forms.Button();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last12MonthQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            item_NumberLabel = new System.Windows.Forms.Label();
            current_PriceLabel = new System.Windows.Forms.Label();
            item_DescriptionLabel = new System.Windows.Forms.Label();
            customer_Item_NumberLabel = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            this.grpPriceInfo.SuspendLayout();
            this.grpPriceChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // item_NumberLabel
            // 
            item_NumberLabel.AutoSize = true;
            item_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_NumberLabel.Location = new System.Drawing.Point(17, 32);
            item_NumberLabel.Name = "item_NumberLabel";
            item_NumberLabel.Size = new System.Drawing.Size(82, 15);
            item_NumberLabel.TabIndex = 2;
            item_NumberLabel.Text = "Item Number:";
            // 
            // current_PriceLabel
            // 
            current_PriceLabel.AutoSize = true;
            current_PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            current_PriceLabel.Location = new System.Drawing.Point(143, 32);
            current_PriceLabel.Name = "current_PriceLabel";
            current_PriceLabel.Size = new System.Drawing.Size(81, 15);
            current_PriceLabel.TabIndex = 4;
            current_PriceLabel.Text = "Current Price:";
            // 
            // item_DescriptionLabel
            // 
            item_DescriptionLabel.AutoSize = true;
            item_DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_DescriptionLabel.Location = new System.Drawing.Point(308, 32);
            item_DescriptionLabel.Name = "item_DescriptionLabel";
            item_DescriptionLabel.Size = new System.Drawing.Size(99, 15);
            item_DescriptionLabel.TabIndex = 6;
            item_DescriptionLabel.Text = "Item Description:";
            // 
            // customer_Item_NumberLabel
            // 
            customer_Item_NumberLabel.AutoSize = true;
            customer_Item_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_Item_NumberLabel.Location = new System.Drawing.Point(600, 32);
            customer_Item_NumberLabel.Name = "customer_Item_NumberLabel";
            customer_Item_NumberLabel.Size = new System.Drawing.Size(138, 15);
            customer_Item_NumberLabel.TabIndex = 8;
            customer_Item_NumberLabel.Text = "Customer Item Number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(235, 17);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(54, 30);
            label11.TabIndex = 10;
            label11.Text = "    Std\r\nPak QTY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(18, 23);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 15);
            label6.TabIndex = 5;
            label6.Text = "Item Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(155, 25);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(81, 15);
            label7.TabIndex = 6;
            label7.Text = "Current Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(248, 10);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(54, 30);
            label8.TabIndex = 11;
            label8.Text = "   Std\r\nPac QTY";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(308, 25);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(99, 15);
            label9.TabIndex = 12;
            label9.Text = "Item Description:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(603, 25);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(138, 15);
            label12.TabIndex = 13;
            label12.Text = "Customer Item Number:";
            // 
            // cmbItemNumb
            // 
            this.cmbItemNumb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbItemNumb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemNumb.DisplayMember = "Item Number";
            this.cmbItemNumb.DropDownWidth = 121;
            this.cmbItemNumb.FormattingEnabled = true;
            this.cmbItemNumb.Location = new System.Drawing.Point(17, 51);
            this.cmbItemNumb.Name = "cmbItemNumb";
            this.cmbItemNumb.Size = new System.Drawing.Size(121, 21);
            this.cmbItemNumb.TabIndex = 0;
            this.cmbItemNumb.ValueMember = "Item Number";
            this.cmbItemNumb.SelectedIndexChanged += new System.EventHandler(this.cmbItemNumb_SelectedIndexChanged);
            this.cmbItemNumb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbItemNumb_KeyPress);
            // 
            // txtCurrent_Price
            // 
            this.txtCurrent_Price.Location = new System.Drawing.Point(157, 51);
            this.txtCurrent_Price.MaxLength = 9;
            this.txtCurrent_Price.Name = "txtCurrent_Price";
            this.txtCurrent_Price.Size = new System.Drawing.Size(78, 20);
            this.txtCurrent_Price.TabIndex = 1;
            // 
            // txtCustomer_Item_Number
            // 
            this.txtCustomer_Item_Number.Location = new System.Drawing.Point(597, 51);
            this.txtCustomer_Item_Number.Name = "txtCustomer_Item_Number";
            this.txtCustomer_Item_Number.Size = new System.Drawing.Size(145, 20);
            this.txtCustomer_Item_Number.TabIndex = 11;
            this.txtCustomer_Item_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomer_Item_Number_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(719, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // lstBox1
            // 
            this.lstBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.lstBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.ItemHeight = 15;
            this.lstBox1.Items.AddRange(new object[] {
            "From this list you can change your Pricing list for each Customer/Distribution li" +
                "st. When you \"Change\" or \"Add\" a new price, it will show up bolded in the ",
            "Customer / Distribution  list Price Sheeet.   ",
            "When you are sure they have recieved the Price Sheet, you can remove this effect " +
                "by checking on \"Mark All Prices As Old\".",
            " "});
            this.lstBox1.Location = new System.Drawing.Point(38, 56);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.Size = new System.Drawing.Size(975, 60);
            this.lstBox1.TabIndex = 14;
            this.lstBox1.SelectedIndexChanged += new System.EventHandler(this.lstBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Customer  or Distribution list:";
            // 
            // txtItem_description
            // 
            this.txtItem_description.Location = new System.Drawing.Point(302, 51);
            this.txtItem_description.Name = "txtItem_description";
            this.txtItem_description.ReadOnly = true;
            this.txtItem_description.Size = new System.Drawing.Size(284, 20);
            this.txtItem_description.TabIndex = 9;
            this.txtItem_description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_description_KeyPress);
            // 
            // grpPriceInfo
            // 
            this.grpPriceInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPriceInfo.Controls.Add(this.txtStdQTY_Add);
            this.grpPriceInfo.Controls.Add(label11);
            this.grpPriceInfo.Controls.Add(this.cmbItemNumb);
            this.grpPriceInfo.Controls.Add(item_NumberLabel);
            this.grpPriceInfo.Controls.Add(this.txtItem_description);
            this.grpPriceInfo.Controls.Add(this.txtCurrent_Price);
            this.grpPriceInfo.Controls.Add(current_PriceLabel);
            this.grpPriceInfo.Controls.Add(item_DescriptionLabel);
            this.grpPriceInfo.Controls.Add(this.txtCustomer_Item_Number);
            this.grpPriceInfo.Controls.Add(customer_Item_NumberLabel);
            this.grpPriceInfo.Location = new System.Drawing.Point(38, 472);
            this.grpPriceInfo.Name = "grpPriceInfo";
            this.grpPriceInfo.Size = new System.Drawing.Size(772, 100);
            this.grpPriceInfo.TabIndex = 18;
            this.grpPriceInfo.TabStop = false;
            this.grpPriceInfo.Text = "Price Information";
            this.grpPriceInfo.Visible = false;
            this.grpPriceInfo.Enter += new System.EventHandler(this.grpBox1_Enter);
            // 
            // txtStdQTY_Add
            // 
            this.txtStdQTY_Add.Location = new System.Drawing.Point(241, 51);
            this.txtStdQTY_Add.MaxLength = 5;
            this.txtStdQTY_Add.Name = "txtStdQTY_Add";
            this.txtStdQTY_Add.Size = new System.Drawing.Size(47, 20);
            this.txtStdQTY_Add.TabIndex = 3;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(246, 42);
            this.txtNotes.MaxLength = 5;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(48, 20);
            this.txtNotes.TabIndex = 2;
            // 
            // btnChange_Price
            // 
            this.btnChange_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange_Price.Location = new System.Drawing.Point(181, 580);
            this.btnChange_Price.Name = "btnChange_Price";
            this.btnChange_Price.Size = new System.Drawing.Size(114, 23);
            this.btnChange_Price.TabIndex = 19;
            this.btnChange_Price.Text = "Change price";
            this.btnChange_Price.UseVisualStyleBackColor = true;
            this.btnChange_Price.Click += new System.EventHandler(this.txtChange_Price_Click);
            // 
            // btnDeletePrice
            // 
            this.btnDeletePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePrice.Location = new System.Drawing.Point(463, 580);
            this.btnDeletePrice.Name = "btnDeletePrice";
            this.btnDeletePrice.Size = new System.Drawing.Size(117, 23);
            this.btnDeletePrice.TabIndex = 20;
            this.btnDeletePrice.Text = "Delete Price(s)";
            this.btnDeletePrice.UseVisualStyleBackColor = true;
            this.btnDeletePrice.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrice.Location = new System.Drawing.Point(69, 580);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(103, 23);
            this.btnAddPrice.TabIndex = 21;
            this.btnAddPrice.Text = "Add Price";
            this.btnAddPrice.UseVisualStyleBackColor = true;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // cmbQuick_Check
            // 
            this.cmbQuick_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbQuick_Check.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbQuick_Check.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbQuick_Check.DisplayMember = "Item Number";
            this.cmbQuick_Check.FormattingEnabled = true;
            this.cmbQuick_Check.Location = new System.Drawing.Point(819, 194);
            this.cmbQuick_Check.Name = "cmbQuick_Check";
            this.cmbQuick_Check.Size = new System.Drawing.Size(146, 21);
            this.cmbQuick_Check.TabIndex = 22;
            this.cmbQuick_Check.ValueMember = "Item Number";
            this.cmbQuick_Check.SelectedIndexChanged += new System.EventHandler(this.cmbQuick_Check_SelectedIndexChanged);
            this.cmbQuick_Check.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbQuick_Check_KeyPress);
            this.cmbQuick_Check.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbQuick_Check_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(816, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 84);
            this.label2.TabIndex = 23;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnMarkAsOld
            // 
            this.btnMarkAsOld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMarkAsOld.Location = new System.Drawing.Point(835, 347);
            this.btnMarkAsOld.Name = "btnMarkAsOld";
            this.btnMarkAsOld.Size = new System.Drawing.Size(130, 23);
            this.btnMarkAsOld.TabIndex = 24;
            this.btnMarkAsOld.Text = "Mark All Prices As Old";
            this.btnMarkAsOld.UseVisualStyleBackColor = true;
            this.btnMarkAsOld.Click += new System.EventHandler(this.btnMarkAsOld_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopy.Location = new System.Drawing.Point(835, 377);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(130, 23);
            this.btnCopy.TabIndex = 25;
            this.btnCopy.Text = "Copy Prices";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCheckDuplicate
            // 
            this.btnCheckDuplicate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckDuplicate.Location = new System.Drawing.Point(835, 408);
            this.btnCheckDuplicate.Name = "btnCheckDuplicate";
            this.btnCheckDuplicate.Size = new System.Drawing.Size(130, 23);
            this.btnCheckDuplicate.TabIndex = 26;
            this.btnCheckDuplicate.Text = "Check for duplicates";
            this.btnCheckDuplicate.UseVisualStyleBackColor = true;
            this.btnCheckDuplicate.Click += new System.EventHandler(this.btnCheckDuplicate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.Location = new System.Drawing.Point(835, 440);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 23);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Print Price List";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnChangePrices
            // 
            this.btnChangePrices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePrices.Location = new System.Drawing.Point(835, 472);
            this.btnChangePrices.Name = "btnChangePrices";
            this.btnChangePrices.Size = new System.Drawing.Size(130, 23);
            this.btnChangePrices.TabIndex = 28;
            this.btnChangePrices.TabStop = false;
            this.btnChangePrices.Text = "T / R Price List";
            this.btnChangePrices.UseVisualStyleBackColor = true;
            this.btnChangePrices.Click += new System.EventHandler(this.btnChangePrices_Click);
            // 
            // btnRollBack
            // 
            this.btnRollBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRollBack.Location = new System.Drawing.Point(835, 505);
            this.btnRollBack.Name = "btnRollBack";
            this.btnRollBack.Size = new System.Drawing.Size(130, 23);
            this.btnRollBack.TabIndex = 29;
            this.btnRollBack.Text = "Roll Back Session Prices";
            this.btnRollBack.UseVisualStyleBackColor = true;
            this.btnRollBack.Click += new System.EventHandler(this.btnRollBack_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmail.Location = new System.Drawing.Point(835, 538);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(130, 23);
            this.btnEmail.TabIndex = 30;
            this.btnEmail.Text = "Export for Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(816, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Price Quickfinder:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Item Price Information";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Item Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Current Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Current Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Here is the list of Items for selected Customer or Distribution list:";
            // 
            // lblHidden_CustomerNumber
            // 
            this.lblHidden_CustomerNumber.AutoSize = true;
            this.lblHidden_CustomerNumber.Location = new System.Drawing.Point(25, 15);
            this.lblHidden_CustomerNumber.Name = "lblHidden_CustomerNumber";
            this.lblHidden_CustomerNumber.Size = new System.Drawing.Size(0, 13);
            this.lblHidden_CustomerNumber.TabIndex = 38;
            this.lblHidden_CustomerNumber.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(586, 580);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 23);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpPriceChange
            // 
            this.grpPriceChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPriceChange.Controls.Add(this.txtNotes);
            this.grpPriceChange.Controls.Add(label12);
            this.grpPriceChange.Controls.Add(label9);
            this.grpPriceChange.Controls.Add(label8);
            this.grpPriceChange.Controls.Add(label7);
            this.grpPriceChange.Controls.Add(label6);
            this.grpPriceChange.Controls.Add(this.textBox4);
            this.grpPriceChange.Controls.Add(this.textBox3);
            this.grpPriceChange.Controls.Add(this.textBox2);
            this.grpPriceChange.Controls.Add(this.textBox1);
            this.grpPriceChange.Location = new System.Drawing.Point(38, 472);
            this.grpPriceChange.Name = "grpPriceChange";
            this.grpPriceChange.Size = new System.Drawing.Size(755, 73);
            this.grpPriceChange.TabIndex = 40;
            this.grpPriceChange.TabStop = false;
            this.grpPriceChange.Text = "Price Change";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(599, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(304, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(284, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(38, 146);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(403, 21);
            this.cmbCustomers.TabIndex = 41;
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbCustomers_SelectedIndexChanged);
            this.cmbCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbQuick_Check_KeyPress);
            // 
            // gridPrices
            // 
            this.gridPrices.AllowUserToAddRows = false;
            this.gridPrices.AllowUserToDeleteRows = false;
            this.gridPrices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPrices.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumber,
            this.CurrentPrice,
            this.PreviousPrice,
            this.ItemDescription,
            this.Notes,
            this.CustomerItemNumber,
            this.Last12MonthQTY,
            this.QuoteDate,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPrices.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPrices.Location = new System.Drawing.Point(38, 194);
            this.gridPrices.Name = "gridPrices";
            this.gridPrices.ReadOnly = true;
            this.gridPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrices.Size = new System.Drawing.Size(772, 264);
            this.gridPrices.TabIndex = 42;
            this.gridPrices.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrices_CellEnter);
            // 
            // lblTotalPricesForCust
            // 
            this.lblTotalPricesForCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPricesForCust.AutoSize = true;
            this.lblTotalPricesForCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalPricesForCust.Location = new System.Drawing.Point(719, 175);
            this.lblTotalPricesForCust.Name = "lblTotalPricesForCust";
            this.lblTotalPricesForCust.Size = new System.Drawing.Size(60, 16);
            this.lblTotalPricesForCust.TabIndex = 43;
            this.lblTotalPricesForCust.Text = "Total: 0";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(835, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "You are viewing prices for :";
            // 
            // lbl11
            // 
            this.lbl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(460, 147);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(195, 16);
            this.lbl11.TabIndex = 48;
            this.lbl11.Text = "You are viewing prices for :";
            // 
            // btnUpdSPQ
            // 
            this.btnUpdSPQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdSPQ.Location = new System.Drawing.Point(303, 580);
            this.btnUpdSPQ.Name = "btnUpdSPQ";
            this.btnUpdSPQ.Size = new System.Drawing.Size(151, 23);
            this.btnUpdSPQ.TabIndex = 49;
            this.btnUpdSPQ.Text = "Update Std Pak QTY (Only)";
            this.btnUpdSPQ.UseVisualStyleBackColor = true;
            this.btnUpdSPQ.Click += new System.EventHandler(this.btnUpdSPQ_Click);
            // 
            // ItemNumber
            // 
            this.ItemNumber.DataPropertyName = "Item Number";
            this.ItemNumber.HeaderText = "Item Number";
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.ReadOnly = true;
            // 
            // CurrentPrice
            // 
            this.CurrentPrice.HeaderText = "Current Price";
            this.CurrentPrice.Name = "CurrentPrice";
            this.CurrentPrice.ReadOnly = true;
            this.CurrentPrice.Width = 70;
            // 
            // PreviousPrice
            // 
            this.PreviousPrice.HeaderText = "Previous Price";
            this.PreviousPrice.Name = "PreviousPrice";
            this.PreviousPrice.ReadOnly = true;
            this.PreviousPrice.Width = 70;
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            this.ItemDescription.Width = 350;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Std Pak QTY";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 40;
            // 
            // CustomerItemNumber
            // 
            this.CustomerItemNumber.HeaderText = "Customer Item Number";
            this.CustomerItemNumber.Name = "CustomerItemNumber";
            this.CustomerItemNumber.ReadOnly = true;
            // 
            // Last12MonthQTY
            // 
            this.Last12MonthQTY.HeaderText = "Last 12mo QTY Sold";
            this.Last12MonthQTY.Name = "Last12MonthQTY";
            this.Last12MonthQTY.ReadOnly = true;
            // 
            // QuoteDate
            // 
            this.QuoteDate.HeaderText = "Quote Date";
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // frmViewPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 618);
            this.Controls.Add(this.btnUpdSPQ);
            this.Controls.Add(this.grpPriceInfo);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotalPricesForCust);
            this.Controls.Add(this.gridPrices);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpPriceChange);
            this.Controls.Add(this.lblHidden_CustomerNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnRollBack);
            this.Controls.Add(this.btnChangePrices);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCheckDuplicate);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMarkAsOld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbQuick_Check);
            this.Controls.Add(this.btnAddPrice);
            this.Controls.Add(this.btnDeletePrice);
            this.Controls.Add(this.btnChange_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBox1);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmViewPricing";
            this.Text = "View Pricing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewPricing_Load);
            this.grpPriceInfo.ResumeLayout(false);
            this.grpPriceInfo.PerformLayout();
            this.grpPriceChange.ResumeLayout(false);
            this.grpPriceChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrent_Price;
        private System.Windows.Forms.TextBox txtCustomer_Item_Number;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem_description;
        private System.Windows.Forms.GroupBox grpPriceInfo;
        private System.Windows.Forms.Button btnChange_Price;
        private System.Windows.Forms.Button btnDeletePrice;
        private System.Windows.Forms.Button btnAddPrice;
        private System.Windows.Forms.ComboBox cmbQuick_Check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMarkAsOld;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCheckDuplicate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnChangePrices;
        private System.Windows.Forms.Button btnRollBack;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHidden_CustomerNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpPriceChange;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.DataGridView gridPrices;
        private System.Windows.Forms.Label lblTotalPricesForCust;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbItemNumb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtStdQTY_Add;
        private System.Windows.Forms.Button btnUpdSPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last12MonthQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}