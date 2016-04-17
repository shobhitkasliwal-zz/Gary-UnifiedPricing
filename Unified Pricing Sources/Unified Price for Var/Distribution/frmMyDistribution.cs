using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unified_Price_for_Var;  //.Distribution;

namespace Unified_Price_for_Var
{
    public partial class frmMyDistribution : Form
    {
        public frmMyDistribution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmViewDistributionGroup nextScreen1 = new frmViewDistributionGroup();
            DialogResult result = nextScreen1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSwing_Click(object sender, EventArgs e)
        {
            frmViewSwing nextScreen2 = new frmViewSwing();
            DialogResult result = nextScreen2.ShowDialog();
        }

        private void managerInformation_Click(object sender, EventArgs e)
        {
            frmManagersInformation newScreen3 = new frmManagersInformation();
            DialogResult result = newScreen3.ShowDialog();
        }
    }
}
