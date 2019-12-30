using System;
using DevExpress.XtraEditors;
using QLVT_DATHANG.Utility;
using QLVT_DATHANG.Report;

namespace QLVT_DATHANG.Forms
{
   public partial class frmReportTongHopNhapXuat : XtraForm
   {
      Xrpt_TongHopNhapXuat tongHopNhapXuat;
      string departId = string.Empty;

      public frmReportTongHopNhapXuat()
      {
         InitializeComponent();
      }

      private void frmReportTongHopNhapXuat_Load(object sender, EventArgs e)
      {
         //cboDepartment.DataSource = UtilDB.BdsDSPM;
         //cboDepartment.DisplayMember = MyConfig.DisplayMemberDSPM;
         //cboDepartment.ValueMember = MyConfig.FilterClauseDSPM;

         UtilDB.SetupDSCN(cboDepartment, () => { });
      }

      private void btnCurrent_Click(object sender, EventArgs e)
      {
         tongHopNhapXuat = new Xrpt_TongHopNhapXuat(DateTime.Parse(dtpFrom.Text), DateTime.Parse(dtpTo.Text), "current");
         documentViewer.DocumentSource = tongHopNhapXuat;
         tongHopNhapXuat.CreateDocument();
      }

      private void btnFull_Click(object sender, EventArgs e)
      {
         tongHopNhapXuat = new Xrpt_TongHopNhapXuat(DateTime.Parse(dtpFrom.Text), DateTime.Parse(dtpTo.Text), "full");
         documentViewer.DocumentSource = tongHopNhapXuat;
         tongHopNhapXuat.CreateDocument();
      }

      private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
      {
         
      }
   }
}