using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLVT_DATHANG.Utility;

namespace QLVT_DATHANG.Report
{
    public partial class Xrpt_ReportDSCTVT : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_ReportDSCTVT(string loaiPhieu, string beginDay, string endDay)
        {
            InitializeComponent();

            this.report_DSCTVTTableAdapter1.Connection.ConnectionString = UtilDB.ConnectionString;
            this.report_DSCTVTTableAdapter1.Fill(this.dataSetReport1.Report_DSCTVT, loaiPhieu, beginDay, endDay);
        }

    }
}
