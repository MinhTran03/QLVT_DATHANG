using DevExpress.XtraEditors;
using QLVT_DATHANG.Report;
using QLVT_DATHANG.Utility;
using System.Data;

namespace QLVT_DATHANG.Forms
{
   public partial class frmReportDSNV : XtraForm
   {
      Xrpt_DanhSachNhanVien danhSachNhanVien;
      public frmReportDSNV()
      {
         InitializeComponent();
         if (UtilDB.CurrentGroup.Equals(MyConfig.CongTyGroupName))
         {
            pnPickDepartment.Visible = true;
            UtilDB.SetupDSCN(cboDepartment, () =>
            {
               danhSachNhanVien = new Xrpt_DanhSachNhanVien(cboDepartment.Text);
               documentViewer.DocumentSource = danhSachNhanVien;
               danhSachNhanVien.CreateDocument();
            });
         }
      }

      private void frmReportDSNV_Load(object sender, System.EventArgs e)
      {
         danhSachNhanVien = new Xrpt_DanhSachNhanVien(((DataRowView)UtilDB.BdsDSPM.Current)[MyConfig.DisplayMemberDSPM].ToString());
         documentViewer.DocumentSource = danhSachNhanVien;
         danhSachNhanVien.CreateDocument();
      }
   }
}