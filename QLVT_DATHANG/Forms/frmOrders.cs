using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
   using DevExpress.XtraEditors;
   using System.Data.SqlClient;
   using System.Drawing;
   using Utility;
   using UserControls;
   using DevExpress.XtraGrid.Views.Base;
   using System.Linq;

   public partial class frmOrders : XtraForm
   {
      private string _currentDeploymentId;

      public frmOrders()
      {
         InitializeComponent();
         SetupControls();
         //gridView1.Columns[0].OptionsColumn.AllowEdit = false;
      }

      private void frmOrders_Load(object sender, EventArgs e)
      {
         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsDDH[0])["MasoDDH"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals(MyConfig.CongTyGroupName))
         {
            UtilDB.SetupDSCN(this.cboDeployment, LoadTable);
            this.pnPickDepartment.Visible = true;
            this.btnAdd.Enabled = false;
         }
      }

      private void SetupControls()
      {
      }

      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taDDH.Connection.ConnectionString =
            this.taCTDDH.Connection.ConnectionString =
            this.taDSVT.Connection.ConnectionString =
            this.taDSKHO.Connection.ConnectionString =
            this.taDSNCC.Connection.ConnectionString =
            this.taDSNV.Connection.ConnectionString =
            this.taDSVT.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;
            this.taDDH.Fill(this.dataSet.DatHang);
            this.taCTDDH.Fill(this.dataSet.CTDDH);
            this.taDSVT.Fill(this.dataSet.DSVT);
            this.taDSNCC.Fill(this.dataSet.DSNCC);
            this.taDSNV.Fill(this.dataSet.DSNV);
            this.taDSKHO.Fill(this.dataSet.DSKHO);
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
         gcOrder.Enabled = false;

         btnAdd.Enabled = false;
         btnExit.Enabled = false;
         btnRefresh.Enabled = false;

         btnCancelEdit.Enabled = true;
         btnCancelEdit.Visibility = BarItemVisibility.Always;

         btnSave.Enabled = true;
         btnSave.Visibility = BarItemVisibility.Always;

         this.gvOrderDetail.OptionsBehavior.Editable = true;
         gbOrder.Controls.OfType<Control>().Where(c => !(c is LabelControl)).ToList().ForEach(c => c.Enabled = true);

         //pnBtnOrderDetail.Controls.OfType<SimpleButton>().ToList().ForEach(btn => btn.Enabled = true);
         btnAddMaterials.Enabled = true;
      }

      private void DisableEditMode()
      {
         gcOrder.Enabled = true;

         btnAdd.Enabled = true;
         btnExit.Enabled = true;
         btnRefresh.Enabled = true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;

         this.gvOrderDetail.OptionsBehavior.Editable = false;
         gbOrder.Controls.OfType<Control>().Where(c => !(c is LabelControl)).ToList().ForEach(c => c.Enabled = false);

         pnBtnOrderDetail.Controls.OfType<SimpleButton>().ToList().ForEach(btn => btn.Enabled = false);
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

      #endregion

      #region EVENTS

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         dtpOrderDate.EditValue = DateTime.Now;
         lkeEmployee.EditValue = int.Parse(UtilDB.UserName);
         cboNCC.SelectedIndex = -1;

         bdsDDH.AddNew();

         EnableEditMode();
      }

      private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
      {
         LoadTable();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         if(SaveOrder())
            DisableEditMode();
      }

      private void btnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         ClearData();

         bdsCTDDH.CancelEdit();
         bdsDDH.CancelEdit();
         DisableEditMode();
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

      private void SaveALlDataOrderDetailOnView()
      {
         int orderDetailCount = gvOrderDetail.DataRowCount;
         ((DataRowView)bdsCTDDH.Current).BeginEdit();
         for (int i = 0; i < orderDetailCount; i++)
         {
            ((DataRowView)bdsCTDDH.Current).Row["MasoDDH"] = txtOrderId.Text;
            bdsCTDDH.MovePrevious();
         }
         bdsCTDDH.EndEdit();
      }

      private bool SaveOrder()
      {
         try
         {
            if (IsSaveOrder() == false) return false;

            SaveALlDataOrderDetailOnView();

            ((DataRowView)bdsDDH[bdsDDH.Position]).Row.ItemArray = GetDataOrder();
            bdsDDH.EndEdit();

            this.taDDH.Update(this.dataSet.DatHang);
            this.taCTDDH.Update(this.dataSet.CTDDH);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
            return false;
         }
         return true;
      }

      private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
      {
         this.Close();
      }

      #endregion

      private void btnAddOrderDetail_Click(object sender, EventArgs e)
      {
         FlyoutAction flyoutAction = new FlyoutAction()
         {
            Caption = Cons.CaptionCreateOrderDetail,
         };

         //string orderId = txtOrderId.EditValue.ToString();
         //using (frmInputOrderDetail inputOrderDetail = new frmInputOrderDetail(orderId, bdsCTDDH, bdsVT, taCTDDH, dataSet))
         //{
         //   CustomFlyoutDialog.ShowForm(this, flyoutAction, inputOrderDetail);
         //   //inputOrderDetail.Disposed += (o, arg) =>
         //   //{
         //   //   try
         //   //   {
         //   //      this.taCTDDH.Update(this.dataSet.CTDDH);
         //   //      this.taVT.Update(this.dataSet.Vattu);
         //   //   }
         //   //   catch (Exception ex)
         //   //   {
         //   //      UtilDB.ShowError(ex);
         //   //   }
         //   //};
         //}
      }

      private void frmOrders_FormClosing(object sender, FormClosingEventArgs e)
      {
         
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

      private void gvOrderDetail_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
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

      private void gvOrderDetail_ValidateRow(object sender, ValidateRowEventArgs e)
      {
         object[] data = ((DataRowView)bdsCTDDH[bdsCTDDH.Position]).Row.ItemArray;
         // chạy từ 1 để chừa mã ddh ko kiểm tra
         for (int index = 1; index < data.Length; index++)
         {
            if (data[index] is DBNull)
            {
               e.Valid = false;
               e.ErrorText = "Vui lòng nhập đầy đủ thông tin";
               return;
            }
         }
      }

      private void lkeEmployee_EditValueChanged(object sender, EventArgs e)
      {
         txtEmployeeId.EditValue = lkeEmployee.EditValue;
      }

      private void ClearData()
      {
         int addedRow = gvOrderDetail.DataRowCount;
         for (int i = 0; i < addedRow; i++)
         {
            bdsCTDDH.RemoveCurrent();
         }

         txtOrderId.EditValue = null;
         lkeDepot.EditValue = null;
         cboNCC.SelectedIndex = -1;
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
                  bdsCTDDH.AddNew();
                  int position = bdsCTDDH.Position;
                  ((DataRowView)bdsCTDDH[position])["MAVT"] = id;
                  ((DataRowView)bdsCTDDH[position])["SOLUONG"] = 0;
                  ((DataRowView)bdsCTDDH[position])["DONGIA"] = 0;
               }
            }
            bdsCTDDH.EndEdit();
         };
      }

      private void btnRemoveLine_Click(object sender, EventArgs e)
      {
         bdsCTDDH.RemoveCurrent();
      }

      private void bdsCTDDH_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
      {
         if (gvOrderDetail.DataRowCount == 0) btnRemoveLine.Enabled = false;
         else
         {
            btnRemoveLine.Enabled = true;
         }
      }

   }
}