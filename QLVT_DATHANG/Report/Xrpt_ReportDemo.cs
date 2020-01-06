using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLVT_DATHANG.Utility;

namespace QLVT_DATHANG.Report
{
    public partial class Xrpt_ReportDemo : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_ReportDemo(string tenCN, string mode, string loaiPhieu, string beginDay, string endDay)
        {
            InitializeComponent();

            this.report_DSCTVTTableAdapter1.Connection.ConnectionString = UtilDB.ConnectionString;
            this.report_DSCTVTTableAdapter1.Fill(this.dataSetReport1.Report_DSCTVT, mode, loaiPhieu, beginDay, endDay);

            var bds = UtilDB.BdsDSPM;

            lblPhieu.Text = (loaiPhieu.Equals("N")) ? "Phiếu Nhập" : "Phiếu Xuất";

            lblCN.Text = tenCN;
            lblNhanVienLap.Text = UtilDB.CurrentFullName;
            lblFromTo.Text = string.Format("TỪ {0} ĐẾN {1}", DateTime.Parse(beginDay, null).ToString("dd/MM/yyyy"), DateTime.Parse(endDay, null).ToString("dd/MM/yyyy"));
        }
    }
}
