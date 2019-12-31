using System;
using DevExpress.XtraEditors;
using QLVT_DATHANG.Utility;
using QLVT_DATHANG.Report;
using System.Data;
using System.Linq;

namespace QLVT_DATHANG.Forms
{
   public partial class frmReportTongHopNhapXuat : XtraForm
   {
      Xrpt_TongHopNhapXuat tongHopNhapXuat;

      public frmReportTongHopNhapXuat()
      {
         InitializeComponent();
         if (UtilDB.CurrentGroup.Equals(MyConfig.CongTyGroupName))
         {
            labelControl1.Visible = cboDepartment.Visible = btnFull.Visible = true;
            UtilDB.SetupDSCN(cboDepartment, () => { });
         }
      }

      private void frmReportTongHopNhapXuat_Load(object sender, EventArgs e)
      {

      }

      private void btnCurrent_Click(object sender, EventArgs e)
      {
         if (ValidateDate() == false) return;
         tongHopNhapXuat = new Xrpt_TongHopNhapXuat(DateTime.Parse(dtpFrom.EditValue.ToString()), DateTime.Parse(dtpTo.EditValue.ToString()), "current", ((DataRowView)UtilDB.BdsDSPM.Current)[MyConfig.DisplayMemberDSPM].ToString());
         documentViewer.DocumentSource = tongHopNhapXuat;
         tongHopNhapXuat.CreateDocument();
      }

      private void btnFull_Click(object sender, EventArgs e)
      {
         if (ValidateDate() == false) return;
         tongHopNhapXuat = new Xrpt_TongHopNhapXuat(DateTime.Parse(dtpFrom.EditValue.ToString()), DateTime.Parse(dtpTo.EditValue.ToString()), "full", "Toàn bộ chi nhánh");
         documentViewer.DocumentSource = tongHopNhapXuat;
         tongHopNhapXuat.CreateDocument();
      }

      private bool ValidateDate()
      {
         if(pnPickDepartment.Controls.OfType<DateEdit>().Where(d => d.EditValue == null).Count() > 0)
         {
            errorProvider.SetError(dtpFrom, Cons.ErrorNotNull);
            errorProvider.SetError(dtpTo, Cons.ErrorNotNull);
            return false;
         }

         DateTime from = DateTime.Parse(dtpFrom.EditValue.ToString());
         DateTime to = DateTime.Parse(dtpTo.EditValue.ToString());
         if(from.CompareTo(to) >= 0)
         {
            errorProvider.SetError(dtpFrom, "Phải nhỏ hơn ngày đến");
            return false;
         }
         return true;
      }

      private void dtpNotNull_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         var value = (sender as DateEdit).EditValue;
         if (null == value || value.ToString().Length == 0)
         {
            errorProvider.SetError((sender as BaseEdit), Cons.ErrorNotNull);
         }
         else
         {
            // remove error
            errorProvider.SetError((sender as BaseEdit), string.Empty);
         }
         e.Cancel = false;
      }
   }
}