namespace Unified_Price_for_Var
{
    partial class frmCopyPrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopyPrices));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCopy_To = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCopy_Prices = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.chbRepDup = new System.Windows.Forms.CheckBox();
            this.grpReplace = new System.Windows.Forms.GroupBox();
            this.rdoSkip = new System.Windows.Forms.RadioButton();
            this.rdoExcept = new System.Windows.Forms.RadioButton();
            this.rdoReplace = new System.Windows.Forms.RadioButton();
            this.chbDeleteAfterCopy = new System.Windows.Forms.CheckBox();
            this.gridPrices = new System.Windows.Forms.DataGridView();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpReplace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copy Prices";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select the Customer you are copying FROM:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Here is the customer you are copying TO:";
            // 
            // lblCopy_To
            // 
            this.lblCopy_To.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopy_To.AutoSize = true;
            this.lblCopy_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy_To.Location = new System.Drawing.Point(338, 222);
            this.lblCopy_To.Name = "lblCopy_To";
            this.lblCopy_To.Size = new System.Drawing.Size(88, 16);
            this.lblCopy_To.TabIndex = 4;
            this.lblCopy_To.Text = "lblCopy_To";
            this.lblCopy_To.UseMnemonic = false;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCustomers.DisplayMember = "Customer Number";
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(43, 222);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(237, 21);
            this.cmbCustomers.TabIndex = 5;
            this.cmbCustomers.ValueMember = "Customer Number";
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_Customer_SelectedIndexChanged);
            this.cmbCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomers_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(521, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Below are all of the Items for the Customer you are copying from. Select Items yo" +
    "u want to copy:";
            // 
            // btnCopy_Prices
            // 
            this.btnCopy_Prices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopy_Prices.Location = new System.Drawing.Point(43, 576);
            this.btnCopy_Prices.Name = "btnCopy_Prices";
            this.btnCopy_Prices.Size = new System.Drawing.Size(75, 23);
            this.btnCopy_Prices.TabIndex = 8;
            this.btnCopy_Prices.Text = "Copy Prices";
            this.btnCopy_Prices.UseVisualStyleBackColor = true;
            this.btnCopy_Prices.Click += new System.EventHandler(this.btnCopy_Prices_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.Location = new System.Drawing.Point(139, 576);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckAll.Location = new System.Drawing.Point(43, 525);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 10;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // chbRepDup
            // 
            this.chbRepDup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbRepDup.AutoSize = true;
            this.chbRepDup.Location = new System.Drawing.Point(377, 531);
            this.chbRepDup.Name = "chbRepDup";
            this.chbRepDup.Size = new System.Drawing.Size(145, 17);
            this.chbRepDup.TabIndex = 11;
            this.chbRepDup.Text = "Replace/Skip Duplicates";
            this.chbRepDup.UseVisualStyleBackColor = true;
            this.chbRepDup.CheckedChanged += new System.EventHandler(this.chbRepDup_CheckedChanged);
            // 
            // grpReplace
            // 
            this.grpReplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpReplace.Controls.Add(this.rdoSkip);
            this.grpReplace.Controls.Add(this.rdoExcept);
            this.grpReplace.Controls.Add(this.rdoReplace);
            this.grpReplace.Enabled = false;
            this.grpReplace.Location = new System.Drawing.Point(374, 554);
            this.grpReplace.Name = "grpReplace";
            this.grpReplace.Size = new System.Drawing.Size(262, 107);
            this.grpReplace.TabIndex = 12;
            this.grpReplace.TabStop = false;
            this.grpReplace.Text = "Replace/Skip Duplicates";
            // 
            // rdoSkip
            // 
            this.rdoSkip.AutoSize = true;
            this.rdoSkip.Location = new System.Drawing.Point(25, 80);
            this.rdoSkip.Name = "rdoSkip";
            this.rdoSkip.Size = new System.Drawing.Size(99, 17);
            this.rdoSkip.TabIndex = 2;
            this.rdoSkip.Text = "Skip Duplicates";
            this.rdoSkip.UseVisualStyleBackColor = true;
            this.rdoSkip.CheckedChanged += new System.EventHandler(this.rdoSkip_CheckedChanged);
            // 
            // rdoExcept
            // 
            this.rdoExcept.AutoSize = true;
            this.rdoExcept.Location = new System.Drawing.Point(25, 53);
            this.rdoExcept.Name = "rdoExcept";
            this.rdoExcept.Size = new System.Drawing.Size(213, 17);
            this.rdoExcept.TabIndex = 1;
            this.rdoExcept.Text = "Replace Duplicates Except Lower Price";
            this.rdoExcept.UseVisualStyleBackColor = true;
            this.rdoExcept.CheckedChanged += new System.EventHandler(this.rdoExcept_CheckedChanged);
            // 
            // rdoReplace
            // 
            this.rdoReplace.AutoSize = true;
            this.rdoReplace.Checked = true;
            this.rdoReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdoReplace.Location = new System.Drawing.Point(25, 28);
            this.rdoReplace.Name = "rdoReplace";
            this.rdoReplace.Size = new System.Drawing.Size(136, 17);
            this.rdoReplace.TabIndex = 0;
            this.rdoReplace.TabStop = true;
            this.rdoReplace.Text = "Replace Duplicates";
            this.rdoReplace.UseVisualStyleBackColor = true;
            this.rdoReplace.CheckedChanged += new System.EventHandler(this.rdoReplace_CheckedChanged);
            // 
            // chbDeleteAfterCopy
            // 
            this.chbDeleteAfterCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbDeleteAfterCopy.AutoSize = true;
            this.chbDeleteAfterCopy.Location = new System.Drawing.Point(134, 530);
            this.chbDeleteAfterCopy.Name = "chbDeleteAfterCopy";
            this.chbDeleteAfterCopy.Size = new System.Drawing.Size(206, 17);
            this.chbDeleteAfterCopy.TabIndex = 13;
            this.chbDeleteAfterCopy.Text = "Delete Customer When Done Copying";
            this.chbDeleteAfterCopy.UseVisualStyleBackColor = true;
            // 
            // gridPrices
            // 
            this.gridPrices.AllowUserToAddRows = false;
            this.gridPrices.AllowUserToDeleteRows = false;
            this.gridPrices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumber,
            this.CurrentPrice,
            this.PreviousPrice,
            this.ItemDescription,
            this.CustomerItemNumber,
            this.ID});
            this.gridPrices.Location = new System.Drawing.Point(43, 249);
            this.gridPrices.Name = "gridPrices";
            this.gridPrices.ReadOnly = true;
            this.gridPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrices.Size = new System.Drawing.Size(757, 264);
            this.gridPrices.TabIndex = 43;
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
            this.ItemDescription.Width = 370;
            // 
            // CustomerItemNumber
            // 
            this.CustomerItemNumber.HeaderText = "Customer Item Number";
            this.CustomerItemNumber.Name = "CustomerItemNumber";
            this.CustomerItemNumber.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // frmCopyPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 693);
            this.Controls.Add(this.gridPrices);
            this.Controls.Add(this.chbDeleteAfterCopy);
            this.Controls.Add(this.grpReplace);
            this.Controls.Add(this.chbRepDup);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnCopy_Prices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.lblCopy_To);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCopyPrices";
            this.Text = "Copy Prices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCopyPrices_Load);
            this.grpReplace.ResumeLayout(false);
            this.grpReplace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCopy_To;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCopy_Prices;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.CheckBox chbRepDup;
        private System.Windows.Forms.GroupBox grpReplace;
        private System.Windows.Forms.RadioButton rdoSkip;
        private System.Windows.Forms.RadioButton rdoExcept;
        private System.Windows.Forms.RadioButton rdoReplace;
        private System.Windows.Forms.CheckBox chbDeleteAfterCopy;
        private System.Windows.Forms.DataGridView gridPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}