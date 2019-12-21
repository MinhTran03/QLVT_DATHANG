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
using QLVT_DATHANG.Report;

namespace QLVT_DATHANG.Forms
{
   public partial class frmDSDDHChuaCoPhieuNhap : DevExpress.XtraEditors.XtraForm
   {
      Xrpt_DanhSachDDHChuaCoPhieuNhap report;

      public frmDSDDHChuaCoPhieuNhap()
      {
         InitializeComponent();
         report = new Xrpt_DanhSachDDHChuaCoPhieuNhap();
         documentViewer.DocumentSource = report;
      }

      private void frmDSDDHChuaCoPhieuNhap_Load(object sender, EventArgs e)
      {

      }
   }
}