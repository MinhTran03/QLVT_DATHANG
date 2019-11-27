using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT_DATHANG.UserControls
{
    public partial class frmReceivedNote : DevExpress.XtraEditors.XtraUserControl
    {
        public frmReceivedNote()
        {
            InitializeComponent();
        }

        private void cTPNBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cTPNBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void cTPNBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cTPNBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dxErrorProvider.ClearErrors();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
