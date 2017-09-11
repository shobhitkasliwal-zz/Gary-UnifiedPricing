namespace Unified_Price_for_Var
{
    partial class frmChangePricing
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoIncreasePercent = new System.Windows.Forms.RadioButton();
            this.rdoIncreaseAmount = new System.Windows.Forms.RadioButton();
            this.rdoDecreasePercent = new System.Windows.Forms.RadioButton();
            this.rdoDecreaseAmount = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelection = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWarningCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblWarningText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNotAvailableText = new System.Windows.Forms.Label();
            this.lblSuccessText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Price of Inactive Items for Customer ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(3, 38);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(384, 23);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "lblCustomer";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Make Your Selection";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(102, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Increase Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(219, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Decrease Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoIncreasePercent
            // 
            this.rdoIncreasePercent.Location = new System.Drawing.Point(15, 36);
            this.rdoIncreasePercent.Name = "rdoIncreasePercent";
            this.rdoIncreasePercent.Size = new System.Drawing.Size(81, 23);
            this.rdoIncreasePercent.TabIndex = 7;
            this.rdoIncreasePercent.TabStop = true;
            this.rdoIncreasePercent.Text = "% percent";
            this.rdoIncreasePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoIncreasePercent.UseVisualStyleBackColor = true;
            this.rdoIncreasePercent.CheckedChanged += new System.EventHandler(this.rdoIncreasePercent_CheckedChanged);
            // 
            // rdoIncreaseAmount
            // 
            this.rdoIncreaseAmount.Location = new System.Drawing.Point(13, 65);
            this.rdoIncreaseAmount.Name = "rdoIncreaseAmount";
            this.rdoIncreaseAmount.Size = new System.Drawing.Size(81, 23);
            this.rdoIncreaseAmount.TabIndex = 8;
            this.rdoIncreaseAmount.TabStop = true;
            this.rdoIncreaseAmount.Text = "$ amount";
            this.rdoIncreaseAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoIncreaseAmount.UseVisualStyleBackColor = true;
            this.rdoIncreaseAmount.CheckedChanged += new System.EventHandler(this.rdoIncreaseAmount_CheckedChanged);
            // 
            // rdoDecreasePercent
            // 
            this.rdoDecreasePercent.Location = new System.Drawing.Point(130, 36);
            this.rdoDecreasePercent.Name = "rdoDecreasePercent";
            this.rdoDecreasePercent.Size = new System.Drawing.Size(81, 23);
            this.rdoDecreasePercent.TabIndex = 9;
            this.rdoDecreasePercent.TabStop = true;
            this.rdoDecreasePercent.Text = "% percent";
            this.rdoDecreasePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoDecreasePercent.UseVisualStyleBackColor = true;
            this.rdoDecreasePercent.CheckedChanged += new System.EventHandler(this.rdoDecreasePercent_CheckedChanged);
            // 
            // rdoDecreaseAmount
            // 
            this.rdoDecreaseAmount.Location = new System.Drawing.Point(130, 65);
            this.rdoDecreaseAmount.Name = "rdoDecreaseAmount";
            this.rdoDecreaseAmount.Size = new System.Drawing.Size(81, 23);
            this.rdoDecreaseAmount.TabIndex = 10;
            this.rdoDecreaseAmount.TabStop = true;
            this.rdoDecreaseAmount.Text = "$ amount";
            this.rdoDecreaseAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoDecreaseAmount.UseVisualStyleBackColor = true;
            this.rdoDecreaseAmount.CheckedChanged += new System.EventHandler(this.rdoDecreaseAmount_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdoDecreaseAmount);
            this.groupBox1.Controls.Add(this.rdoIncreasePercent);
            this.groupBox1.Controls.Add(this.rdoDecreasePercent);
            this.groupBox1.Controls.Add(this.rdoIncreaseAmount);
            this.groupBox1.Location = new System.Drawing.Point(87, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 99);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblSelection
            // 
            this.lblSelection.Location = new System.Drawing.Point(7, 228);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(112, 20);
            this.lblSelection.TabIndex = 12;
            this.lblSelection.Text = "label5";
            this.lblSelection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(217, 271);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(312, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.lblSelection);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 297);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnWarningCancel);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.lblWarningText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(30, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 155);
            this.panel2.TabIndex = 17;
            // 
            // btnWarningCancel
            // 
            this.btnWarningCancel.Location = new System.Drawing.Point(262, 129);
            this.btnWarningCancel.Name = "btnWarningCancel";
            this.btnWarningCancel.Size = new System.Drawing.Size(75, 23);
            this.btnWarningCancel.TabIndex = 3;
            this.btnWarningCancel.Text = "Cancel";
            this.btnWarningCancel.UseVisualStyleBackColor = true;
            this.btnWarningCancel.Click += new System.EventHandler(this.btnWarningCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(68, 129);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblWarningText
            // 
            this.lblWarningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningText.Location = new System.Drawing.Point(3, 32);
            this.lblWarningText.Name = "lblWarningText";
            this.lblWarningText.Size = new System.Drawing.Size(381, 78);
            this.lblWarningText.TabIndex = 1;
            this.lblWarningText.Text = "You are abount to \\n change";
            this.lblWarningText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Warning";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.lblNotAvailableText);
            this.panel3.Controls.Add(this.lblSuccessText);
            this.panel3.Location = new System.Drawing.Point(30, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 130);
            this.panel3.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(297, 80);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNotAvailableText
            // 
            this.lblNotAvailableText.Location = new System.Drawing.Point(4, 27);
            this.lblNotAvailableText.Name = "lblNotAvailableText";
            this.lblNotAvailableText.Size = new System.Drawing.Size(384, 23);
            this.lblNotAvailableText.TabIndex = 1;
            this.lblNotAvailableText.Text = "label6";
            this.lblNotAvailableText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSuccessText
            // 
            this.lblSuccessText.Location = new System.Drawing.Point(7, 4);
            this.lblSuccessText.Name = "lblSuccessText";
            this.lblSuccessText.Size = new System.Drawing.Size(384, 23);
            this.lblSuccessText.TabIndex = 0;
            this.lblSuccessText.Text = "label6";
            this.lblSuccessText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Increase Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Decrease Price";
            // 
            // frmChangePricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChangePricing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Inactive Items Price";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoIncreasePercent;
        private System.Windows.Forms.RadioButton rdoIncreaseAmount;
        private System.Windows.Forms.RadioButton rdoDecreasePercent;
        private System.Windows.Forms.RadioButton rdoDecreaseAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnWarningCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblWarningText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNotAvailableText;
        private System.Windows.Forms.Label lblSuccessText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}