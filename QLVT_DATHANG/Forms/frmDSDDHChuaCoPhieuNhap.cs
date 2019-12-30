using System;
using QLVT_DATHANG.Report;
using DevExpress.XtraEditors;

namespace QLVT_DATHANG.Forms
{
   public partial class frmDSDDHChuaCoPhieuNhap : XtraForm
   {
      Xrpt_DanhSachDDHChuaCoPhieuNhap report;

      public frmDSDDHChuaCoPhieuNhap()
      {
         InitializeComponent();
         Utility.UtilDB.SetupDSCN(cboDepartment, () =>
         {
            report = new Xrpt_DanhSachDDHChuaCoPhieuNhap(cboDepartment.Text);
            documentViewer.DocumentSource = report;
            report.CreateDocument();
         });
      }

      private void frmDSDDHChuaCoPhieuNhap_Load(object sender, EventArgs e)
      {
         report = new Xrpt_DanhSachDDHChuaCoPhieuNhap(cboDepartment.Text);
         documentViewer.DocumentSource = report;
         report.CreateDocument();
      }
   }
}