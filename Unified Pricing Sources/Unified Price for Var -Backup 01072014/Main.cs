using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Unified_Price_for_Var
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmViewCustomer nextScreen = new frmViewCustomer();
            DialogResult result = nextScreen.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmViewItem nextScreen1 = new frmViewItem();
            DialogResult result = nextScreen1.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmViewPricing nextScreen2 = new frmViewPricing();
            DialogResult result = nextScreen2.ShowDialog();
            Cursor.Current =Cursors.Default;
        }

        private void btnDistr_List_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmMyDistribution nextScreen3 = new frmMyDistribution();
            DialogResult result = nextScreen3.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        
        private void btnGroup_Pricing_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmChangeGroupPricing nextScreen4 = new frmChangeGroupPricing();
            DialogResult result = nextScreen4.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmReports nextScreen5 = new frmReports();
            DialogResult result = nextScreen5.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            var users = Db.ExecuteDataTable("SELECT * FROM tblUsers");
            foreach (DataRow user in users.Rows)
            {
                txtUsername.Items.Add(user["Username"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var results = Db.ExecuteDataTable("SELECT * FROM tblUsers WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'");

            if (results.Rows.Count > 0)
                panel1.Visible = false;
            else
                MessageBox.Show("Username/Password incorrect");            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            BackUp.frmBackUp nextScreen6 = new BackUp.frmBackUp();
            DialogResult result = nextScreen6.ShowDialog();
            Cursor.Current = Cursors.Default;
            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ItemConversion nextScreen7 = new ItemConversion();
            DialogResult result = nextScreen7.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
    }
}
