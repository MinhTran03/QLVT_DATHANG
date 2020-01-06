using DevExpress.XtraReports.UI;
using QLVT_DATHANG.Utility;
using System;

namespace QLVT_DATHANG.Report
{
   public partial class Xrpt_ReportHDNV : XtraReport
   {
      public Xrpt_ReportHDNV(string tenCN, string tenNV, int maNV, string loaiPhieu, string beginDay, string endDay)
      {
         InitializeComponent();

         //lblTenNV.Text = tenNV;
         //lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", Cons.CiVNI);

            this.taReport_HDNV.Connection.ConnectionString = UtilDB.ConnectionString;
         try
         {
            this.dataSetReport.EnforceConstraints = false;

            this.taReport_HDNV.Fill(this.dataSetReport.Report_HDNV, maNV, loaiPhieu, beginDay, endDay);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }

            var bds = UtilDB.BdsDSPM;

            //lblCN.Text = tenCN;
            //lblNhanVienLap.Text = UtilDB.CurrentFullName;
            //lblFromTo.Text = string.Format("TỪ {0} ĐẾN {1}", DateTime.Parse(beginDay, null).ToString("dd/MM/yyyy"), DateTime.Parse(endDay, null).ToString("dd/MM/yyyy"));
        }
    }
}
