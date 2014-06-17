using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BackUp
{
    public partial class frmBackUp : Form
    {
        public frmBackUp()
        {
            InitializeComponent();
        }
//==================================================================
        public void renameFile()          // This process will just RENAME file in desired location
        {
          //  string fFrom = @"C:\igor\backupfolder\UnifiedPricingDB.accdb";
            string fFrom = @"E:\LordahlPricing\UnifiedPricingDB.accdb";
           
            string todayDate = DateTime.Now.ToString().Replace(':', '-').Replace('/','-');
         
          //  string fTo = @"C:\igor\backupfolder\UnifiedPricingDB_" + todayDate +".accdb";
            string fTo = @"E:\LordahlPricing\UnifiedPricingDB_" + todayDate + ".accdb";

            try
            {
                File.Move(fFrom, fTo);     // This process will just RENAME file in desired location
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "\n Immediately Inform System Administrator", "Important Information");
            }
        }
//================================================================================
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            string sourceDir = @"c:\Program Files\LordahlPricing";      // We are copying FROM directory
            string backupDir = @"E:\LordahlPricing";          // We are copying TO directory on External Drive

            try
            {
                string[] txtList = Directory.GetFiles(sourceDir, "*.accdb");

                 // Copy text files.
                foreach (string f in txtList)
                {
                    // Remove path from the file name.
                    string fName = f.Substring(sourceDir.Length + 1);

                    try
                    {
                        // Will not overwrite if the destination file already exists.
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                        MessageBox.Show("BackUp completed successfully.", "Information");
                        renameFile();
                    }

                    // Catch exception if the file was already copied.
                    catch (IOException copyError)
                    {
                          MessageBox.Show(copyError.Message + "\n Immediately Inform System Administrator");
                    }
                }

             }
            catch (DirectoryNotFoundException dirNotFound)
            {
                MessageBox.Show(dirNotFound.Message);
             }
        }
//==========================================================================================================
        private void btnRestore_Click(object sender, EventArgs e)
        {
            // Before do this proces manualy select the data base and remove DATA/TIME portion of its name
            var restore = MessageBox.Show("You are going to restore selected data base 'UnifiedPricing.accdb' \n Please confirm your intent.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (restore == DialogResult.Yes)
            {
                string copyFromDir = @"E:\LordahlPricing";      // We are copying FROM directory on External Drive
                string restoreToDir = @"c:\Program Files\LordahlPricing";  // We are restoring TO directory
                string fName = "UnifiedPricingDB.accdb";

                try
                {
                    // Will overwrite if the destination file already exists.
                    File.Copy(Path.Combine(copyFromDir, fName), Path.Combine(restoreToDir, fName), true);
                    MessageBox.Show("Data Base " + fName + " restored successfully.", "Information");
                }
                // Catch exception if the file was already copied.
                catch (DirectoryNotFoundException dirNotFound)
                {
                    MessageBox.Show(dirNotFound.Message + "\n Immediately Inform System Administrator");
                }
            }
        }
//====================================================================================================
        private void btnExitBackUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//=====================================================================================================
        private void btnBackUpComputer_Click(object sender, EventArgs e)
        {
            // Before do this proces manualy select the data base and remove DATA/TIME portion of its name
            var restore = MessageBox.Show("You are going to BackUp 'UnifiedPricing.accdb' database file to your neighbor computer. \n Please confirm BackUp.", "Warning");
            if (restore == DialogResult.Yes)
            {
                string copyFromDir = @"c:\Program Files\LordahlPricing";      // We are copying FROM directory
                string restoreToDir = @"z:\Program Files\LordhlPricing";     // We are restoring TO directory
                string fName = "UnifiedPricingDB.accdb";

                try
                {
                    // Will overwrite if the destination file already exists.
                    File.Copy(Path.Combine(copyFromDir, fName), Path.Combine(restoreToDir, fName), true);
                    MessageBox.Show("Data Base " + fName + " BackedUp to neighbor computer successfully.", "Information");
                }
                // Catch exception if the file was already copied.
                catch (DirectoryNotFoundException dirNotFound)
                {
                    MessageBox.Show(dirNotFound.Message + "\n Immediately Inform System Administrator");
                }
            }
        }
//=====================================================================================================
     
//==========================================================================================================
    }
}
