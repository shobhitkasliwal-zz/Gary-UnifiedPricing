using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unified_Price_for_Var
{
    public partial class ReportTypeDialog : Form
    {
        public ReportTypeDialog(string Message)
        {
            InitializeComponent();
            lblMessage.Text = Message;

        }
        public ReportTypeDialog()
        {
            
            InitializeComponent();
            lblMessage.Text = "Please select type of report.";
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void btnInActiveOnly_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void btnBoth_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        

        
    }
}
