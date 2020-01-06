using System;
using System.Data;
using QLVT_DATHANG.Utility;
using QLVT_DATHANG.Report;
using DevExpress.XtraEditors;
using System.Linq;

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
         if (ValidateDate() == false) return;

         _maNV = Int32.Parse(lkeMaNV.EditValue.ToString());
         _tenNV += _maNV;
         _loaiPhieu = (cboPhieu.EditValue.Equals("Phiếu Nhập")) ? "N" : "X";
         _beginDay = DateTime.Parse(dtpBegin.EditValue.ToString()).ToString("yyyy/MM/dd");
         _endDay = DateTime.Parse(dtpEnd.EditValue.ToString()).ToString("yyyy/MM/dd");

         Xrpt_ReportHDNV reportHDNV = new Xrpt_ReportHDNV(((DataRowView)UtilDB.BdsDSPM.Current)[MyConfig.DisplayMemberDSPM].ToString(), _tenNV,_maNV, _loaiPhieu, _beginDay, _endDay);
         docView.DocumentSource = reportHDNV;
         reportHDNV.CreateDocument();
      }

      private void lkeMaNV_EditValueChanged(object sender, EventArgs e)
      {
         var selectEmployee = lkeMaNV.GetSelectedDataRow() as DataRowView;

         _tenNV = selectEmployee.Row["HOTEN"].ToString() + " Mã Nhân Viên: ";
        
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

        private bool ValidateDate()
        {
            if (lkeMaNV.EditValue.Equals(""))
            {
                dxErrorProvider.SetError(lkeMaNV, Cons.ErrorNotNull);
                return false;
            }
            if (panelControl2.Controls.OfType<DateEdit>().Where(d => d.EditValue == null).Count() > 0)
            {
                dxErrorProvider.SetError(dtpBegin, Cons.ErrorNotNull);
                dxErrorProvider.SetError(dtpEnd, Cons.ErrorNotNull);
                return false;
            }

            DateTime from = DateTime.Parse(dtpBegin.EditValue.ToString());
            DateTime to = DateTime.Parse(dtpEnd.EditValue.ToString());
            if (from.CompareTo(to) >= 0)
            {
                dxErrorProvider.SetError(dtpBegin, "Phải nhỏ hơn ngày đến");
                return false;
            }
            return true;
        }

        private void dtpNotNull_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var value = (sender as DateEdit).EditValue;
            if (null == value || value.ToString().Length == 0)
            {
                dxErrorProvider.SetError((sender as BaseEdit), Cons.ErrorNotNull);
            }
            else
            {
                // remove error
                dxErrorProvider.SetError((sender as BaseEdit), string.Empty);
            }
            e.Cancel = false;
        }
    }
}