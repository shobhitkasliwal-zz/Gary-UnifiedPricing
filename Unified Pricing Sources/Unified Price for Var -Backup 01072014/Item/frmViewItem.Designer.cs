namespace Unified_Price_for_Var
{
    partial class frmViewItem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label familyLabel;
            System.Windows.Forms.Label item_DescriptionLabel;
            System.Windows.Forms.Label item_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewItem));
            this.lblComponent1 = new System.Windows.Forms.Label();
            this.lblComponent2 = new System.Windows.Forms.Label();
            this.btnDelete_Item = new System.Windows.Forms.Button();
            this.btnAdd_Item = new System.Windows.Forms.Button();
            this.btnEdit_Item = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtItemFamily = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtItem_Number = new System.Windows.Forms.TextBox();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnManage_Groups = new System.Windows.Forms.Button();
            this.btnCopy_Item = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtComp1 = new System.Windows.Forms.TextBox();
            this.txtComp2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlUseDescrip = new System.Windows.Forms.Panel();
            this.btnCancelLookUp = new System.Windows.Forms.Button();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.Exit1 = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.pricing_for_Tanya_DataSet = new Unified_Price_for_Var.Pricing_for_Tanya_DataSet();
            this.tblItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblItemsTableAdapter = new Unified_Price_for_Var.Pricing_for_Tanya_DataSetTableAdapters.tblItemsTableAdapter();
            this.tableAdapterManager = new Unified_Price_for_Var.Pricing_for_Tanya_DataSetTableAdapters.TableAdapterManager();
            this.txtOEM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            familyLabel = new System.Windows.Forms.Label();
            item_DescriptionLabel = new System.Windows.Forms.Label();
            item_NumberLabel = new System.Windows.Forms.Label();
            this.pnlUseDescrip.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricing_for_Tanya_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // familyLabel
            // 
            familyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            familyLabel.AutoSize = true;
            familyLabel.Location = new System.Drawing.Point(144, 333);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new System.Drawing.Size(62, 13);
            familyLabel.TabIndex = 22;
            familyLabel.Text = "Item Family:";
            // 
            // item_DescriptionLabel
            // 
            item_DescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            item_DescriptionLabel.AutoSize = true;
            item_DescriptionLabel.Location = new System.Drawing.Point(117, 286);
            item_DescriptionLabel.Name = "item_DescriptionLabel";
            item_DescriptionLabel.Size = new System.Drawing.Size(86, 13);
            item_DescriptionLabel.TabIndex = 18;
            item_DescriptionLabel.Text = "Item Description:";
            // 
            // item_NumberLabel
            // 
            item_NumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            item_NumberLabel.AutoSize = true;
            item_NumberLabel.Location = new System.Drawing.Point(131, 241);
            item_NumberLabel.Name = "item_NumberLabel";
            item_NumberLabel.Size = new System.Drawing.Size(70, 13);
            item_NumberLabel.TabIndex = 16;
            item_NumberLabel.Text = "Item Number:";
            // 
            // lblComponent1
            // 
            this.lblComponent1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComponent1.AutoSize = true;
            this.lblComponent1.Location = new System.Drawing.Point(138, 438);
            this.lblComponent1.Name = "lblComponent1";
            this.lblComponent1.Size = new System.Drawing.Size(70, 13);
            this.lblComponent1.TabIndex = 30;
            this.lblComponent1.Text = "Component 1";
            this.lblComponent1.Visible = false;
            // 
            // lblComponent2
            // 
            this.lblComponent2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComponent2.AutoSize = true;
            this.lblComponent2.Location = new System.Drawing.Point(138, 402);
            this.lblComponent2.Name = "lblComponent2";
            this.lblComponent2.Size = new System.Drawing.Size(70, 13);
            this.lblComponent2.TabIndex = 31;
            this.lblComponent2.Text = "Component 2";
            // 
            // btnDelete_Item
            // 
            this.btnDelete_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete_Item.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete_Item.Location = new System.Drawing.Point(362, 473);
            this.btnDelete_Item.Name = "btnDelete_Item";
            this.btnDelete_Item.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_Item.TabIndex = 7;
            this.btnDelete_Item.Text = "Delete Item";
            this.btnDelete_Item.UseVisualStyleBackColor = false;
            this.btnDelete_Item.Click += new System.EventHandler(this.btnDelete_Item_Click);
            // 
            // btnAdd_Item
            // 
            this.btnAdd_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd_Item.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd_Item.Location = new System.Drawing.Point(187, 473);
            this.btnAdd_Item.Name = "btnAdd_Item";
            this.btnAdd_Item.Size = new System.Drawing.Size(90, 23);
            this.btnAdd_Item.TabIndex = 5;
            this.btnAdd_Item.Text = "Add New Item";
            this.btnAdd_Item.UseVisualStyleBackColor = false;
            this.btnAdd_Item.Click += new System.EventHandler(this.btnAdd_Item_Click);
            // 
            // btnEdit_Item
            // 
            this.btnEdit_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit_Item.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit_Item.Location = new System.Drawing.Point(281, 473);
            this.btnEdit_Item.Name = "btnEdit_Item";
            this.btnEdit_Item.Size = new System.Drawing.Size(75, 23);
            this.btnEdit_Item.TabIndex = 6;
            this.btnEdit_Item.Text = "Edit Item";
            this.btnEdit_Item.UseVisualStyleBackColor = false;
            this.btnEdit_Item.Click += new System.EventHandler(this.btnEdit_Item_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(448, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(75, 192);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(123, 13);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "Select Item to work with:";
            // 
            // txtItemFamily
            // 
            this.txtItemFamily.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemFamily.Location = new System.Drawing.Point(209, 329);
            this.txtItemFamily.Name = "txtItemFamily";
            this.txtItemFamily.ReadOnly = true;
            this.txtItemFamily.Size = new System.Drawing.Size(116, 20);
            this.txtItemFamily.TabIndex = 2;
            this.txtItemFamily.Tag = "\"Item Family\"";
            this.txtItemFamily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemDescription.Location = new System.Drawing.Point(208, 283);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.ReadOnly = true;
            this.txtItemDescription.Size = new System.Drawing.Size(312, 20);
            this.txtItemDescription.TabIndex = 1;
            this.txtItemDescription.Tag = "\"Item Description\"";
            this.txtItemDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // txtItem_Number
            // 
            this.txtItem_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem_Number.Location = new System.Drawing.Point(205, 238);
            this.txtItem_Number.Name = "txtItem_Number";
            this.txtItem_Number.ReadOnly = true;
            this.txtItem_Number.Size = new System.Drawing.Size(116, 20);
            this.txtItem_Number.TabIndex = 0;
            this.txtItem_Number.Tag = "\"Item Number\"";
            this.txtItem_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // cmbItems
            // 
            this.cmbItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItems.DropDownHeight = 200;
            this.cmbItems.DropDownWidth = 116;
            this.cmbItems.IntegralHeight = false;
            this.cmbItems.Location = new System.Drawing.Point(204, 189);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(116, 21);
            this.cmbItems.TabIndex = 0;
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.cmbItems_SelectedIndexChanged);
            this.cmbItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "From this screen you can easily manage the basic information about your inventory" +
                ". ",
            "Use EDIT, ADD, or DELETE buttons to navigate between items. ",
            "To find an Inventory Item, you can type or select the Item from the list below. ",
            "When this list is selected, you can also use the UP and DOWN arrows to move betwe" +
                "en records.     "});
            this.listBox1.Location = new System.Drawing.Point(20, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(592, 64);
            this.listBox1.TabIndex = 12;
            // 
            // btnManage_Groups
            // 
            this.btnManage_Groups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManage_Groups.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManage_Groups.Location = new System.Drawing.Point(424, 190);
            this.btnManage_Groups.Name = "btnManage_Groups";
            this.btnManage_Groups.Size = new System.Drawing.Size(98, 23);
            this.btnManage_Groups.TabIndex = 25;
            this.btnManage_Groups.Text = "Manage Groups";
            this.btnManage_Groups.UseVisualStyleBackColor = false;
            this.btnManage_Groups.Click += new System.EventHandler(this.btnManage_Groups_Click);
            // 
            // btnCopy_Item
            // 
            this.btnCopy_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopy_Item.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCopy_Item.Location = new System.Drawing.Point(424, 235);
            this.btnCopy_Item.Name = "btnCopy_Item";
            this.btnCopy_Item.Size = new System.Drawing.Size(98, 23);
            this.btnCopy_Item.TabIndex = 26;
            this.btnCopy_Item.Text = "Change # ";
            this.btnCopy_Item.UseVisualStyleBackColor = false;
            this.btnCopy_Item.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(133, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(392, 25);
            this.lblHeader.TabIndex = 27;
            this.lblHeader.Text = "Items information and maintainence ";
            // 
            // txtComp1
            // 
            this.txtComp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComp1.Location = new System.Drawing.Point(211, 434);
            this.txtComp1.Name = "txtComp1";
            this.txtComp1.ReadOnly = true;
            this.txtComp1.Size = new System.Drawing.Size(116, 20);
            this.txtComp1.TabIndex = 53;
            this.txtComp1.Tag = "\"Item Family\"";
            this.txtComp1.Visible = false;
            this.txtComp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // txtComp2
            // 
            this.txtComp2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComp2.Location = new System.Drawing.Point(209, 398);
            this.txtComp2.Name = "txtComp2";
            this.txtComp2.ReadOnly = true;
            this.txtComp2.Size = new System.Drawing.Size(116, 20);
            this.txtComp2.TabIndex = 4;
            this.txtComp2.Tag = "\"Item Family\"";
            this.txtComp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(107, 473);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(26, 473);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlUseDescrip
            // 
            this.pnlUseDescrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUseDescrip.Controls.Add(this.btnCancelLookUp);
            this.pnlUseDescrip.Controls.Add(this.btnUseItem);
            this.pnlUseDescrip.Controls.Add(this.label3);
            this.pnlUseDescrip.Controls.Add(this.comboBox2);
            this.pnlUseDescrip.Location = new System.Drawing.Point(336, 312);
            this.pnlUseDescrip.Name = "pnlUseDescrip";
            this.pnlUseDescrip.Size = new System.Drawing.Size(200, 107);
            this.pnlUseDescrip.TabIndex = 35;
            this.pnlUseDescrip.Visible = false;
            // 
            // btnCancelLookUp
            // 
            this.btnCancelLookUp.Location = new System.Drawing.Point(107, 62);
            this.btnCancelLookUp.Name = "btnCancelLookUp";
            this.btnCancelLookUp.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLookUp.TabIndex = 3;
            this.btnCancelLookUp.Text = "Cancel";
            this.btnCancelLookUp.UseVisualStyleBackColor = true;
            this.btnCancelLookUp.Click += new System.EventHandler(this.btnCancelLookUp_Click_1);
            // 
            // btnUseItem
            // 
            this.btnUseItem.Location = new System.Drawing.Point(16, 63);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(75, 23);
            this.btnUseItem.TabIndex = 2;
            this.btnUseItem.Text = "Use Item";
            this.btnUseItem.UseVisualStyleBackColor = true;
            this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SelectItem to get description from:";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DropDownHeight = 200;
            this.comboBox2.DropDownWidth = 116;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(13, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // btnLookUp
            // 
            this.btnLookUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLookUp.Location = new System.Drawing.Point(539, 279);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(75, 23);
            this.btnLookUp.TabIndex = 36;
            this.btnLookUp.Text = "Lookup...";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Visible = false;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // pnl1
            // 
            this.pnl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl1.Controls.Add(this.txtNewItem);
            this.pnl1.Controls.Add(this.Exit1);
            this.pnl1.Controls.Add(this.btnCopy);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.label6);
            this.pnl1.Controls.Add(this.comboBox1);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Location = new System.Drawing.Point(16, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(602, 491);
            this.pnl1.TabIndex = 37;
            this.pnl1.Visible = false;
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_Paint);
            // 
            // txtNewItem
            // 
            this.txtNewItem.Location = new System.Drawing.Point(174, 354);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(176, 20);
            this.txtNewItem.TabIndex = 42;
            this.txtNewItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewItem_KeyPress);
            // 
            // Exit1
            // 
            this.Exit1.Location = new System.Drawing.Point(278, 417);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(75, 23);
            this.Exit1.TabIndex = 41;
            this.Exit1.Text = "Exit";
            this.Exit1.UseVisualStyleBackColor = true;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(174, 417);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(85, 23);
            this.btnCopy.TabIndex = 40;
            this.btnCopy.Text = "Copy Item # ...";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Type in your new Item Number below:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Select an Item Number to copy from:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DisplayMember = "Item Number";
            this.comboBox1.DropDownHeight = 200;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(174, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.ValueMember = "Item Number";
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 80);
            this.label2.TabIndex = 36;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Copy Inventory Item";
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.Location = new System.Drawing.Point(26, 445);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(75, 23);
            this.btnReturnToMain.TabIndex = 38;
            this.btnReturnToMain.Text = "Exit";
            this.btnReturnToMain.UseVisualStyleBackColor = true;
            this.btnReturnToMain.Visible = false;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // pricing_for_Tanya_DataSet
            // 
            this.pricing_for_Tanya_DataSet.DataSetName = "Pricing_for_Tanya_DataSet";
            this.pricing_for_Tanya_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblItemsBindingSource
            // 
            this.tblItemsBindingSource.DataMember = "tblItems";
            this.tblItemsBindingSource.DataSource = this.pricing_for_Tanya_DataSet;
            // 
            // tblItemsTableAdapter
            // 
            this.tblItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblByAllItem_ReportTableAdapter = null;
            this.tableAdapterManager.tblByCustomer_ReportTableAdapter = null;
            this.tableAdapterManager.tblByCustomerComparison_ReportTableAdapter = null;
            this.tableAdapterManager.tblByDistr_Group_ReportTableAdapter = null;
            this.tableAdapterManager.tblByItem_ReportTableAdapter = null;
            this.tableAdapterManager.tblByItemComparison_ReportTableAdapter = null;
            this.tableAdapterManager.tblBySwing_ReportTableAdapter = null;
            this.tableAdapterManager.tblChangedPricesReport_TempTableAdapter = null;
            this.tableAdapterManager.tblChangePriceReport1TableAdapter = null;
            this.tableAdapterManager.tblComparisionByItem_TempTableAdapter = null;
            this.tableAdapterManager.tblComparisonReport_TempTableAdapter = null;
            this.tableAdapterManager.tblCustomerConnectionsDetailTableAdapter = null;
            this.tableAdapterManager.tblCustomerConnectionsMasterTableAdapter = null;
            this.tableAdapterManager.tblCustomerItemsTableAdapter = null;
            this.tableAdapterManager.tblCustomersTableAdapter = null;
            this.tableAdapterManager.tblDistributionGroupDetailTableAdapter = null;
            this.tableAdapterManager.tblDistributionGroupMasterTableAdapter = null;
            this.tableAdapterManager.tblEmaiAddressTableAdapter = null;
            this.tableAdapterManager.tblGroupMasterTableAdapter = null;
            this.tableAdapterManager.tblItemsTableAdapter = this.tblItemsTableAdapter;
            this.tableAdapterManager.tblPricing_Report_MasterTableAdapter = null;
            this.tableAdapterManager.tblPricing_Report_TempTableAdapter = null;
            this.tableAdapterManager.tblPricingHistoryTableAdapter = null;
            this.tableAdapterManager.tblPricingTableAdapter = null;
            this.tableAdapterManager.tblSwingNumbersTableAdapter = null;
            this.tableAdapterManager.tblTempMissingPriceListItemsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Unified_Price_for_Var.Pricing_for_Tanya_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtOEM
            // 
            this.txtOEM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOEM.Location = new System.Drawing.Point(209, 364);
            this.txtOEM.Name = "txtOEM";
            this.txtOEM.ReadOnly = true;
            this.txtOEM.Size = new System.Drawing.Size(116, 20);
            this.txtOEM.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "OEM Number";
            // 
            // frmViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 526);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.pnlUseDescrip);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblComponent2);
            this.Controls.Add(this.lblComponent1);
            this.Controls.Add(this.txtComp2);
            this.Controls.Add(this.txtComp1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnCopy_Item);
            this.Controls.Add(this.btnManage_Groups);
            this.Controls.Add(this.btnDelete_Item);
            this.Controls.Add(this.btnAdd_Item);
            this.Controls.Add(this.btnEdit_Item);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(familyLabel);
            this.Controls.Add(this.txtItemFamily);
            this.Controls.Add(item_DescriptionLabel);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(item_NumberLabel);
            this.Controls.Add(this.txtItem_Number);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOEM);
            this.Name = "frmViewItem";
            this.Text = "View Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewItem_Load);
            this.pnlUseDescrip.ResumeLayout(false);
            this.pnlUseDescrip.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricing_for_Tanya_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete_Item;
        private System.Windows.Forms.Button btnAdd_Item;
        private System.Windows.Forms.Button btnEdit_Item;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtItemFamily;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.TextBox txtItem_Number;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnManage_Groups;
        private System.Windows.Forms.Button btnCopy_Item;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtComp1;
        private System.Windows.Forms.TextBox txtComp2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblComponent1;
        private System.Windows.Forms.Label lblComponent2;
        private System.Windows.Forms.Panel pnlUseDescrip;
        private System.Windows.Forms.Button btnCancelLookUp;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturnToMain;
        private Pricing_for_Tanya_DataSet pricing_for_Tanya_DataSet;
        private System.Windows.Forms.BindingSource tblItemsBindingSource;
        private Pricing_for_Tanya_DataSetTableAdapters.tblItemsTableAdapter tblItemsTableAdapter;
        private Pricing_for_Tanya_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtOEM;
        private System.Windows.Forms.Label label5;
    }
}