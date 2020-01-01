using DevExpress.XtraReports.UI;
using QLVT_DATHANG.Utility;

namespace QLVT_DATHANG.Report
{
   public partial class Xrpt_ReportDSCTVT : XtraReport
   {
      public Xrpt_ReportDSCTVT(string loaiPhieu, string beginDay, string endDay)
      {
         InitializeComponent();

         this.taReport_DSCTVT.Connection.ConnectionString = UtilDB.ConnectionString;
         this.taReport_DSCTVT.Fill(this.dataSetReport.Report_DSCTVT, loaiPhieu, beginDay, endDay);
      }   }
}
