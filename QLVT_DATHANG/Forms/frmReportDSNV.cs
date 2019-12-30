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
         UtilDB.SetupDSCN(cboDepartment, () =>
         {
            danhSachNhanVien = new Xrpt_DanhSachNhanVien(cboDepartment.Text);
            documentViewer.DocumentSource = danhSachNhanVien;
            danhSachNhanVien.CreateDocument();
         });
      }

      private void frmReportDSNV_Load(object sender, System.EventArgs e)
      {
         danhSachNhanVien = new Xrpt_DanhSachNhanVien(cboDepartment.Text);
         documentViewer.DocumentSource = danhSachNhanVien;
         danhSachNhanVien.CreateDocument();
      }

      private void cboDeployment_SelectedIndexChanged(object sender, System.EventArgs e)
      {
         //if (cboDepartment.SelectedValue.ToString().Equals("System.Data.DataRowView")) return;

         //string departId = UtilDB.GetDepartIdInFilterClause(cboDepartment.SelectedValue.ToString());

         //danhSachNhanVien = new Xrpt_DanhSachNhanVien(departId.Trim());
         //documentViewer.DocumentSource = danhSachNhanVien;
         //danhSachNhanVien.CreateDocument();
      }
   }
}