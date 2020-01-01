using System;
using System.Data;
using QLVT_DATHANG.Utility;
using QLVT_DATHANG.Report;
using DevExpress.XtraEditors;

namespace QLVT_DATHANG.Forms
{
   public partial class frmReportHDVN : XtraForm
   {
      private int _maNV;
      private string _tenNV;
      private string _loaiPhieu;
      private string _beginDay;
      private string _endDay;

      public frmReportHDVN()
      {
         InitializeComponent();
      }

      private void btnPrint_Click(object sender, EventArgs e)
      {

         _maNV = Int32.Parse(lkeMaNV.EditValue.ToString());
         _loaiPhieu = (cboPhieu.EditValue.Equals("Phiếu Nhập")) ? "N" : "X";
         _beginDay = DateTime.Parse(dtpBegin.EditValue.ToString()).ToString("yyyy/MM/dd");
         _endDay = DateTime.Parse(dtpEnd.EditValue.ToString()).ToString("yyyy/MM/dd");

         Xrpt_ReportHDNV reportHDNV = new Xrpt_ReportHDNV(_maNV, _loaiPhieu, _beginDay, _endDay);
         docView.DocumentSource = reportHDNV;
         reportHDNV.CreateDocument();
      }

      private void lkeMaNV_EditValueChanged(object sender, EventArgs e)
      {
         var selectEmployee = lkeMaNV.GetSelectedDataRow() as DataRowView;

         txtName.Text = selectEmployee.Row["HOTEN"].ToString();
      }

      private void frmReportHDVN_Load(object sender, EventArgs e)
      {
         taDSNV.Connection.ConnectionString = UtilDB.ConnectionString;

         try
         {
            this.taDSNV.Fill(this.dataSet.DSNV);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);

         }
      }
   }
}