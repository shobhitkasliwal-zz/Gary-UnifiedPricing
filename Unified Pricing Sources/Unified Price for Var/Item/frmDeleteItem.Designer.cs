namespace Unified_Price_for_Var.Item
{
    partial class frmDeleteItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbItemFrom = new System.Windows.Forms.ComboBox();
            this.cbItemTo = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.chkCustomerListing = new System.Windows.Forms.CheckBox();
            this.chkMasterItemTable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item to be removed from:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(55, 102);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(270, 102);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To:";
            // 
            // cbItemFrom
            // 
            this.cbItemFrom.FormattingEnabled = true;
            this.cbItemFrom.Location = new System.Drawing.Point(58, 119);
            this.cbItemFrom.Name = "cbItemFrom";
            this.cbItemFrom.Size = new System.Drawing.Size(177, 21);
            this.cbItemFrom.TabIndex = 5;
            // 
            // cbItemTo
            // 
            this.cbItemTo.FormattingEnabled = true;
            this.cbItemTo.Location = new System.Drawing.Point(273, 119);
            this.cbItemTo.Name = "cbItemTo";
            this.cbItemTo.Size = new System.Drawing.Size(159, 21);
            this.cbItemTo.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(289, 185);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // chkCustomerListing
            // 
            this.chkCustomerListing.AutoSize = true;
            this.chkCustomerListing.Location = new System.Drawing.Point(95, 61);
            this.chkCustomerListing.Name = "chkCustomerListing";
            this.chkCustomerListing.Size = new System.Drawing.Size(110, 17);
            this.chkCustomerListing.TabIndex = 9;
            this.chkCustomerListing.Text = "Customer\'s Listing";
            this.chkCustomerListing.UseVisualStyleBackColor = true;
            // 
            // chkMasterItemTable
            // 
            this.chkMasterItemTable.AutoSize = true;
            this.chkMasterItemTable.Location = new System.Drawing.Point(301, 61);
            this.chkMasterItemTable.Name = "chkMasterItemTable";
            this.chkMasterItemTable.Size = new System.Drawing.Size(111, 17);
            this.chkMasterItemTable.TabIndex = 10;
            this.chkMasterItemTable.Text = "Master Item Table";
            this.chkMasterItemTable.UseVisualStyleBackColor = true;
            // 
            // frmDeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 256);
            this.Controls.Add(this.chkMasterItemTable);
            this.Controls.Add(this.chkCustomerListing);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbItemTo);
            this.Controls.Add(this.cbItemFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.label1);
            this.Name = "frmDeleteItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDeleteItem";
            this.Load += new System.EventHandler(this.frmDeleteItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cbItemFrom;
        private System.Windows.Forms.ComboBox cbItemTo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.CheckBox chkCustomerListing;
        private System.Windows.Forms.CheckBox chkMasterItemTable;
    }
}