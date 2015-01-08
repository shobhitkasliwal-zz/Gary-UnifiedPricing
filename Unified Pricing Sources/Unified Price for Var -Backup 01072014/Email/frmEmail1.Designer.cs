namespace Unified_Price_for_Var
{
    partial class frmEmail1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmail1));
            this.label1 = new System.Windows.Forms.Label();
            this.grdEmail = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitEmail = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnAddRec = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddRec1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmail)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdEmail
            // 
            this.grdEmail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.EmailAddress});
            this.grdEmail.Location = new System.Drawing.Point(106, 182);
            this.grdEmail.Name = "grdEmail";
            this.grdEmail.Size = new System.Drawing.Size(513, 221);
            this.grdEmail.TabIndex = 1;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 120;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Width = 250;
            // 
            // ExitEmail
            // 
            this.ExitEmail.Location = new System.Drawing.Point(544, 470);
            this.ExitEmail.Name = "ExitEmail";
            this.ExitEmail.Size = new System.Drawing.Size(75, 23);
            this.ExitEmail.TabIndex = 2;
            this.ExitEmail.Text = "Exit";
            this.ExitEmail.UseVisualStyleBackColor = true;
            this.ExitEmail.Click += new System.EventHandler(this.ExitEmail_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(373, 470);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSendEmail.TabIndex = 3;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnAddRec
            // 
            this.btnAddRec.Location = new System.Drawing.Point(454, 470);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.Size = new System.Drawing.Size(84, 23);
            this.btnAddRec.TabIndex = 4;
            this.btnAddRec.Text = "Add Recipient";
            this.btnAddRec.UseVisualStyleBackColor = true;
            this.btnAddRec.Click += new System.EventHandler(this.btnAddRec_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(8, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(139, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(160, 28);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(161, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(337, 28);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(184, 20);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email Address";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.txtLastName);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.txtFirstName);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.txtEmailAddress);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Location = new System.Drawing.Point(93, 411);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(535, 55);
            this.pnl1.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddRec1
            // 
            this.btnAddRec1.Location = new System.Drawing.Point(95, 470);
            this.btnAddRec1.Name = "btnAddRec1";
            this.btnAddRec1.Size = new System.Drawing.Size(75, 23);
            this.btnAddRec1.TabIndex = 13;
            this.btnAddRec1.Text = "Add Record";
            this.btnAddRec1.UseVisualStyleBackColor = true;
            this.btnAddRec1.Click += new System.EventHandler(this.btnAddRec1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(295, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mailing List";
            // 
            // frmEmail1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddRec1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.btnAddRec);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.ExitEmail);
            this.Controls.Add(this.grdEmail);
            this.Controls.Add(this.label1);
            this.Name = "frmEmail1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email - Mailing List";
            this.Load += new System.EventHandler(this.frmEmail1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmail)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdEmail;
        private System.Windows.Forms.Button ExitEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnAddRec;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddRec1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
    }
}