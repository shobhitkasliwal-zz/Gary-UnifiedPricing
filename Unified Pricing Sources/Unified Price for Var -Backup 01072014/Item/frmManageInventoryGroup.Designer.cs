namespace Unified_Price_for_Var
{
    partial class frmManageInventoryGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInventoryGroup));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumberOfItems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove_Group = new System.Windows.Forms.Button();
            this.btnCreate_New_Group = new System.Windows.Forms.Button();
            this.lstGroups = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd_Group = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNew_Group = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstItems_In_Group = new System.Windows.Forms.ListBox();
            this.lstItems_NotIn_Group = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Inventory Groups";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblNumberOfItems);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRemove_Group);
            this.groupBox1.Controls.Add(this.btnCreate_New_Group);
            this.groupBox1.Controls.Add(this.lstGroups);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groups";
            this.groupBox1.Visible = false;
            // 
            // lblNumberOfItems
            // 
            this.lblNumberOfItems.AutoSize = true;
            this.lblNumberOfItems.Location = new System.Drawing.Point(370, 152);
            this.lblNumberOfItems.Name = "lblNumberOfItems";
            this.lblNumberOfItems.Size = new System.Drawing.Size(10, 15);
            this.lblNumberOfItems.TabIndex = 4;
            this.lblNumberOfItems.Text = "l";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Items in selected Group:";
            // 
            // btnRemove_Group
            // 
            this.btnRemove_Group.Location = new System.Drawing.Point(328, 79);
            this.btnRemove_Group.Name = "btnRemove_Group";
            this.btnRemove_Group.Size = new System.Drawing.Size(115, 23);
            this.btnRemove_Group.TabIndex = 2;
            this.btnRemove_Group.Text = "Remove Group";
            this.btnRemove_Group.UseVisualStyleBackColor = true;
            this.btnRemove_Group.Click += new System.EventHandler(this.btnRemove_Group_Click);
            // 
            // btnCreate_New_Group
            // 
            this.btnCreate_New_Group.Location = new System.Drawing.Point(328, 32);
            this.btnCreate_New_Group.Name = "btnCreate_New_Group";
            this.btnCreate_New_Group.Size = new System.Drawing.Size(115, 23);
            this.btnCreate_New_Group.TabIndex = 1;
            this.btnCreate_New_Group.Text = "Create New Group";
            this.btnCreate_New_Group.UseVisualStyleBackColor = true;
            this.btnCreate_New_Group.Click += new System.EventHandler(this.btnCreate_New_Group_Click);
            // 
            // lstGroups
            // 
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.ItemHeight = 15;
            this.lstGroups.Location = new System.Drawing.Point(34, 32);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.Size = new System.Drawing.Size(246, 124);
            this.lstGroups.TabIndex = 0;
            this.lstGroups.SelectedIndexChanged += new System.EventHandler(this.lstGroups_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btnAdd_Group);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNew_Group);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 187);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Groups";
            this.groupBox3.Visible = false;
            // 
            // btnAdd_Group
            // 
            this.btnAdd_Group.Location = new System.Drawing.Point(199, 99);
            this.btnAdd_Group.Name = "btnAdd_Group";
            this.btnAdd_Group.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Group.TabIndex = 1;
            this.btnAdd_Group.Text = "Add Group";
            this.btnAdd_Group.UseVisualStyleBackColor = true;
            this.btnAdd_Group.Click += new System.EventHandler(this.btnAdd_Group_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "New Group Name";
            // 
            // txtNew_Group
            // 
            this.txtNew_Group.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNew_Group.Location = new System.Drawing.Point(199, 53);
            this.txtNew_Group.Name = "txtNew_Group";
            this.txtNew_Group.Size = new System.Drawing.Size(180, 21);
            this.txtNew_Group.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lstItems_In_Group);
            this.groupBox2.Controls.Add(this.lstItems_NotIn_Group);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Items in this Group:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Items NOT in any group:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(239, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(239, 72);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<  Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add  >";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstItems_In_Group
            // 
            this.lstItems_In_Group.FormattingEnabled = true;
            this.lstItems_In_Group.ItemHeight = 15;
            this.lstItems_In_Group.Location = new System.Drawing.Point(350, 36);
            this.lstItems_In_Group.Name = "lstItems_In_Group";
            this.lstItems_In_Group.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstItems_In_Group.Size = new System.Drawing.Size(180, 109);
            this.lstItems_In_Group.TabIndex = 1;
            // 
            // lstItems_NotIn_Group
            // 
            this.lstItems_NotIn_Group.FormattingEnabled = true;
            this.lstItems_NotIn_Group.ItemHeight = 15;
            this.lstItems_NotIn_Group.Location = new System.Drawing.Point(34, 39);
            this.lstItems_NotIn_Group.Name = "lstItems_NotIn_Group";
            this.lstItems_NotIn_Group.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstItems_NotIn_Group.Size = new System.Drawing.Size(180, 109);
            this.lstItems_NotIn_Group.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(570, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDone.Location = new System.Drawing.Point(508, 613);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmManageInventoryGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 663);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmManageInventoryGroup";
            this.Text = "Manage Inventory Group";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageInventoryGroup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumberOfItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove_Group;
        private System.Windows.Forms.Button btnCreate_New_Group;
        private System.Windows.Forms.ListBox lstGroups;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstItems_In_Group;
        private System.Windows.Forms.ListBox lstItems_NotIn_Group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNew_Group;
        private System.Windows.Forms.Button btnAdd_Group;
        private System.Windows.Forms.Label label7;
    }
}