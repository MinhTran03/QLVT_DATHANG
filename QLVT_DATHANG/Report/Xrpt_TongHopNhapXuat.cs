using System;
using DevExpress.XtraReports.UI;
using QLVT_DATHANG.Utility;

namespace QLVT_DATHANG.Report
{
   public partial class Xrpt_TongHopNhapXuat : XtraReport
   {
      public Xrpt_TongHopNhapXuat(DateTime from, DateTime to, string mode)
      {
         InitializeComponent();

         lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", Cons.CiVNI);

         this.taTongHopNhapXuat.Connection.ConnectionString = UtilDB.ConnectionString;
         this.taTongHopNhapXuat.Fill(this.dataSetReport.Report_TongHopNhapXuat, from, to, mode);

         lblFromTo.Text = string.Format("TỪ {0} ĐẾN {1}", from.ToString("dd/MM/yyyy"), to.ToString("dd/MM/yyyy"));
      }
   }
}
