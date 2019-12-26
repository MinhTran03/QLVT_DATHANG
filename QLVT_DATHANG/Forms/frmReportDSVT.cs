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
    public partial class frmReportDSVT : DevExpress.XtraEditors.XtraForm
    {
        private string _loaiPhieu;

        public frmReportDSVT()
        {
            InitializeComponent();
        }

        private void frmReportDSVT_Load(object sender, EventArgs e)
        {
            Xrpt_DanhSachvatTu danhSachvatTu = new Xrpt_DanhSachvatTu();
            docDSVT.DocumentSource = danhSachvatTu;
            danhSachvatTu.CreateDocument();
        }
    }
}