using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace QLVT_DATHANG.UserControls
{
   using DevExpress.XtraEditors;
   using DevExpress.XtraGrid.Views.Base;
   using DataSetTableAdapters;
   using DevExpress.XtraEditors.Controls;
   using Utility;
   using Forms;

   public partial class frmAddOrder : XtraUserControl
   {
      private BindingSource _bdsDDH;
      private DatHangTableAdapter _taDDH;
      private BindingSource _bdsCTDDH;
      private CTDDHTableAdapter _taCTDDH;
      private DataSet _dataSet;

      public frmAddOrder(BindingSource bdsDDH, DatHangTableAdapter taDDH
                           , BindingSource bdsCTDDH, CTDDHTableAdapter taCTDDH, DataSet dataSet)
      {
         InitializeComponent();

         _bdsDDH = bdsDDH;
         _taDDH = taDDH;
         _bdsCTDDH = bdsCTDDH;
         _taCTDDH = taCTDDH;
         _dataSet = dataSet;

         this.gcOrderDetail.DataSource = _bdsCTDDH;
         _bdsCTDDH.ListChanged += bdsCTDDH_ListChanged;
      }

      private void bdsCTDDH_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
      {
         if (gvOrderDetail.DataRowCount == 0) btnRemoveLine.Enabled = false;
         else btnRemoveLine.Enabled = true;
      }

      private void frmAddOrder_Load(object sender, EventArgs e)
      {
         LoadTable();
         btnAdd.PerformClick();
      }

      private void LoadTable()
      {
         this.taDSKHO.Connection.ConnectionString =
            this.taDSNCC.Connection.ConnectionString =
            this.taDSNV.Connection.ConnectionString =
            this.taDSVT.Connection.ConnectionString =
            UtilDB.ConnectionString;

         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taDSNCC.Fill(this.dataSet.DSNCC);
            this.taDSNV.Fill(this.dataSet.DSNV);
            this.taDSKHO.Fill(this.dataSet.DSKHO);
            this.taDSVT.Fill(this.dataSet.DSVT);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void gvOrderDetail_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
      {
         ColumnView view = sender as ColumnView;
         if (e.Column.FieldName == "DONGIA" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
         {
            if (!(e.Value is DBNull))
            {
               decimal price = Convert.ToDecimal(e.Value);
               e.DisplayText = string.Format(Cons.CiVNI, "{0:c0}", price);
            }
         }
      }

      private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         if(SaveOrder())
            DisableEditMode();
      }

      private bool SaveOrder()
      {
         try
         {
            if (IsSaveOrder() == false) return false;

            SaveALlDataOrderDetailOnView();

            ((DataRowView)_bdsDDH[_bdsDDH.Position]).Row.ItemArray = GetDataOrder();
            _bdsDDH.EndEdit();

            this._taDDH.Update(this._dataSet.DatHang);
            this._taCTDDH.Update(this._dataSet.CTDDH);
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
         int orderDetailCount = gvOrderDetail.DataRowCount;
         ((DataRowView)_bdsCTDDH.Current).BeginEdit();
         for (int i = 0; i < orderDetailCount; i++)
         {
            ((DataRowView)_bdsCTDDH.Current).Row["MasoDDH"] = txtOrderId.Text;
            _bdsCTDDH.MovePrevious();
         }
         _bdsCTDDH.EndEdit();
      }

      private bool IsSaveOrder()
      {
         if (IsExistOrder(txtOrderId.Text))
         {
            XtraMessageBox.Show(Cons.ErrorDuplicateOrderId, Cons.CaptionWarning,
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtOrderId.Focus();
            txtOrderId.SelectAll();
            return false;
         }

         return true;
      }

      private object[] GetDataOrder()
      {
         object[] data = new object[5];

         data[0] = txtOrderId.Text;
         data[1] = dtpOrderDate.EditValue;
         data[2] = cboNCC.Text;
         data[3] = lkeEmployee.EditValue;
         data[4] = lkeDepot.EditValue;

         return data;
      }

      private bool IsExistOrder(string orderId)
      {
         bool exist = true;
         string strLenh = string.Format(MyConfig.ExecSPTimDDH, orderId);
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (SqlCommand sqlcmd = new SqlCommand(strLenh, connection))
            {
               sqlcmd.CommandType = CommandType.Text;
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

      private void EnableEditMode()
      {
         btnAdd.Enabled = btnEdit.Enabled = btnEdit.Enabled = btnExit.Enabled = false;
         btnSave.Visibility = btnCancelEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

         this.gvOrderDetail.OptionsBehavior.Editable = true;
         gbOrder.Controls.OfType<Control>().Where(c => !(c is LabelControl)).ToList().ForEach(c => c.Enabled = true);

         //pnBtnOrderDetail.Controls.OfType<SimpleButton>().ToList().ForEach(btn => btn.Enabled = true);
         btnAddMaterials.Enabled = true;
      }

      private void DisableEditMode()
      {
         btnAdd.Enabled = btnEdit.Enabled = btnEdit.Enabled = btnExit.Enabled = true;
         btnSave.Visibility = btnCancelEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

         this.gvOrderDetail.OptionsBehavior.Editable = false;
         gbOrder.Controls.OfType<Control>().Where(c => !(c is LabelControl)).ToList().ForEach(c => c.Enabled = false);

         pnBtnOrderDetail.Controls.OfType<SimpleButton>().ToList().ForEach(btn => btn.Enabled = false);
      }

      private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         dtpOrderDate.EditValue = DateTime.Now;
         lkeEmployee.EditValue = int.Parse(UtilDB.UserName);
         cboNCC.SelectedIndex = -1;

         _bdsDDH.AddNew();

         EnableEditMode();
      }

      private void btnCancelEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         ClearData();

         _bdsCTDDH.CancelEdit();
         _bdsDDH.CancelEdit();
         DisableEditMode();
      }

      private void ClearData()
      {
         int addedRow = gvOrderDetail.DataRowCount;
         for (int i = 0; i < addedRow; i++)
         {
            _bdsCTDDH.RemoveCurrent();
         }

         txtOrderId.EditValue = null;
         lkeDepot.EditValue = null;
         cboNCC.SelectedIndex = -1;
      }

      private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         ((Form)this.TopLevelControl).Close();
      }

      private void btnAddMaterials_Click(object sender, EventArgs e)
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
                  _bdsCTDDH.AddNew();
                  int position = _bdsCTDDH.Position;
                  ((DataRowView)_bdsCTDDH[position])["MAVT"] = id;
                  ((DataRowView)_bdsCTDDH[position])["SOLUONG"] = 0;
                  ((DataRowView)_bdsCTDDH[position])["DONGIA"] = 0;
               }
            }
            _bdsCTDDH.EndEdit();
         };
      }

      private void btnRemoveLine_Click(object sender, EventArgs e)
      {
         _bdsCTDDH.RemoveCurrent();
      }

      private void lkeEmployee_EditValueChanged(object sender, EventArgs e)
      {
         txtEmployeeId.EditValue = lkeEmployee.EditValue;
      }

      private void gvOrderDetail_ValidateRow(object sender, ValidateRowEventArgs e)
      {
         object[] data = ((DataRowView)_bdsCTDDH[_bdsCTDDH.Position]).Row.ItemArray;
         // chạy từ 1 để chừa mã ddh ko kiểm tra
         for (int index = 1; index < data.Length; index++)
         {
            if(data[index] is DBNull)
            {
               e.Valid = false;
               e.ErrorText = "Vui lòng nhập đầy đủ thông tin";
               return;
            }
         }
      }

      private bool IsMaterialExistInView(object materialId)
      {
         for (int index = 0; index < gvOrderDetail.RowCount; index++)
         {
            if (gvOrderDetail.GetRowCellValue(index, "MAVT").Equals(materialId))
            {
               return true;
            }
         }
         return false;
      }

      private void gvOrderDetail_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
      {
         var fieldName = gvOrderDetail.FocusedColumn.FieldName;
         switch (fieldName)
         {
            case "MAVT":
               var materialId = e.Value;
               if (materialId == null)
               {
                  e.Valid = false;
                  e.ErrorText = "Vui lòng chọn vật tư";
               }
               for (int index = 0; index < gvOrderDetail.RowCount; index++)
               {
                  if (IsMaterialExistInView(materialId) && gvOrderDetail.GetSelectedRows()[0] != index)
                  {
                     e.Valid = false;
                     e.ErrorText = "Mã vật tư bị trùng";
                     break;
                  }
               }
               break;
            case "SOLUONG":
               int quantity = -1;
               if (int.TryParse(e.Value.ToString(), out quantity) == false)
               {
                  e.Valid = false;
                  e.ErrorText = "Giá trị không hợp lệ";
               }
               else
               {
                  if (quantity <= 0)
                  {
                     e.Valid = false;
                     e.ErrorText = "Số lượng phải lớn hơn 0";
                  }
               }
               break;
            case "DONGIA":
               float donGia = -1;
               if (float.TryParse(e.Value.ToString(), out donGia) == false)
               {
                  e.Valid = false;
                  e.ErrorText = "Giá trị không hợp lệ";
               }
               else
               {
                  if (donGia <= 0)
                  {
                     e.Valid = false;
                     e.ErrorText = "Đơn giá phải lớn hơn 0";
                  }
               }
               break;
            default:
               break;
         }
      }
   }
}