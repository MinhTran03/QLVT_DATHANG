using System;
using QLVT_DATHANG.Report;
using DevExpress.XtraEditors;
using System.Data;

namespace QLVT_DATHANG.Forms
{
   public partial class frmReportDSDDHChuaCoPhieuNhap : XtraForm
   {
      Xrpt_DanhSachDDHChuaCoPhieuNhap report;

      public frmReportDSDDHChuaCoPhieuNhap()
      {
         InitializeComponent();
         if (Utility.UtilDB.CurrentGroup.Equals(MyConfig.CongTyGroupName))
         {
            pnPickDepartment.Visible = true;
            Utility.UtilDB.SetupDSCN(cboDepartment, () =>
            {
               report = new Xrpt_DanhSachDDHChuaCoPhieuNhap(cboDepartment.Text);
               documentViewer.DocumentSource = report;
               report.CreateDocument();
            });
         }
      }

      private void frmDSDDHChuaCoPhieuNhap_Load(object sender, EventArgs e)
      {
         report = new Xrpt_DanhSachDDHChuaCoPhieuNhap(((DataRowView)Utility.UtilDB.BdsDSPM.Current)[MyConfig.DisplayMemberDSPM].ToString());
         documentViewer.DocumentSource = report;
         report.CreateDocument();
      }
   }
}