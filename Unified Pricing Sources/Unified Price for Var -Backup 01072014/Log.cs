using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unified_Price_for_Var
{
    public static class Log
    {
        public static void Exception(Exception ex)
        {
            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            if (ex.InnerException != null)
                MessageBox.Show(ex.InnerException.Message + "\n" + ex.InnerException.StackTrace);            
        }
    }
}
