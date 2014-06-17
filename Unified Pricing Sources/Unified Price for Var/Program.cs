using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Unified_Price_for_Var
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            //Application.Run(new frmViewDistributionGroup());
            //Application.Run(new frmViewPricing());     
          //  Application.Run(new frmReports()); 
           // Application.Run(new frmViewItem()); 

     
        }
    }
}
