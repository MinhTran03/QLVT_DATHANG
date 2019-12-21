using System;
using System.Data;

namespace QLVT_DATHANG.Forms
{
    using DataSetTableAdapters;
    using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using System.Data.SqlClient;
   using System.Windows.Forms;
   using System.Drawing;
   using Utility;

   public partial class frmGoodsReceivedNote : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;
      private int _backupWidth;

        private BindingSource _bdsPN;
        private PhieuNhapTableAdapter _taPN;
        private BindingSource _bdsCTPN;
        private CTPNTableAdapter _taCTPN;
        private DataSet _dataSet;

        public frmGoodsReceivedNote()
      {
         InitializeComponent();

            _bdsPN = bdsPN;
            _taPN = taPN;
            _bdsCTPN = bdsCTPN;
            _taCTPN = taCTPN;
            _dataSet = dataSet;

            this.gcCTPN.DataSource = _bdsCTPN;
            _bdsCTPN.ListChanged += bdsCTPN_ListChanged;

            SetupControls();
      }

        private void bdsCTPN_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (gvCTPN.DataRowCount == 0) btnRemoveDataRow.Enabled = false;
            else btnRemoveDataRow.Enabled = true;
        }

        private void GoodsReceivedNote_Load(object sender, EventArgs e)
      {
            LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsPN[0])["MAPN"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals("congty"))
         {
            UtilDB.SetupDSCN(cboDeployment, LoadTable);
            this.pnPickDepartment.Visible = true;
            btnAdd.Enabled = false;
         }
      }

      private void SetupControls()
      {
         //gcCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         //gcCTPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         //gcCTPN.Columns[3].DefaultCellStyle.FormatProvider = Cons.CiVNI;
         //gcCTPN.Columns[3].DefaultCellStyle.Format = "c0";

         //gcCTPN.BorderStyle = BorderStyle.None;
         //gcCTPN.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
         //gcCTPN.CellBorderStyle = DataGridViewCellBorderStyle.Single;
         //gcCTPN.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 234, 253);
         //gcCTPN.DefaultCellStyle.SelectionForeColor = Color.Black;
         //gcCTPN.BackgroundColor = Color.White;

         //gcCTPN.EnableHeadersVisualStyles = false;
         //gcCTPN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
         //gcCTPN.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 247);
         //gcCTPN.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
         //gcCTPN.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
      }

      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taPN.Connection.ConnectionString =
                this.taCTPN.Connection.ConnectionString =
                this.taDSKHO.Connection.ConnectionString =
                this.taDDH.Connection.ConnectionString =
                this.taDSNV.Connection.ConnectionString =
                this.taDSVT.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taPN.Fill(this.dataSet.PhieuNhap);

                this.taCTPN.Fill(this.dataSet.CTPN);

            this.taDSKHO.Fill(this.dataSet.DSKHO);

                this.taDDH.Fill(this.dataSet.DatHang);

                this.taDSNV.Fill(this.dataSet.DSNV);

            this.taDSVT.Fill(this.dataSet.DSVT);

            //this.dataSet.EnforceConstraints = true;

         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void EnableEditMode()
      {
         //gbOrderDetail.Enabled = false;

         gcReceivedNote.Enabled = false;
         gbReceivedNote.Enabled = true;

         gbCTPN.Enabled = true;

            btnAdd.Enabled = false;
         btnExit.Enabled = false;
         btnRefresh.Enabled = false;

         btnCancelEdit.Enabled = true;
         btnCancelEdit.Visibility = BarItemVisibility.Always;

         btnSave.Enabled = true;
         btnSave.Visibility = BarItemVisibility.Always;
      }

      private void DisableEditMode()
      {
         gcReceivedNote.Enabled = true;
         gbReceivedNote.Enabled = false;

         gbCTPN.Enabled = false;

         btnAdd.Enabled = true;
         btnExit.Enabled = true;
         btnRefresh.Enabled = true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;
      }

      #endregion

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsPN.Position;

         bdsPN.AddNew();

         txtDate.EditValue = DateTime.Now;
         lkeEmployee.EditValue = UtilDB.UserName;

         EnableEditMode();
         txtMaPN.Focus();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         SaveReceivedNote();
      }

      private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
      {
         LoadTable();
      }

      private void btnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         dxErrorProvider.ClearErrors();
         try
         {
            gbReceivedNote.Enabled = false;
            bdsPN.CancelEdit();
            bdsPN.ResetCurrentItem();
            bdsPN.Position = _currentPosition;

            bdsCTPN.CancelEdit();
            bdsPN.ResetCurrentItem();

                DisableEditMode();
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
      {
         this.Close();
      }

        private object[] GetDataOrder()
        {
            object[] data = new object[5];

            data[0] = txtMaPN.Text;
            data[1] = txtDate.EditValue;
            data[2] = lkeMaDDH.EditValue;
            data[3] = lkeEmployee.EditValue;
            data[4] = lkeDepot.EditValue;

            return data;
        }

        private bool SaveReceivedNote()
      {
         try
         {
            if (IsExistGoodsReceivedNote(txtMaPN.EditValue.ToString()))
            {
               XtraMessageBox.Show(Cons.ErrorDuplicatePNId, Cons.CaptionWarning,
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtMaPN.SelectAll();
               return false;
            }

            SaveALlDataOrderDetailOnView();

                ((DataRowView)_bdsPN[_bdsPN.Position]).Row.ItemArray = GetDataOrder();
                _bdsPN.EndEdit();

                this._taPN.Update(this._dataSet.PhieuNhap);
                this._taCTPN.Update(this._dataSet.CTPN);
                DisableEditMode();
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
            return false;
         }

         return true;
      }

        private void SaveALlDataOrderDetailOnView()
        {
            int orderDetailCount = gvCTPN.DataRowCount;
            ((DataRowView)_bdsCTPN.Current).BeginEdit();
            for (int i = 0; i < orderDetailCount; i++)
            {
                ((DataRowView)_bdsCTPN.Current).Row["MAPN"] = txtMaPN.Text;
                _bdsCTPN.MovePrevious();
            }
            _bdsCTPN.EndEdit();
        }

        private bool IsExistGoodsReceivedNote(string id)
      {
         bool exist = true;
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (SqlCommand sqlcmd = new SqlCommand(MyConfig.ExecSPTimPhieuNhap, connection))
            {
               sqlcmd.CommandType = CommandType.StoredProcedure;
               sqlcmd.Parameters.AddWithValue("@mapn", id);

               try
               {
                  sqlcmd.ExecuteNonQuery();
               }
               catch (SqlException ex)
               {
                  if (ex.Number == MyConfig.ErrorMsgNumNotExistObject)
                     exist = false;
               }
               catch (Exception ex)
               {
                  UtilDB.ShowError(ex);
               }
            }
         }
         return exist;
      }

      private void btnAddCTPN_Click(object sender, EventArgs e)
      {

      }

      private void frmGoodsReceivedNote_Resize(object sender, EventArgs e)
      {
         int Width = (sender as XtraForm).Width;
         if (Width != _backupWidth)
         {
            sccReceived.SplitterPosition = Width / 2;
            _backupWidth = Width;
         }
      }

      private void frmGoodsReceivedNote_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (gbReceivedNote.Enabled == true)
         {
            var result = XtraMessageBox.Show(Cons.AskExitWhileEditing, Cons.CaptionQuestion,
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Question);
            switch (result)
            {
               case DialogResult.Yes:
                  // kiểm tra nút được nhấn [thêm, sửa] => [Lưu lại, update]
                  e.Cancel = !(SaveReceivedNote());
                  break;
               case DialogResult.No:
                  // thoát bất chấp
                  btnCancelEdit.PerformClick();
                  break;
               case DialogResult.Cancel:
                  // hủy thoát
                  e.Cancel = true;
                  break;
               default:
                  break;
            }
         }
      }

        private void btnAddDataRow_Click(object sender, EventArgs e)
        {
            frmSelectMaterials selectMaterials = new frmSelectMaterials();
            selectMaterials.Show(this);
            selectMaterials.FormClosing += (obj, args) =>
            {
                var dsMaterialsId = selectMaterials.selectedMaterialsId;
                foreach (var id in dsMaterialsId)
                {
                    if (IsMaterialExistInView(id) == false)
                    {
                        _bdsCTPN.AddNew();
                        int position = _bdsCTPN.Position;
                        ((DataRowView)_bdsCTPN[position])["MAVT"] = id;
                        ((DataRowView)_bdsCTPN[position])["SOLUONG"] = 0;
                        ((DataRowView)_bdsCTPN[position])["DONGIA"] = 0;
                    }
                }
                _bdsCTPN.EndEdit();
            };
        }

        private bool IsMaterialExistInView(object materialId)
        {
            for (int index = 0; index < gvCTPN.RowCount; index++)
            {
                if (gvCTPN.GetRowCellValue(index, "MAVT").Equals(materialId))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnRemoveDataRow_Click(object sender, EventArgs e)
        {
            _bdsCTPN.RemoveCurrent();
        }
    }
}