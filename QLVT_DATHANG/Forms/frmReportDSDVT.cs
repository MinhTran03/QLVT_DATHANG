using System;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using QLVT_DATHANG.Report;
using QLVT_DATHANG.Utility;

namespace QLVT_DATHANG.Forms
{
   public partial class frmReportDSDVT : XtraForm
   {
      private string _loaiPhieu;
      private string _beginDay;
      private string _endDay;

      public frmReportDSDVT()
      {
         InitializeComponent();
            if (UtilDB.CurrentGroup.Equals(MyConfig.CongTyGroupName))
            {
                lblCN.Visible = cboDepartment.Visible = btnPrint.Visible = true;
                UtilDB.SetupDSCN(cboDepartment, () => {
                });
            }
            else {
                lblCN.Visible = cboDepartment.Visible = btnPrint.Visible = false;
            }
            
        }

      private void btnPrint_Click(object sender, EventArgs e)
      {
         if (ValidateDate() == false) return;
         _loaiPhieu = (cboPhieu.EditValue.Equals("Phiếu Nhập")) ? "N" : "X";
         _beginDay = DateTime.Parse(dtpBegin.EditValue.ToString()).ToString("yyyy/MM/dd");
         _endDay = DateTime.Parse(dtpEnd.EditValue.ToString()).ToString("yyyy/MM/dd");

         Xrpt_ReportDemo reportDSCTVT = new Xrpt_ReportDemo(((DataRowView)UtilDB.BdsDSPM.Current)[MyConfig.DisplayMemberDSPM].ToString(), "F",_loaiPhieu, _beginDay, _endDay);
         docDSDVT.DocumentSource = reportDSCTVT;
         reportDSCTVT.CreateDocument();
      }

        private bool ValidateDate()
        {
            if (panelControl1.Controls.OfType<DateEdit>().Where(d => d.EditValue == null).Count() > 0)
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

        private void btnPrintByCN_Click(object sender, EventArgs e)
        {
            if (ValidateDate() == false) return;
            _loaiPhieu = (cboPhieu.EditValue.Equals("Phiếu Nhập")) ? "N" : "X";
            _beginDay = DateTime.Parse(dtpBegin.EditValue.ToString()).ToString("yyyy/MM/dd");
            _endDay = DateTime.Parse(dtpEnd.EditValue.ToString()).ToString("yyyy/MM/dd");
            Xrpt_ReportDemo reportDemo = new Xrpt_ReportDemo(((DataRowView)UtilDB.BdsDSPM.Current)[MyConfig.DisplayMemberDSPM].ToString(), "C", _loaiPhieu, _beginDay, _endDay);
            docDSDVT.DocumentSource = reportDemo;
            reportDemo.CreateDocument();
        }
    }
}