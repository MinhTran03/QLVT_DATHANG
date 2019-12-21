using DevExpress.XtraReports.UI;
using QLVT_DATHANG.Utility;
using System;
using System.Data;

namespace QLVT_DATHANG.Report
{
   public partial class Xrpt_DanhSachNhanVien : XtraReport
   {
      public Xrpt_DanhSachNhanVien(string maCN)
      {
         InitializeComponent();

         //lblDate.Text = string.Format(Cons.CiVNI, "{0:dddd, dd MMMM yyyy}", DateTime.Now);
         lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", Cons.CiVNI);

         maCN = maCN.ToUpper();

         this.taReportDSNV.Connection.ConnectionString = Utility.UtilDB.ConnectionString;
         this.taReportDSNV.Fill(this.dataSetReport.Report_DSNV, maCN);

         var bds = UtilDB.BdsDSPM;

         for (int index = 0; index < bds.Count; index++)
         {
            var row = ((DataRowView)bds[index]);
            if (row[MyConfig.FilterClauseDSPM].ToString().Contains(maCN))
            {
               lblChiNhanh.Text = row[MyConfig.DisplayMemberDSPM].ToString();
               break;
            }
         }
      }
   }
}
