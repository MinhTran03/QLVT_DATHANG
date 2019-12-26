using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANG.Report
{
    public partial class Xrpt_DanhSachvatTu : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachvatTu()
        {
            InitializeComponent();

            this.report_DSVTTableAdapter1.Connection.ConnectionString = Utility.UtilDB.ConnectionString;
            this.report_DSVTTableAdapter1.Fill(this.dataSetReport1.Report_DSVT);
        }

    }
}
