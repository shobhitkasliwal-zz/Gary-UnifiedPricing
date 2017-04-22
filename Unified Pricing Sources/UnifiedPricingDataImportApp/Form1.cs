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

namespace UnifiedPricingDataImportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblProgress.Visible = false;
            progressBar1.Visible = false;

        }

        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {

            ofd.Filter = "XLSX|*.xlsx";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string filePath = ofd.FileName;
                string extension = Path.GetExtension(filePath);
                // string header = rbHeaderYes.Checked ? "YES" : "NO";
                string conStr, sheetName;
                conStr = string.Format(Excel07ConString, filePath, "YES");
                //Get the name of the First Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }
                //Read Data from the First Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            DataTable dt = new DataTable();
                            cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();

                            //Populate DataGridView.
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                var confirmResult = MessageBox.Show("You are attempting to upload " + dt.Rows.Count.ToString() + " records to pricing table. Are you sure ?",
                                         "Confirm Records!!",
                                         MessageBoxButtons.YesNo);
                                if (confirmResult == DialogResult.Yes)
                                {
                                    backgroundWorker1.RunWorkerAsync(dt);
                                    progressBar1.Maximum = 100;
                                    progressBar1.Step = 1;
                                    progressBar1.Value = 0;


                                    // If 'Yes', do something here.
                                }
                                else
                                {
                                    // If 'No', do something here.
                                }
                            }

                            else
                            {
                                MessageBox.Show("No rows to upload");
                            }
                        }
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable dt = (DataTable)e.Argument;
            for (int j = 0; j < dt.Rows.Count; j++)
            {

                backgroundWorker1.ReportProgress(((j * 100) / dt.Rows.Count));
                var itemNum = ReplaceNull(dt.Rows[j]["Item Number"]);
                var custNum = ReplaceNull(dt.Rows[j]["Customer Number"]);
                string curPriceString = ReplaceNull(dt.Rows[j]["Current Price"]);
                double curPrice = 0;
                Double.TryParse(curPriceString, out curPrice);


                if (itemNum.Length > 0 && custNum.Length > 0)
                {
                    var existingItems = Db.ExecuteDataTable("SELECT UCase([Item Number]) FROM tblPricing where [Item Number] = '" + itemNum.ToString().ToUpper() + "' and UCase([Customer Number]) ='" + custNum.ToUpper() + "'");
                    string query = "";
                    if (existingItems != null && existingItems.Rows.Count > 0)
                    {
                        query = "UPDATE tblPricing set ";
                        query = query + "[Item Description]='" + ReplaceNull(dt.Rows[j]["Item Description"]) + "',";
                        query = query + "[OEM Number]='" + ReplaceNull(dt.Rows[j]["OEM Number"]) + "',";
                        query = query + "[Current Price]=" + curPrice.ToString();
                        query = query + " where [Item Number]='" + itemNum.ToString() + "' and [Customer Number]='" + custNum.ToString() + "'";
                        Db.ExecuteScalar(query);
                    }
                    else
                    {
                        query = "insert into tblPricing([Customer Number],[Item Number],[Item Description],[OEM Number],[Current Price],[Old Price],[New Price]) Values ('{0}','{1}','{2}','{3}',{4},{5},{6})";
                        query = string.Format(query, ReplaceNull(dt.Rows[j]["Customer Number"]), ReplaceNull(dt.Rows[j]["Item Number"]), ReplaceNull(dt.Rows[j]["Item Description"]), ReplaceNull(dt.Rows[j]["OEM Number"]), curPrice.ToString(), "0", "0");
                        Db.ExecuteScalar(query);
                    }

                    var existingItemsItemTbl = Db.ExecuteDataTable("SELECT UCase([Item Number]) FROM tblItems where [Item Number] = '" + itemNum.ToString().ToUpper() + "'");
                    query = "";
                    if (existingItemsItemTbl != null && existingItemsItemTbl.Rows.Count > 0)
                    {
                        query = "UPDATE tblItems set ";
                        query = query + "[Item Description]='" + ReplaceNull(dt.Rows[j]["Item Description"]) + "',";
                        query = query + "[OEM Number]='" + ReplaceNull(dt.Rows[j]["OEM Number"]) + "'";
                        query = query + " where [Item Number]='" + itemNum.ToString() + "'";
                        Db.ExecuteScalar(query);
                        Console.WriteLine("Item Updated tblItems" + itemNum.ToString());
                    }
                    else
                    {
                        query = "insert into tblItems([Item Number],[Item Description],[OEM Number]) Values ('{0}','{1}','{2}')";
                        query = string.Format(query, ReplaceNull(dt.Rows[j]["Item Number"]), ReplaceNull(dt.Rows[j]["Item Description"]), ReplaceNull(dt.Rows[j]["OEM Number"]));
                        Db.ExecuteScalar(query);
                        Console.WriteLine("Item Added tblItems" + itemNum.ToString());
                    }
                }



            }

            MessageBox.Show("Done");
        }


        private string ReplaceNull(object obj)
        {
            if (obj == null || string.IsNullOrEmpty(obj.ToString()))
                return "";
            else return obj.ToString();
        }
        private void backgroundWorker1_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
        {
            lblProgress.Visible = true;
            progressBar1.Visible = true;
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            // Set the text.
            this.Text = e.ProgressPercentage.ToString();
            lblProgress.Text = "Total Progress: " + e.ProgressPercentage.ToString() + " %";
            if (e.ProgressPercentage == 100)
            {
                MessageBox.Show("Data Uploaded Successfully !!");
            }
        }
    }
}
