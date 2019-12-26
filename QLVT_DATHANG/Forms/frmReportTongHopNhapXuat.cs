using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLVT_DATHANG.Utility;
using QLVT_DATHANG.Report;

namespace QLVT_DATHANG.Forms
{
   public partial class frmReportTongHopNhapXuat : XtraForm
   {
      Xrpt_TongHopNhapXuat tongHopNhapXuat;
      public frmReportTongHopNhapXuat()
      {
         InitializeComponent();

         tongHopNhapXuat = new Xrpt_TongHopNhapXuat(new DateTime(2017, 9, 15), new DateTime(2017, 9, 17));
         documentViewer.DocumentSource = tongHopNhapXuat;
      }

      private void frmReportTongHopNhapXuat_Load(object sender, EventArgs e)
      {
         cboDepartment.DataSource = UtilDB.BdsDSPM;
         cboDepartment.DisplayMember = MyConfig.DisplayMemberDSPM;
         cboDepartment.ValueMember = MyConfig.FilterClauseDSPM;
      }
   }
}