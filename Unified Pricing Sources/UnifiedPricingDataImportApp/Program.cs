using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UnifiedPricingDataImportApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        internal static Dictionary<string, object> GlobalVariables = new Dictionary<string, object>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startup());
        }
    }
}
