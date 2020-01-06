using System;
using System.Data;
using DevExpress.XtraEditors;
using QLVT_DATHANG.Report;
using QLVT_DATHANG.Utility;

namespace QLVT_DATHANG.Forms
{
   public partial class frmReportDSVT : XtraForm
   {
      public frmReportDSVT()
      {
         InitializeComponent();
      }

      private void frmReportDSVT_Load(object sender, EventArgs e)
      {
         Xrpt_ReportDSVT danhSachvatTu = new Xrpt_ReportDSVT(((DataRowView)UtilDB.BdsDSPM.Current)[MyConfig.DisplayMemberDSPM].ToString());
         docDSVT.DocumentSource = danhSachvatTu;
         danhSachvatTu.CreateDocument();
      }
   }
}