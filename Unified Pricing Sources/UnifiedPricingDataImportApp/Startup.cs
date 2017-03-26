using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnifiedPricingDataImportApp
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "ACCDB|*.accdb";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Program.GlobalVariables.Add("connectionString", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ofd.FileName + ";Persist Security Info=False;");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }
    }
}
