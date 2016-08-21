namespace Unified_Price_for_Var
{
    partial class frmViewSwing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewSwing));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSwingNumber = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.grdAvilableCust = new System.Windows.Forms.DataGridView();
            this.CustNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCustInSwing = new System.Windows.Forms.DataGridView();
            this.CustNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCombine = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.Label = new System.Windows.Forms.Label();
            this.cmbSwing2 = new System.Windows.Forms.ComboBox();
            this.cmbSwing1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewSwingNumber = new System.Windows.Forms.TextBox();
            this.btnCancelNew = new System.Windows.Forms.Button();
            this.btnCreateSwing = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.ddl_CN_Manager1 = new System.Windows.Forms.ComboBox();
            this.ddl_CN_Manager4 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ddl_CN_Manager3 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ddl_CN_Manager2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ddlManager1 = new System.Windows.Forms.ComboBox();
            this.ddlManager2 = new System.Windows.Forms.ComboBox();
            this.ddlManager3 = new System.Windows.Forms.ComboBox();
            this.ddlManager4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSaveManagers = new System.Windows.Forms.Button();
            this.lnkSelectAllAvailableCustomers = new System.Windows.Forms.LinkLabel();
            this.lnkSelectAllCustInSwing = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvilableCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustInSwing)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Swing Number Management ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Swing Number";
            // 
            // cmbSwingNumber
            // 
            this.cmbSwingNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSwingNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSwingNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSwingNumber.DisplayMember = "Swing Number";
            this.cmbSwingNumber.FormattingEnabled = true;
            this.cmbSwingNumber.Location = new System.Drawing.Point(40, 108);
            this.cmbSwingNumber.Name = "cmbSwingNumber";
            this.cmbSwingNumber.Size = new System.Drawing.Size(125, 21);
            this.cmbSwingNumber.TabIndex = 2;
            this.cmbSwingNumber.ValueMember = "Swing Number";
            this.cmbSwingNumber.SelectedIndexChanged += new System.EventHandler(this.cmbSwingNumber_SelectedIndexChanged);
            this.cmbSwingNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSwingNumber_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(427, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add >";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(427, 323);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "< Remove ";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Location = new System.Drawing.Point(427, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(427, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(39, 145);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create New...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(126, 145);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(115, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Delete Selected Swing";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(884, 52);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // grdAvilableCust
            // 
            this.grdAvilableCust.AllowUserToAddRows = false;
            this.grdAvilableCust.AllowUserToDeleteRows = false;
            this.grdAvilableCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdAvilableCust.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdAvilableCust.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdAvilableCust.ColumnHeadersHeight = 20;
            this.grdAvilableCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAvilableCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustNumber,
            this.CustName});
            this.grdAvilableCust.Location = new System.Drawing.Point(34, 276);
            this.grdAvilableCust.Name = "grdAvilableCust";
            this.grdAvilableCust.ReadOnly = true;
            this.grdAvilableCust.RowHeadersVisible = false;
            this.grdAvilableCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAvilableCust.Size = new System.Drawing.Size(377, 238);
            this.grdAvilableCust.TabIndex = 13;
            // 
            // CustNumber
            // 
            this.CustNumber.HeaderText = "Customer #";
            this.CustNumber.Name = "CustNumber";
            this.CustNumber.ReadOnly = true;
            // 
            // CustName
            // 
            this.CustName.HeaderText = "Customer Name";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            this.CustName.Width = 280;
            // 
            // grdCustInSwing
            // 
            this.grdCustInSwing.AllowUserToAddRows = false;
            this.grdCustInSwing.AllowUserToDeleteRows = false;
            this.grdCustInSwing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdCustInSwing.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdCustInSwing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdCustInSwing.ColumnHeadersHeight = 20;
            this.grdCustInSwing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdCustInSwing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustNumber2,
            this.CustName2});
            this.grdCustInSwing.Location = new System.Drawing.Point(537, 276);
            this.grdCustInSwing.Name = "grdCustInSwing";
            this.grdCustInSwing.ReadOnly = true;
            this.grdCustInSwing.RowHeadersVisible = false;
            this.grdCustInSwing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustInSwing.Size = new System.Drawing.Size(370, 238);
            this.grdCustInSwing.TabIndex = 13;
            // 
            // CustNumber2
            // 
            this.CustNumber2.HeaderText = "Customer #";
            this.CustNumber2.Name = "CustNumber2";
            this.CustNumber2.ReadOnly = true;
            // 
            // CustName2
            // 
            this.CustName2.HeaderText = "Customer Name";
            this.CustName2.Name = "CustName2";
            this.CustName2.ReadOnly = true;
            this.CustName2.Width = 280;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Available Customers";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Customers in Swing";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.chkCombine);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNewSwingNumber);
            this.panel1.Controls.Add(this.btnCancelNew);
            this.panel1.Controls.Add(this.btnCreateSwing);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 535);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // chkCombine
            // 
            this.chkCombine.AutoSize = true;
            this.chkCombine.Location = new System.Drawing.Point(267, 341);
            this.chkCombine.Name = "chkCombine";
            this.chkCombine.Size = new System.Drawing.Size(144, 17);
            this.chkCombine.TabIndex = 23;
            this.chkCombine.Text = "Combine Swing Numbers";
            this.chkCombine.UseVisualStyleBackColor = true;
            this.chkCombine.CheckedChanged += new System.EventHandler(this.chkCombine_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.chkDelete);
            this.panel2.Controls.Add(this.Label);
            this.panel2.Controls.Add(this.cmbSwing2);
            this.panel2.Controls.Add(this.cmbSwing1);
            this.panel2.Location = new System.Drawing.Point(265, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 124);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Swing number 2 :";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(168, 101);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(163, 17);
            this.chkDelete.TabIndex = 24;
            this.chkDelete.Text = "Delete those Swing Numbers";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(40, 33);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(89, 13);
            this.Label.TabIndex = 2;
            this.Label.Text = "Swing number 1 :";
            // 
            // cmbSwing2
            // 
            this.cmbSwing2.DisplayMember = "Swing Number";
            this.cmbSwing2.FormattingEnabled = true;
            this.cmbSwing2.Location = new System.Drawing.Point(148, 62);
            this.cmbSwing2.Name = "cmbSwing2";
            this.cmbSwing2.Size = new System.Drawing.Size(142, 21);
            this.cmbSwing2.TabIndex = 1;
            this.cmbSwing2.ValueMember = "Swing Number";
            this.cmbSwing2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSwingNumber_KeyPress);
            // 
            // cmbSwing1
            // 
            this.cmbSwing1.DisplayMember = "Swing Number";
            this.cmbSwing1.FormattingEnabled = true;
            this.cmbSwing1.Location = new System.Drawing.Point(148, 25);
            this.cmbSwing1.Name = "cmbSwing1";
            this.cmbSwing1.Size = new System.Drawing.Size(142, 21);
            this.cmbSwing1.TabIndex = 0;
            this.cmbSwing1.ValueMember = "Swing Number";
            this.cmbSwing1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSwingNumber_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(383, 78);
            this.label10.TabIndex = 21;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Swing name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(361, 126);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(262, 20);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewSwingNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Swing Number :";
            // 
            // txtNewSwingNumber
            // 
            this.txtNewSwingNumber.Location = new System.Drawing.Point(361, 96);
            this.txtNewSwingNumber.Name = "txtNewSwingNumber";
            this.txtNewSwingNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNewSwingNumber.TabIndex = 17;
            this.txtNewSwingNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewSwingNumber_KeyPress);
            // 
            // btnCancelNew
            // 
            this.btnCancelNew.Location = new System.Drawing.Point(386, 501);
            this.btnCancelNew.Name = "btnCancelNew";
            this.btnCancelNew.Size = new System.Drawing.Size(75, 23);
            this.btnCancelNew.TabIndex = 3;
            this.btnCancelNew.Text = "Cancel";
            this.btnCancelNew.UseVisualStyleBackColor = true;
            this.btnCancelNew.Click += new System.EventHandler(this.btnCancelNew_Click);
            // 
            // btnCreateSwing
            // 
            this.btnCreateSwing.Location = new System.Drawing.Point(265, 503);
            this.btnCreateSwing.Name = "btnCreateSwing";
            this.btnCreateSwing.Size = new System.Drawing.Size(101, 23);
            this.btnCreateSwing.TabIndex = 2;
            this.btnCreateSwing.Text = "Create Swing";
            this.btnCreateSwing.UseVisualStyleBackColor = true;
            this.btnCreateSwing.Click += new System.EventHandler(this.btnCreateSwing_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "To create the Swing number, enter a new Swing Number and a Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Create New Swing Number";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.ddl_CN_Manager1);
            this.panel3.Controls.Add(this.ddl_CN_Manager4);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.ddl_CN_Manager3);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.ddl_CN_Manager2);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(225, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 81);
            this.panel3.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Manager1:";
            // 
            // ddl_CN_Manager1
            // 
            this.ddl_CN_Manager1.DisplayMember = "Swing Number";
            this.ddl_CN_Manager1.FormattingEnabled = true;
            this.ddl_CN_Manager1.Location = new System.Drawing.Point(136, 13);
            this.ddl_CN_Manager1.Name = "ddl_CN_Manager1";
            this.ddl_CN_Manager1.Size = new System.Drawing.Size(142, 21);
            this.ddl_CN_Manager1.TabIndex = 26;
            this.ddl_CN_Manager1.ValueMember = "Swing Number";
            // 
            // ddl_CN_Manager4
            // 
            this.ddl_CN_Manager4.DisplayMember = "Swing Number";
            this.ddl_CN_Manager4.FormattingEnabled = true;
            this.ddl_CN_Manager4.Location = new System.Drawing.Point(379, 41);
            this.ddl_CN_Manager4.Name = "ddl_CN_Manager4";
            this.ddl_CN_Manager4.Size = new System.Drawing.Size(142, 21);
            this.ddl_CN_Manager4.TabIndex = 33;
            this.ddl_CN_Manager4.ValueMember = "Swing Number";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(313, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Manager4:";
            // 
            // ddl_CN_Manager3
            // 
            this.ddl_CN_Manager3.DisplayMember = "Swing Number";
            this.ddl_CN_Manager3.FormattingEnabled = true;
            this.ddl_CN_Manager3.Location = new System.Drawing.Point(379, 10);
            this.ddl_CN_Manager3.Name = "ddl_CN_Manager3";
            this.ddl_CN_Manager3.Size = new System.Drawing.Size(142, 21);
            this.ddl_CN_Manager3.TabIndex = 31;
            this.ddl_CN_Manager3.ValueMember = "Swing Number";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(313, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Manager3:";
            // 
            // ddl_CN_Manager2
            // 
            this.ddl_CN_Manager2.DisplayMember = "Swing Number";
            this.ddl_CN_Manager2.FormattingEnabled = true;
            this.ddl_CN_Manager2.Location = new System.Drawing.Point(136, 46);
            this.ddl_CN_Manager2.Name = "ddl_CN_Manager2";
            this.ddl_CN_Manager2.Size = new System.Drawing.Size(142, 21);
            this.ddl_CN_Manager2.TabIndex = 29;
            this.ddl_CN_Manager2.ValueMember = "Swing Number";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Manager2:";
            // 
            // ddlManager1
            // 
            this.ddlManager1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddlManager1.FormattingEnabled = true;
            this.ddlManager1.Location = new System.Drawing.Point(201, 107);
            this.ddlManager1.Name = "ddlManager1";
            this.ddlManager1.Size = new System.Drawing.Size(121, 21);
            this.ddlManager1.TabIndex = 17;
            // 
            // ddlManager2
            // 
            this.ddlManager2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddlManager2.FormattingEnabled = true;
            this.ddlManager2.Location = new System.Drawing.Point(341, 108);
            this.ddlManager2.Name = "ddlManager2";
            this.ddlManager2.Size = new System.Drawing.Size(121, 21);
            this.ddlManager2.TabIndex = 18;
            // 
            // ddlManager3
            // 
            this.ddlManager3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddlManager3.FormattingEnabled = true;
            this.ddlManager3.Location = new System.Drawing.Point(483, 108);
            this.ddlManager3.Name = "ddlManager3";
            this.ddlManager3.Size = new System.Drawing.Size(121, 21);
            this.ddlManager3.TabIndex = 19;
            // 
            // ddlManager4
            // 
            this.ddlManager4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddlManager4.FormattingEnabled = true;
            this.ddlManager4.Location = new System.Drawing.Point(625, 108);
            this.ddlManager4.Name = "ddlManager4";
            this.ddlManager4.Size = new System.Drawing.Size(121, 21);
            this.ddlManager4.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(198, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Manager 1";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(338, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Manager 2";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(482, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Manage 3";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(622, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Manager 4";
            // 
            // btnSaveManagers
            // 
            this.btnSaveManagers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveManagers.Location = new System.Drawing.Point(775, 104);
            this.btnSaveManagers.Name = "btnSaveManagers";
            this.btnSaveManagers.Size = new System.Drawing.Size(104, 23);
            this.btnSaveManagers.TabIndex = 25;
            this.btnSaveManagers.Text = "Save Managers";
            this.btnSaveManagers.UseVisualStyleBackColor = true;
            this.btnSaveManagers.Click += new System.EventHandler(this.btnSaveManagers_Click);
            // 
            // lnkSelectAllAvailableCustomers
            // 
            this.lnkSelectAllAvailableCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkSelectAllAvailableCustomers.AutoSize = true;
            this.lnkSelectAllAvailableCustomers.Location = new System.Drawing.Point(34, 517);
            this.lnkSelectAllAvailableCustomers.Name = "lnkSelectAllAvailableCustomers";
            this.lnkSelectAllAvailableCustomers.Size = new System.Drawing.Size(51, 13);
            this.lnkSelectAllAvailableCustomers.TabIndex = 26;
            this.lnkSelectAllAvailableCustomers.TabStop = true;
            this.lnkSelectAllAvailableCustomers.Text = "Select All";
            this.lnkSelectAllAvailableCustomers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectAllAvailableCustomers_LinkClicked);
            // 
            // lnkSelectAllCustInSwing
            // 
            this.lnkSelectAllCustInSwing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkSelectAllCustInSwing.AutoSize = true;
            this.lnkSelectAllCustInSwing.Location = new System.Drawing.Point(537, 517);
            this.lnkSelectAllCustInSwing.Name = "lnkSelectAllCustInSwing";
            this.lnkSelectAllCustInSwing.Size = new System.Drawing.Size(51, 13);
            this.lnkSelectAllCustInSwing.TabIndex = 27;
            this.lnkSelectAllCustInSwing.TabStop = true;
            this.lnkSelectAllCustInSwing.Text = "Select All";
            this.lnkSelectAllCustInSwing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectAllCustInSwing_LinkClicked);
            // 
            // frmViewSwing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdCustInSwing);
            this.Controls.Add(this.cmbSwingNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdAvilableCust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ddlManager4);
            this.Controls.Add(this.ddlManager3);
            this.Controls.Add(this.ddlManager2);
            this.Controls.Add(this.ddlManager1);
            this.Controls.Add(this.btnSaveManagers);
            this.Controls.Add(this.lnkSelectAllCustInSwing);
            this.Controls.Add(this.lnkSelectAllAvailableCustomers);
            this.Name = "frmViewSwing";
            this.Text = "View Swing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewSwing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAvilableCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustInSwing)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSwingNumber;
        private System.Windows.Forms.DataGridView grdAvilableCust;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelNew;
        private System.Windows.Forms.Button btnCreateSwing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkCombine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ComboBox cmbSwing2;
        private System.Windows.Forms.ComboBox cmbSwing1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewSwingNumber;
        private System.Windows.Forms.DataGridView grdCustInSwing;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName2;
        private System.Windows.Forms.ComboBox ddlManager1;
        private System.Windows.Forms.ComboBox ddlManager2;
        private System.Windows.Forms.ComboBox ddlManager3;
        private System.Windows.Forms.ComboBox ddlManager4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSaveManagers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ddl_CN_Manager1;
        private System.Windows.Forms.ComboBox ddl_CN_Manager4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox ddl_CN_Manager3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ddl_CN_Manager2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel lnkSelectAllAvailableCustomers;
        private System.Windows.Forms.LinkLabel lnkSelectAllCustInSwing;
    }
}