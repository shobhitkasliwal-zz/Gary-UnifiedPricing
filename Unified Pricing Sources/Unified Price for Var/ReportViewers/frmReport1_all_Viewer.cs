using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;


namespace Unified_Price_for_Var
{
    public partial class frmReport1_all_Viewer : Form
    {
        public frmReport1_all_Viewer()
        {
            InitializeComponent();
        }

        public string DisplayManagerInfo { get; set; }
        public ReportType reportType { get; set; }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReports.Report1_all rpt = new CrystalReports.Report1_all();
            crystalReportViewer1.ReportSource = rpt;
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbl in rpt.Database.Tables)
            {
                CrystalDecisions.Shared.TableLogOnInfo tblLogOnInfor = tbl.LogOnInfo;
                TableLogOnInfo curTblLogOnInfor = tbl.LogOnInfo;   // tblLogOnInfor;
                ConnectionInfo curConInfo = tbl.LogOnInfo.ConnectionInfo;

                ConnectionInfo conInfo = new ConnectionInfo();
                conInfo.ServerName = System.AppDomain.CurrentDomain.BaseDirectory + "UnifiedPricingDB.accdb";
                conInfo.DatabaseName = curConInfo.DatabaseName;
                conInfo.UserID = curConInfo.UserID;
                conInfo.Password = curConInfo.Password;

                tblLogOnInfor.ConnectionInfo = conInfo;
                tbl.ApplyLogOnInfo(tblLogOnInfor);
            }
            try
            {
                TextObject txt1 = (TextObject)rpt.ReportDefinition.ReportObjects["txtManagerInfo"];
                if (txt1 != null)
                    txt1.Text = DisplayManagerInfo;
                if (reportType == ReportType.ACTIVE)
                {
                    SubreportObject subReportInActive = (SubreportObject)rpt.ReportDefinition.ReportObjects["subReportInActive"];
                    subReportInActive.ObjectFormat.EnableSuppress = true;
                }
                else if (reportType == ReportType.INACTIVE)
                {
                    SubreportObject subReportActive = (SubreportObject)rpt.ReportDefinition.ReportObjects["subReportActive"];
                    subReportActive.ObjectFormat.EnableSuppress = true;
                }
            }
            catch (Exception ex)
            { }

            
            rpt.ReportOptions.EnableSaveDataWithReport = false;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(75);
            WindowState = FormWindowState.Maximized;
            rpt.ReportOptions.EnableSaveDataWithReport = false;
        }
    }
}
