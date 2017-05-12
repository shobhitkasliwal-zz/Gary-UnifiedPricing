namespace Unified_Price_for_Var
{
    partial class ReportTypeDialog
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
            this.btnActive = new System.Windows.Forms.Button();
            this.btnInActiveOnly = new System.Windows.Forms.Button();
            this.btnBoth = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(12, 105);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(103, 42);
            this.btnActive.TabIndex = 0;
            this.btnActive.Text = "Active Only";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnInActiveOnly
            // 
            this.btnInActiveOnly.Location = new System.Drawing.Point(121, 105);
            this.btnInActiveOnly.Name = "btnInActiveOnly";
            this.btnInActiveOnly.Size = new System.Drawing.Size(95, 42);
            this.btnInActiveOnly.TabIndex = 1;
            this.btnInActiveOnly.Text = "InActive Only";
            this.btnInActiveOnly.UseVisualStyleBackColor = true;
            this.btnInActiveOnly.Click += new System.EventHandler(this.btnInActiveOnly_Click);
            // 
            // btnBoth
            // 
            this.btnBoth.Location = new System.Drawing.Point(222, 105);
            this.btnBoth.Name = "btnBoth";
            this.btnBoth.Size = new System.Drawing.Size(97, 42);
            this.btnBoth.TabIndex = 2;
            this.btnBoth.Text = "Both";
            this.btnBoth.UseVisualStyleBackColor = true;
            this.btnBoth.Click += new System.EventHandler(this.btnBoth_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(23, 26);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "label1";
            // 
            // ReportTypeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 154);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnBoth);
            this.Controls.Add(this.btnInActiveOnly);
            this.Controls.Add(this.btnActive);
            this.Name = "ReportTypeDialog";
            this.Text = "Select Type of Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnInActiveOnly;
        private System.Windows.Forms.Button btnBoth;
        private System.Windows.Forms.Label lblMessage;
    }
}