using System;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraEditors;
using QLVT_DATHANG.Utility;

namespace QLVT_DATHANG.Forms
{
    public partial class frmSelectMaterialsConHang : XtraForm
    {
        public List<string> selectedMaterialsId;

        public frmSelectMaterialsConHang()
        {
            InitializeComponent();
            selectedMaterialsId = new List<string>();
        }

        private void frmSelectMaterialsConHang_Load(object sender, EventArgs e)
        {
            LoadTable();
            gvMaterial.OptionsSelection.MultiSelect = true;
            gvMaterial.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gvMaterial.OptionsDetail.EnableMasterViewMode = false;
        }

        private void LoadTable()
        {
            this.taVTCONHANG.Connection.ConnectionString =
               UtilDB.ConnectionString;

            try
            {
                this.dataSet.EnforceConstraints = false;

                this.taVTCONHANG.Fill(this.dataSet.DSVTCONHANG);
            }
            catch (Exception ex)
            {
                UtilDB.ShowError(ex);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            foreach (var item in gvMaterial.GetSelectedRows())
            {
                string id = gvMaterial.GetDataRow(item).Field<string>("MAVT");
                selectedMaterialsId.Add(id);
            }

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}