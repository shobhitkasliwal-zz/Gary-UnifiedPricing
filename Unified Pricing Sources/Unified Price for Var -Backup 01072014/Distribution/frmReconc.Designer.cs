namespace Unified_Price_for_Var
{
    partial class frmReconc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReconc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectedGroup = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnReconErrors = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalErrors = new System.Windows.Forms.Label();
            this.grpAnalysis = new System.Windows.Forms.GroupBox();
            this.lblProg2 = new System.Windows.Forms.Label();
            this.lblProg1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pgrBar1 = new System.Windows.Forms.ProgressBar();
            this.ErrorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedToBe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reconcilate Screen";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorType,
            this.ItemNumber,
            this.CustomerName,
            this.ErrorDescription,
            this.CustomerNumber,
            this.NeedToBe});
            this.dataGridView1.Location = new System.Drawing.Point(35, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(914, 303);
            this.dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selected Group :";
            // 
            // lblSelectedGroup
            // 
            this.lblSelectedGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectedGroup.AutoSize = true;
            this.lblSelectedGroup.Location = new System.Drawing.Point(146, 144);
            this.lblSelectedGroup.Name = "lblSelectedGroup";
            this.lblSelectedGroup.Size = new System.Drawing.Size(35, 13);
            this.lblSelectedGroup.TabIndex = 4;
            this.lblSelectedGroup.Text = "label4";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnalyze.Location = new System.Drawing.Point(38, 471);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(124, 23);
            this.btnAnalyze.TabIndex = 5;
            this.btnAnalyze.Text = "Analyze Group";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnReconErrors
            // 
            this.btnReconErrors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReconErrors.Location = new System.Drawing.Point(172, 471);
            this.btnReconErrors.Name = "btnReconErrors";
            this.btnReconErrors.Size = new System.Drawing.Size(161, 23);
            this.btnReconErrors.TabIndex = 6;
            this.btnReconErrors.Text = "Reconcile Errors in Group";
            this.btnReconErrors.UseVisualStyleBackColor = true;
            this.btnReconErrors.Click += new System.EventHandler(this.btnReconErrors_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(347, 471);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Errors :";
            // 
            // lblTotalErrors
            // 
            this.lblTotalErrors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalErrors.AutoSize = true;
            this.lblTotalErrors.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalErrors.Location = new System.Drawing.Point(543, 473);
            this.lblTotalErrors.Name = "lblTotalErrors";
            this.lblTotalErrors.Size = new System.Drawing.Size(17, 19);
            this.lblTotalErrors.TabIndex = 9;
            this.lblTotalErrors.Text = "0";
            // 
            // grpAnalysis
            // 
            this.grpAnalysis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAnalysis.Controls.Add(this.lblProg2);
            this.grpAnalysis.Controls.Add(this.lblProg1);
            this.grpAnalysis.Controls.Add(this.progressBar2);
            this.grpAnalysis.Controls.Add(this.pgrBar1);
            this.grpAnalysis.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnalysis.Location = new System.Drawing.Point(50, 517);
            this.grpAnalysis.Name = "grpAnalysis";
            this.grpAnalysis.Size = new System.Drawing.Size(899, 102);
            this.grpAnalysis.TabIndex = 10;
            this.grpAnalysis.TabStop = false;
            this.grpAnalysis.Text = "Analysis Progress :";
            // 
            // lblProg2
            // 
            this.lblProg2.AutoSize = true;
            this.lblProg2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg2.Location = new System.Drawing.Point(351, 55);
            this.lblProg2.Name = "lblProg2";
            this.lblProg2.Size = new System.Drawing.Size(105, 17);
            this.lblProg2.TabIndex = 3;
            this.lblProg2.Text = "Overall progress";
            // 
            // lblProg1
            // 
            this.lblProg1.AutoSize = true;
            this.lblProg1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg1.Location = new System.Drawing.Point(311, 18);
            this.lblProg1.Name = "lblProg1";
            this.lblProg1.Size = new System.Drawing.Size(207, 17);
            this.lblProg1.TabIndex = 2;
            this.lblProg1.Text = "Click on \"Analyze Group\" to start.";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(27, 73);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(851, 12);
            this.progressBar2.TabIndex = 1;
            // 
            // pgrBar1
            // 
            this.pgrBar1.Location = new System.Drawing.Point(25, 36);
            this.pgrBar1.Name = "pgrBar1";
            this.pgrBar1.Size = new System.Drawing.Size(853, 12);
            this.pgrBar1.TabIndex = 0;
            // 
            // ErrorType
            // 
            this.ErrorType.FillWeight = 70F;
            this.ErrorType.HeaderText = "Error Type";
            this.ErrorType.Name = "ErrorType";
            this.ErrorType.ReadOnly = true;
            this.ErrorType.Width = 70;
            // 
            // ItemNumber
            // 
            this.ItemNumber.HeaderText = "Item Number";
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // ErrorDescription
            // 
            this.ErrorDescription.FillWeight = 600F;
            this.ErrorDescription.HeaderText = "Error Description";
            this.ErrorDescription.Name = "ErrorDescription";
            this.ErrorDescription.ReadOnly = true;
            this.ErrorDescription.Width = 600;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.HeaderText = "Customer Number";
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.ReadOnly = true;
            this.CustomerNumber.Visible = false;
            // 
            // NeedToBe
            // 
            this.NeedToBe.HeaderText = "NeedToBe";
            this.NeedToBe.Name = "NeedToBe";
            this.NeedToBe.ReadOnly = true;
            // 
            // frmReconc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 647);
            this.Controls.Add(this.grpAnalysis);
            this.Controls.Add(this.lblTotalErrors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReconErrors);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.lblSelectedGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReconc";
            this.Text = "frmReconc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAnalysis.ResumeLayout(false);
            this.grpAnalysis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectedGroup;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnReconErrors;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalErrors;
        private System.Windows.Forms.GroupBox grpAnalysis;
        private System.Windows.Forms.Label lblProg2;
        private System.Windows.Forms.Label lblProg1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar pgrBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedToBe;
    }
}