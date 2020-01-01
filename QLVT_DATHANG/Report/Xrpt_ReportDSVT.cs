using DevExpress.XtraReports.UI;

namespace QLVT_DATHANG.Report
{
   public partial class Xrpt_ReportDSVT : XtraReport
   {
      public Xrpt_ReportDSVT()
      {
         InitializeComponent();

         this.taReport_DSVT.Connection.ConnectionString = Utility.UtilDB.ConnectionString;
         this.taReport_DSVT.Fill(this.dataSetReport.Report_DSVT);
      }   }
}
