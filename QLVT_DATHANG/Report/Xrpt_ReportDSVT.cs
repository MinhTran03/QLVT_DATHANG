using DevExpress.XtraReports.UI;
using QLVT_DATHANG.Utility;
using System;

namespace QLVT_DATHANG.Report
{
   public partial class Xrpt_ReportDSVT : XtraReport
   {
      public Xrpt_ReportDSVT(string tenCN)
      {
         InitializeComponent();

         lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", Cons.CiVNI);

         this.taReport_DSVT.Connection.ConnectionString = Utility.UtilDB.ConnectionString;
         this.taReport_DSVT.Fill(this.dataSetReport.Report_DSVT);

         var bds = UtilDB.BdsDSPM;

         lblCN.Text = tenCN;
         lblNhanVienLap.Text = UtilDB.CurrentFullName;
        }   }
}
