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


namespace Unified_Price_for_Var.ReportViewers
{
    public partial class frmByItem_Viewer : Form
    {
        public frmByItem_Viewer()
        {
            InitializeComponent();
        }
        public ReportType reportType { get; set; }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReports.ByItem_Report rpt = new CrystalReports.ByItem_Report();
           
            crystalReportViewer1.ReportSource = rpt;
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbl in rpt.Database.Tables)
            {
                CrystalDecisions.Shared.TableLogOnInfo tblLogOnInfor = tbl.LogOnInfo;
                TableLogOnInfo curTblLogOnInfor = tbl.LogOnInfo;
                ConnectionInfo curConInfo = tbl.LogOnInfo.ConnectionInfo;

                ConnectionInfo conInfo = new ConnectionInfo();
                conInfo.ServerName = System.AppDomain.CurrentDomain.BaseDirectory + "UnifiedPricingDB.accdb";
                conInfo.DatabaseName = curConInfo.DatabaseName;
                conInfo.UserID = curConInfo.UserID;
                conInfo.Password = curConInfo.Password;

                tblLogOnInfor.ConnectionInfo = conInfo;
                tbl.ApplyLogOnInfo(tblLogOnInfor);
            }
            rpt.ReportOptions.EnableSaveDataWithReport = false;
           
                try
                {
                    
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
            
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(75);
            WindowState = FormWindowState.Maximized;
            crystalReportViewer1.RefreshReport();
            rpt.ReportOptions.EnableSaveDataWithReport = false;
        }

    }
}
