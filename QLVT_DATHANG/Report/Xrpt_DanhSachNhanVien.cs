using DevExpress.XtraReports.UI;
using QLVT_DATHANG.Utility;
using System;

namespace QLVT_DATHANG.Report
{
   public partial class Xrpt_DanhSachNhanVien : XtraReport
   {
      public Xrpt_DanhSachNhanVien(string tenCN)
      {
         InitializeComponent();

         //lblDate.Text = string.Format(Cons.CiVNI, "{0:dddd, dd MMMM yyyy}", DateTime.Now);
         lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", Cons.CiVNI);

         this.taReportDSNV.Connection.ConnectionString = UtilDB.ConnectionString;
         this.taReportDSNV.Fill(this.dataSetReport.Report_DSNV);

         var bds = UtilDB.BdsDSPM;

         lblCN.Text = tenCN;
         lblNhanVienLap.Text = UtilDB.CurrentFullName;
      }
   }
}
