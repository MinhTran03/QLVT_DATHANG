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
    public partial class frmReportDSDVT : DevExpress.XtraEditors.XtraForm
    {
        private string _loaiPhieu;
        private string _beginDay;
        private string _endDay;

        public frmReportDSDVT()
        {
            InitializeComponent();
        }

        private void frmReportDSDVT_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            _loaiPhieu = (cboPhieu.EditValue.Equals("Phiếu Nhập")) ? "N" : "X";
            _beginDay = DateTime.Parse(dtpBegin.EditValue.ToString()).ToString("yyyy/MM/dd");
            _endDay = DateTime.Parse(dtpEnd.EditValue.ToString()).ToString("yyyy/MM/dd");

            Xrpt_ReportDSCTVT reportDSCTVT = new Xrpt_ReportDSCTVT(_loaiPhieu, _beginDay, _endDay);
            docDSDVT.DocumentSource = reportDSCTVT;
            reportDSCTVT.CreateDocument();

        }
    }
}