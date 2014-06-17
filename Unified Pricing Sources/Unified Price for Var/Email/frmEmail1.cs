using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using MailMessage = System.Net.Mail.MailMessage;
using Unified_Price_for_Var.Properties;


namespace Unified_Price_for_Var
{
    public partial class frmEmail1 : Form
    {
        string _custEmail;
        public frmEmail1(string custEmail)
        {
            _custEmail = custEmail;
            InitializeComponent();
        }

        private void frmEmail1_Load(object sender, EventArgs e)
        {
            Db.NonQuery("Update tblEmaiAddress Set EmailAddress = '{0}' Where FirstName = 'Customer'", _custEmail);
            FillGridEmail();
            btnCancel.Visible = false;
            pnl1.Visible = false;
            btnAddRec1.Visible = false;
            btnDelete.Visible = false;
            
        }
        public void FillGridEmail()
        {
            
            var email = Db.ExecuteDataTable("Select * From tblEmaiAddress Order by LastName");
            grdEmail.Rows.Clear();
            foreach (DataRow address in email.Rows)
            {
                grdEmail.Rows.Add(address["FirstName"], address["LastName"], address["EmailAddress"], address["ID"]);
            }
                                    
        }

        private void ExitEmail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            btnSendEmail.Visible = false;
            btnCancel.Visible = true;
            btnCancel.Location = new Point(btnSendEmail.Location.X, btnSendEmail.Location.Y);
            btnAddRec.Visible = false;
            btnAddRec1.Visible = true;
            btnAddRec1.Location = new Point(btnAddRec.Location.X, btnAddRec.Location.Y);
            btnDelete.Visible = true;
       }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            btnSendEmail.Visible = true;
            btnCancel.Visible = false;
            btnAddRec1.Visible = false;
            btnAddRec.Visible = true;
            FillGridEmail();

        }
//================================================================================================
        private void btnAddRec1_Click(object sender, EventArgs e)
        {
             if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmailAddress.Text != "")
                { 
                    if( Validation.IsValidEmail(txtEmailAddress))
                    {
                        Db.NonQuery("Insert into tblEmaiAddress (FirstName, LastName, EmailAddress) Values ( '{0}', '{1}', '{2}') ", txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text);
                        txtEmailAddress.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        FillGridEmail();
                    }
                }
            else
                {
                    MessageBox.Show("Please, fill in all requested information and try again.", "Information");
                }
        }
//============================================================================================
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataGridViewRow row in grdEmail.SelectedRows)
            {
               string recipient = row.Cells["EmailAddress"].Value.ToString();
               if (recipient != "" && recipient != "empty")
               {
                   SendReport1(recipient);
               }
               else
               {
                   MessageBox.Show("Email can not be send - \n Customer does not has valid Email address", "Information");
               }
            }
            Cursor.Current = Cursors.Default;
           
      }
//===========================================================================================
        public static void SendReport1(string SendEmailTo)
        {
            var mM = new MailMessage
            {
                From = new MailAddress(Settings.Default.EmailSender),
                Subject = "Requested reports.",
                Body = "    ",                             // Email copy from
                IsBodyHtml = true
            };
            mM.To.Add(SendEmailTo);
            //var sC = new SmtpClient("smtp.live.com")
            var sC = new SmtpClient("smtp.gmail.com")
            {
               
                //Port = 25,
                Port = 587,
                Credentials = new NetworkCredential(Settings.Default.EmailSender, Settings.Default.EmailSenderPassword),
                EnableSsl = true
            };

         //   string sAttach = @"C:\VarPricing\report.pdf";
            string sAttach = @"C:\Documents and Settings\LordahlPricingReports\report.pdf";
            char[] delim = new char[] { ',' };


            System.Net.Mail.Attachment myAttachment;
            foreach (string sSubstr in sAttach.Split(delim))
            {
                 myAttachment = new System.Net.Mail.Attachment(sSubstr);
                //  System.Net.Mail.Attachment myAttachment = new System.Net.Mail.Attachment(sSubstr);
                mM.Attachments.Add(myAttachment);
            }
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                sC.Send(mM);
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Email was send out to recipient - " + SendEmailTo, "Information");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n Exception thrown. Check if internet is UP.");
            }

            finally
            {
                myAttachment = null;
                mM.Dispose(); 
                mM = null;
                sC = null;
            }
        }

//============================================================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = string.Empty;
            string name = string.Empty;
            var delete = MessageBox.Show("Are you sure you like to delete selected contacts?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in grdEmail.SelectedRows)
                {
                    ID = row.Cells["EmailAddress"].Value.ToString();
                    name = row.Cells["FirstName"].Value.ToString();
                    if (name == "Customer")
                    {
                        MessageBox.Show("Contact 'Customer' should not be deleted.", "Information");
                    }
                    else
                    {
                        try
                        {
                            Db.NonQuery("DELETE * FROM tblEmaiAddress WHERE EmailAddress = '{0}'", ID);
                        }
                        catch
                        {
                            MessageBox.Show("Record not deleted.", "Information");
                        }
                    }
               }
            }
            FillGridEmail();
        }
//========================================================================================
    }
}
