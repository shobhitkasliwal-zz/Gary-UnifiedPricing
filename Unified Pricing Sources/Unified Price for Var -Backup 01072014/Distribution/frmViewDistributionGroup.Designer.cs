namespace Unified_Price_for_Var
{
    partial class frmViewDistributionGroup
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
            this.llstBox_Header = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstDistMaster = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrint_Group = new System.Windows.Forms.Button();
            this.btnReconcilidate = new System.Windows.Forms.Button();
            this.btnDelete_Group = new System.Windows.Forms.Button();
            this.btnAdd_NewGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDetail = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNewGroup = new System.Windows.Forms.Panel();
            this.grdNewGroupCustomer = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_Customer_Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelCust = new System.Windows.Forms.Button();
            this.btnSaveCust = new System.Windows.Forms.Button();
            this.btnRemoveCust = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoDecrease = new System.Windows.Forms.RadioButton();
            this.rdoIncrease = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSelectCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbLeadCustomer = new System.Windows.Forms.ComboBox();
            this.btnEditGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            this.pnlNewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNewGroupCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // llstBox_Header
            // 
            this.llstBox_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llstBox_Header.BackColor = System.Drawing.SystemColors.Menu;
            this.llstBox_Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.llstBox_Header.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llstBox_Header.FormattingEnabled = true;
            this.llstBox_Header.ItemHeight = 15;
            this.llstBox_Header.Items.AddRange(new object[] {
            "Creating \"Customer Connections\" allows you to enter a Price into one Customer\'s p" +
                "rice list,  and have that Price lists, at an increased or decreased Price. ",
            "This allows you to maintaine multiple groups of pricing that can be used to quick" +
                "ly price future Customers.  You can enter Price in the Lead Customer\'s ",
            "price list in order to price across the group.  You can still enter Prices into t" +
                "he others Price lists - however those prives won\'t be reflected. "});
            this.llstBox_Header.Location = new System.Drawing.Point(27, 64);
            this.llstBox_Header.Name = "llstBox_Header";
            this.llstBox_Header.Size = new System.Drawing.Size(826, 45);
            this.llstBox_Header.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(211, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstDistMaster
            // 
            this.lstDistMaster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstDistMaster.DisplayMember = "Group Number";
            this.lstDistMaster.FormattingEnabled = true;
            this.lstDistMaster.Location = new System.Drawing.Point(53, 224);
            this.lstDistMaster.Name = "lstDistMaster";
            this.lstDistMaster.Size = new System.Drawing.Size(146, 225);
            this.lstDistMaster.TabIndex = 2;
            this.lstDistMaster.ValueMember = "Group Number";
            this.lstDistMaster.SelectedIndexChanged += new System.EventHandler(this.lstDistMaster_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Notes:     The \"Lead Customer\", ie, the Customer who you enter Price\'s for Group " +
                "",
            " is the Customer listed in RED.  Remember, to add prices to a group of connected",
            "  customers, you have to add the Price to the \"Lead Customer\".   "});
            this.listBox1.Location = new System.Drawing.Point(390, 526);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(402, 39);
            this.listBox1.TabIndex = 4;
            // 
            // btnPrint_Group
            // 
            this.btnPrint_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint_Group.Location = new System.Drawing.Point(211, 356);
            this.btnPrint_Group.Name = "btnPrint_Group";
            this.btnPrint_Group.Size = new System.Drawing.Size(126, 23);
            this.btnPrint_Group.TabIndex = 6;
            this.btnPrint_Group.Text = "Print Group";
            this.btnPrint_Group.UseVisualStyleBackColor = true;
            this.btnPrint_Group.Click += new System.EventHandler(this.btnPrint_Group_Click);
            // 
            // btnReconcilidate
            // 
            this.btnReconcilidate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReconcilidate.Location = new System.Drawing.Point(211, 327);
            this.btnReconcilidate.Name = "btnReconcilidate";
            this.btnReconcilidate.Size = new System.Drawing.Size(126, 23);
            this.btnReconcilidate.TabIndex = 7;
            this.btnReconcilidate.Text = "Reconcilidate";
            this.btnReconcilidate.UseVisualStyleBackColor = true;
            this.btnReconcilidate.Click += new System.EventHandler(this.btnReconcilidate_Click);
            // 
            // btnDelete_Group
            // 
            this.btnDelete_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete_Group.Location = new System.Drawing.Point(211, 285);
            this.btnDelete_Group.Name = "btnDelete_Group";
            this.btnDelete_Group.Size = new System.Drawing.Size(126, 23);
            this.btnDelete_Group.TabIndex = 8;
            this.btnDelete_Group.Text = "Delete Selected Group";
            this.btnDelete_Group.UseVisualStyleBackColor = true;
            this.btnDelete_Group.Click += new System.EventHandler(this.btnDelete_Group_Click);
            // 
            // btnAdd_NewGroup
            // 
            this.btnAdd_NewGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd_NewGroup.Location = new System.Drawing.Point(211, 224);
            this.btnAdd_NewGroup.Name = "btnAdd_NewGroup";
            this.btnAdd_NewGroup.Size = new System.Drawing.Size(126, 23);
            this.btnAdd_NewGroup.TabIndex = 9;
            this.btnAdd_NewGroup.Text = "Add New Group";
            this.btnAdd_NewGroup.UseVisualStyleBackColor = true;
            this.btnAdd_NewGroup.Click += new System.EventHandler(this.btnAdd_NewGroup_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Maintain distribution group ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grdDetail
            // 
            this.grdDetail.AllowUserToAddRows = false;
            this.grdDetail.AllowUserToDeleteRows = false;
            this.grdDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDetail.ColumnHeadersHeight = 20;
            this.grdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Group_Customer_Name,
            this.Modifier,
            this.Percent});
            this.grdDetail.Location = new System.Drawing.Point(386, 224);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.ReadOnly = true;
            this.grdDetail.RowHeadersVisible = false;
            this.grdDetail.Size = new System.Drawing.Size(402, 275);
            this.grdDetail.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Group_Customer_Name
            // 
            this.Group_Customer_Name.HeaderText = "Customer Name";
            this.Group_Customer_Name.Name = "Group_Customer_Name";
            this.Group_Customer_Name.ReadOnly = true;
            this.Group_Customer_Name.Width = 200;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "Percent";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.Location = new System.Drawing.Point(507, 195);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(88, 15);
            this.lblGroupName.TabIndex = 6;
            this.lblGroupName.Text = "Group Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Information about Group: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Grpoup :";
            // 
            // pnlNewGroup
            // 
            this.pnlNewGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNewGroup.Controls.Add(this.grdNewGroupCustomer);
            this.pnlNewGroup.Controls.Add(this.btnSave);
            this.pnlNewGroup.Controls.Add(this.btnCancel);
            this.pnlNewGroup.Controls.Add(this.btnCancelCust);
            this.pnlNewGroup.Controls.Add(this.btnSaveCust);
            this.pnlNewGroup.Controls.Add(this.btnRemoveCust);
            this.pnlNewGroup.Controls.Add(this.btnAddCust);
            this.pnlNewGroup.Controls.Add(this.groupBox2);
            this.pnlNewGroup.Controls.Add(this.label4);
            this.pnlNewGroup.Controls.Add(this.label9);
            this.pnlNewGroup.Controls.Add(this.label10);
            this.pnlNewGroup.Controls.Add(this.txtGroupName);
            this.pnlNewGroup.Controls.Add(this.label11);
            this.pnlNewGroup.Controls.Add(this.cmbLeadCustomer);
            this.pnlNewGroup.Location = new System.Drawing.Point(360, 141);
            this.pnlNewGroup.Name = "pnlNewGroup";
            this.pnlNewGroup.Size = new System.Drawing.Size(510, 500);
            this.pnlNewGroup.TabIndex = 14;
            this.pnlNewGroup.Visible = false;
            // 
            // grdNewGroupCustomer
            // 
            this.grdNewGroupCustomer.AllowUserToAddRows = false;
            this.grdNewGroupCustomer.AllowUserToDeleteRows = false;
            this.grdNewGroupCustomer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdNewGroupCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdNewGroupCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNewGroupCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.Group_Customer_Name2,
            this.Modifier2,
            this.Percent2});
            this.grdNewGroupCustomer.Location = new System.Drawing.Point(9, 158);
            this.grdNewGroupCustomer.MultiSelect = false;
            this.grdNewGroupCustomer.Name = "grdNewGroupCustomer";
            this.grdNewGroupCustomer.ReadOnly = true;
            this.grdNewGroupCustomer.RowHeadersVisible = false;
            this.grdNewGroupCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNewGroupCustomer.Size = new System.Drawing.Size(488, 176);
            this.grdNewGroupCustomer.TabIndex = 24;
            this.grdNewGroupCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNewGroupCustomer_CellContentClick);
            this.grdNewGroupCustomer.SelectionChanged += new System.EventHandler(this.grdNewGroupCustomer_SelectionChanged);
            // 
            // ID2
            // 
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Visible = false;
            // 
            // Group_Customer_Name2
            // 
            this.Group_Customer_Name2.HeaderText = "Customer Name";
            this.Group_Customer_Name2.Name = "Group_Customer_Name2";
            this.Group_Customer_Name2.ReadOnly = true;
            this.Group_Customer_Name2.Width = 270;
            // 
            // Modifier2
            // 
            this.Modifier2.HeaderText = "Modifier";
            this.Modifier2.Name = "Modifier2";
            this.Modifier2.ReadOnly = true;
            // 
            // Percent2
            // 
            this.Percent2.HeaderText = "Percent";
            this.Percent2.Name = "Percent2";
            this.Percent2.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save New Group";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(133, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel New Group";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelCust
            // 
            this.btnCancelCust.Enabled = false;
            this.btnCancelCust.Location = new System.Drawing.Point(294, 340);
            this.btnCancelCust.Name = "btnCancelCust";
            this.btnCancelCust.Size = new System.Drawing.Size(70, 23);
            this.btnCancelCust.TabIndex = 19;
            this.btnCancelCust.Text = "Cancel";
            this.btnCancelCust.UseVisualStyleBackColor = true;
            this.btnCancelCust.Click += new System.EventHandler(this.btnCancelCust_Click);
            // 
            // btnSaveCust
            // 
            this.btnSaveCust.Enabled = false;
            this.btnSaveCust.Location = new System.Drawing.Point(222, 340);
            this.btnSaveCust.Name = "btnSaveCust";
            this.btnSaveCust.Size = new System.Drawing.Size(66, 23);
            this.btnSaveCust.TabIndex = 18;
            this.btnSaveCust.Text = "Save ";
            this.btnSaveCust.UseVisualStyleBackColor = true;
            this.btnSaveCust.Click += new System.EventHandler(this.btnSaveCust_Click);
            // 
            // btnRemoveCust
            // 
            this.btnRemoveCust.Enabled = false;
            this.btnRemoveCust.Location = new System.Drawing.Point(113, 340);
            this.btnRemoveCust.Name = "btnRemoveCust";
            this.btnRemoveCust.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveCust.TabIndex = 16;
            this.btnRemoveCust.Text = "Remove Customer";
            this.btnRemoveCust.UseVisualStyleBackColor = true;
            this.btnRemoveCust.Click += new System.EventHandler(this.btnRemoveCust_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(12, 340);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(95, 23);
            this.btnAddCust.TabIndex = 14;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPercent);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rdoDecrease);
            this.groupBox2.Controls.Add(this.rdoIncrease);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbSelectCustomer);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(8, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 89);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Customer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Use a number such as 7 or 5.5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Percent:";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(96, 60);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(64, 20);
            this.txtPercent.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Modify Prices:";
            // 
            // rdoDecrease
            // 
            this.rdoDecrease.AutoSize = true;
            this.rdoDecrease.Location = new System.Drawing.Point(383, 62);
            this.rdoDecrease.Name = "rdoDecrease";
            this.rdoDecrease.Size = new System.Drawing.Size(71, 17);
            this.rdoDecrease.TabIndex = 3;
            this.rdoDecrease.TabStop = true;
            this.rdoDecrease.Text = "Decrease";
            this.rdoDecrease.UseVisualStyleBackColor = true;
            // 
            // rdoIncrease
            // 
            this.rdoIncrease.AutoSize = true;
            this.rdoIncrease.Location = new System.Drawing.Point(382, 27);
            this.rdoIncrease.Name = "rdoIncrease";
            this.rdoIncrease.Size = new System.Drawing.Size(66, 17);
            this.rdoIncrease.TabIndex = 2;
            this.rdoIncrease.TabStop = true;
            this.rdoIncrease.Text = "Increase";
            this.rdoIncrease.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer:";
            // 
            // cmbSelectCustomer
            // 
            this.cmbSelectCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSelectCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelectCustomer.DisplayMember = "Customer Bill Name";
            this.cmbSelectCustomer.FormattingEnabled = true;
            this.cmbSelectCustomer.Location = new System.Drawing.Point(96, 26);
            this.cmbSelectCustomer.Name = "cmbSelectCustomer";
            this.cmbSelectCustomer.Size = new System.Drawing.Size(193, 21);
            this.cmbSelectCustomer.TabIndex = 0;
            this.cmbSelectCustomer.ValueMember = "Customer Bill Name";
            this.cmbSelectCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbLeadCustomer_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Customer In Group:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lead Customer :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Group Name :";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(98, 67);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(100, 20);
            this.txtGroupName.TabIndex = 10;
            this.txtGroupName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbLeadCustomer_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(431, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Create a New Group of Customer Connection";
            // 
            // cmbLeadCustomer
            // 
            this.cmbLeadCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbLeadCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLeadCustomer.DisplayMember = "Customer Number";
            this.cmbLeadCustomer.FormattingEnabled = true;
            this.cmbLeadCustomer.Location = new System.Drawing.Point(98, 100);
            this.cmbLeadCustomer.Name = "cmbLeadCustomer";
            this.cmbLeadCustomer.Size = new System.Drawing.Size(282, 21);
            this.cmbLeadCustomer.TabIndex = 12;
            this.cmbLeadCustomer.ValueMember = "Customer Number";
            this.cmbLeadCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbLeadCustomer_KeyPress);
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditGroup.Location = new System.Drawing.Point(211, 254);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(126, 23);
            this.btnEditGroup.TabIndex = 15;
            this.btnEditGroup.Text = "Edit";
            this.btnEditGroup.UseVisualStyleBackColor = true;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // frmViewDistributionGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 669);
            this.Controls.Add(this.btnEditGroup);
            this.Controls.Add(this.pnlNewGroup);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd_NewGroup);
            this.Controls.Add(this.btnDelete_Group);
            this.Controls.Add(this.btnReconcilidate);
            this.Controls.Add(this.btnPrint_Group);
            this.Controls.Add(this.lstDistMaster);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.llstBox_Header);
            this.Name = "frmViewDistributionGroup";
            this.Text = "Maintain distribution group ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewDistributionGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            this.pnlNewGroup.ResumeLayout(false);
            this.pnlNewGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNewGroupCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox llstBox_Header;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstDistMaster;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrint_Group;
        private System.Windows.Forms.Button btnReconcilidate;
        private System.Windows.Forms.Button btnDelete_Group;
        private System.Windows.Forms.Button btnAdd_NewGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdDetail;
        private System.Windows.Forms.Panel pnlNewGroup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelCust;
        private System.Windows.Forms.Button btnSaveCust;
        private System.Windows.Forms.Button btnRemoveCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoDecrease;
        private System.Windows.Forms.RadioButton rdoIncrease;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSelectCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbLeadCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdNewGroupCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_Customer_Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modifier2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent2;
		private System.Windows.Forms.Button btnEditGroup;
    }
}