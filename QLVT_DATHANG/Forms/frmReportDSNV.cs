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

         string maCN = UtilDB.GetDepartIdInFilterClause(((DataRowView)UtilDB.BdsDSPM[UtilDB.CurrentDeployment])[MyConfig.FilterClauseDSPM].ToString());
         danhSachNhanVien = new Xrpt_DanhSachNhanVien(maCN);
         documentViewer.DocumentSource = danhSachNhanVien;
      }

      private void frmReportDSNV_Load(object sender, System.EventArgs e)
      {
         cboDepartment.DataSource = UtilDB.BdsDSPM;
         cboDepartment.DisplayMember = MyConfig.DisplayMemberDSPM;
         cboDepartment.ValueMember = MyConfig.FilterClauseDSPM;
      }

      private void cboDeployment_SelectedIndexChanged(object sender, System.EventArgs e)
      {
         if (cboDepartment.SelectedValue.ToString().Equals("System.Data.DataRowView")) return;

         string departId = UtilDB.GetDepartIdInFilterClause(cboDepartment.SelectedValue.ToString());

         danhSachNhanVien = new Xrpt_DanhSachNhanVien(departId.Trim());
         documentViewer.DocumentSource = danhSachNhanVien;
         danhSachNhanVien.CreateDocument();
      }

      private void frmReportDSNV_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
      {
         //danhSachNhanVien?.Dispose();
         //documentViewer?.Dispose();
      }
   }
}