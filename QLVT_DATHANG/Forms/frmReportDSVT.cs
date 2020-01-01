using System;
using DevExpress.XtraEditors;
using QLVT_DATHANG.Report;

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
         Xrpt_ReportDSVT danhSachvatTu = new Xrpt_ReportDSVT();
         docDSVT.DocumentSource = danhSachvatTu;
         danhSachvatTu.CreateDocument();
      }
   }
}