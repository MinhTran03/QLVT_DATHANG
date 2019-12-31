using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using DevExpress.XtraGrid.Views.Base;
   using Utility;

   public partial class frmGoodsDeliveryNote : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;

      public frmGoodsDeliveryNote()
      {
         InitializeComponent();

         SetupControls();
      }

      private void frmGoodsDeliveryNote_Load(object sender, EventArgs e)
      {
         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsPX[0])["MAPX"].ToString().Trim();

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
         //string nameRegex = "[\u0000-\u001F\007F-\u009F]+(\\s{1}[\u0000-\u001F\007F-\u009F]+)*"; // regex with one space between 2 character

         //txtEmpId.Properties.Mask.MaskType = MaskType.RegEx;
         //txtEmpId.Properties.Mask.EditMask = "\\d+";
         //txtEmpId.Properties.Mask.BeepOnError = true;
         //txtEmpId.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpId.Properties.NullValuePrompt = "Id here";

         //txtEmpFirstName.Properties.Mask.MaskType = MaskType.None;
         //txtEmpFirstName.Properties.Mask.EditMask = nameRegex;
         //txtEmpFirstName.Properties.Mask.BeepOnError = true;
         //txtEmpFirstName.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpFirstName.Properties.NullValuePrompt = "First name here";

         //txtEmpLastName.Properties.Mask.MaskType = MaskType.None;
         //txtEmpLastName.Properties.Mask.EditMask = nameRegex;
         //txtEmpLastName.Properties.Mask.BeepOnError = true;
         //txtEmpLastName.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpLastName.Properties.NullValuePrompt = "Last name here";

         //txtEmpAddr.Properties.Mask.BeepOnError = true;
         //txtEmpAddr.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpAddr.Properties.NullValuePrompt = "Address here";

         //spiEmpSalary.Properties.Mask.MaskType = MaskType.Numeric;
         ////spiEmpSalary.Properties.MinValue = CommonCons.MinSalary;
         //spiEmpSalary.Properties.Increment = 100000;
         //spiEmpSalary.Properties.Mask.BeepOnError = true;
         //spiEmpSalary.Properties.AllowNullInput = DefaultBoolean.True;
         ////spiEmpSalary.Properties.NullValuePrompt = $"Min {CommonCons.MinSalary}";

         //dtpEmpBirth.Properties.Mask.MaskType = MaskType.DateTime;
         //dtpEmpBirth.Properties.Mask.EditMask = "dd//MM//yyyy";
         //dtpEmpBirth.Properties.MaxValue = DateTime.Today.AddDays(-1);
         //dtpEmpBirth.Properties.Mask.BeepOnError = true;
         //dtpEmpBirth.Properties.AllowNullInput = DefaultBoolean.True;
         ////dtpEmpBirth.Properties.NullValuePrompt = "Pick a day";
      }

      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taPX.Connection.ConnectionString =
                this.taDSNV.Connection.ConnectionString =
                this.taCTPX.Connection.ConnectionString =
                this.taDSKHO.Connection.ConnectionString =
                this.taDSVTCH.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taPX.Fill(this.dataSet.PhieuXuat);

            this.taCTPX.Fill(this.dataSet.CTPX);

            this.taDSNV.Fill(this.dataSet.DSNV);

            this.taDSKHO.Fill(this.dataSet.DSKHO);

            this.taDSVTCH.Fill(this.dataSet.DSVTCONHANG);

            //this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void EnableEditMode()
      {
         gcDeliveryNote.Enabled = false;

         btnAdd.Enabled = false;
         btnExit.Enabled = false;
         btnRefresh.Enabled = false;

         btnCancelEdit.Enabled = true;
         btnCancelEdit.Visibility = BarItemVisibility.Always;

         btnSave.Enabled = true;
         btnSave.Visibility = BarItemVisibility.Always;

         gvCTPX.OptionsBehavior.Editable = true;
         gbDeliveryNote.Controls.OfType<Control>().Where(c => !(c is LabelControl)).ToList().ForEach(c => c.Enabled = true);

         //pnBtnOrderDetail.Controls.OfType<SimpleButton>().ToList().ForEach(btn => btn.Enabled = true);
         btnAddDataRow.Enabled = true;
      }

      private void DisableEditMode()
      {
         gcDeliveryNote.Enabled = true;

         btnAdd.Enabled = true;
         btnExit.Enabled = true;
         btnRefresh.Enabled = true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;

         this.gvCTPX.OptionsBehavior.Editable = false;
         gbDeliveryNote.Controls.OfType<Control>().Where(c => !(c is LabelControl)).ToList().ForEach(c => c.Enabled = false);

         btnAddDataRow.Enabled = false;
         btnRemoveLine.Enabled = false;
      }

      private bool SaveDeliveryNote()
      {
         try
         {
            txtCustomerName.Text = txtCustomerName.Text.Trim();

            if (IsSaveGoodsDeliveryNote() == false) return false;

            SaveALlDataDetail();

            ((DataRowView)bdsPX.Current).Row.ItemArray = GetDataOrder();
            bdsPX.EndEdit();

            UtilDB.UpdateWithTransaction(() =>
            {
               this.taPX.Update(this.dataSet.PhieuXuat);
               this.taCTPX.Update(this.dataSet.CTPX);
            }, taPX, taCTPX);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
            // xử lý tạm thời
            DisableEditMode();
            btnRefresh.PerformClick();
            return false;
         }
         return true;
      }

      private object[] GetDataOrder()
      {
         object[] data = new object[5];

         data[0] = txtId.Text;
         data[1] = dtpDate.EditValue;
         data[2] = txtCustomerName.Text;
         data[3] = lkeEmployee.EditValue;
         data[4] = lkeMaKho.EditValue;

         return data;
      }

      private void SaveALlDataDetail()
      {
         int orderDetailCount = gvCTPX.DataRowCount;
         ((DataRowView)bdsCTPX.Current).BeginEdit();
         for (int i = 0; i < orderDetailCount; i++)
         {
            ((DataRowView)bdsCTPX.Current).Row["MAPX"] = txtId.Text;
            bdsCTPX.MovePrevious();
         }
         bdsCTPX.EndEdit();
      }

      private bool IsSaveGoodsDeliveryNote()
      {
         if (IsExistGoodsDeliveryNote(txtId.Text))
         {
            XtraMessageBox.Show(Cons.ErrorDuplicateDeliveryNoteId, Cons.CaptionError,
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtId.Focus();
            txtId.SelectAll();
            return false;
         }
         if (!IsValidEmptyValue())
         {
            (dxErrorProvider.GetControlsWithError()[0] as BaseEdit).SelectAll();
            return false;
         }
         return true;
      }

      private bool IsExistGoodsDeliveryNote(string id)
      {
         bool exist = false;
         string strLenh = string.Format(MyConfig.ExecSPTimPhieuXuat, id);
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (SqlCommand sqlcmd = new SqlCommand(strLenh, connection))
            {
               sqlcmd.CommandType = CommandType.Text;
               try
               {
                  sqlcmd.ExecuteNonQuery();
                  exist = true;
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

      private bool IsMaterialExistInView(object materialId)
      {
         for (int index = 0; index < gvCTPX.RowCount; index++)
         {
            if (gvCTPX.GetRowCellValue(index, "MAVT").Equals(materialId))
            {
               return true;
            }
         }
         return false;
      }

      #endregion

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsPX.Position;

         bdsPX.AddNew();

         dtpDate.EditValue = DateTime.Now;
         lkeEmployee.EditValue = int.Parse(UtilDB.UserName);

         EnableEditMode();
         txtId.Focus();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (SaveDeliveryNote())
            DisableEditMode();
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
            bdsPX.CancelEdit();
            bdsPX.ResetCurrentItem();
            bdsPX.Position = _currentPosition;

            bdsCTPX.CancelEdit();

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

      private void btnAddCTPX_Click(object sender, EventArgs e)
      {

      }

      private void frmGoodsDeliveryNote_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (btnAdd.Enabled == false)
         {
            var result = XtraMessageBox.Show(Cons.AskExitWhileEditing, Cons.CaptionQuestion,
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Question);
            switch (result)
            {
               case DialogResult.Yes:
                  // kiểm tra nút được nhấn [thêm, sửa] => [Lưu lại, update]
                  e.Cancel = !(SaveDeliveryNote());
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

      private void btnRemoveDataRow_Click(object sender, EventArgs e)
      {
         bdsCTPX.RemoveCurrent();
      }

      private void btnAddDateRow_Click(object sender, EventArgs e)
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
                  bdsCTPX.AddNew();
                  int position = bdsCTPX.Position;
                  ((DataRowView)bdsCTPX[position])["MAVT"] = id;
                  ((DataRowView)bdsCTPX[position])["SOLUONG"] = 1;
                  ((DataRowView)bdsCTPX[position])["DONGIA"] = 0;
               }
            }
            bdsCTPX.EndEdit();
         };
      }

      private void bdsCTPX_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
      {
         if (bdsCTPX.Count == 0 || btnAdd.Enabled == true) btnRemoveLine.Enabled = false;
         else
         {
            btnRemoveLine.Enabled = true;
         }
      }

      private void gvCTPX_ValidateRow(object sender, ValidateRowEventArgs e)
      {
         object[] data = ((DataRowView)bdsCTPX.Current).Row.ItemArray;
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

      private void gvCTPX_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
      {
         var fieldName = gvCTPX.FocusedColumn.FieldName;
         switch (fieldName)
         {
            case "MAVT":
               object materialId = e.Value;
               if (materialId == null)
               {
                  e.Valid = false;
                  e.ErrorText = "Vui lòng chọn vật tư";
               }
               for (int index = 0; index < gvCTPX.RowCount; index++)
               {
                  if (IsMaterialExistInView(materialId) && gvCTPX.GetSelectedRows()[0] != index)
                  {
                     e.Valid = false;
                     e.ErrorText = "Mã vật tư bị trùng";
                     break;
                  }
               }
               if (e.Valid == true)
               {
                  ((DataRowView)bdsCTPX.Current)["SOLUONG"] = 1;
                  ((DataRowView)bdsCTPX.Current)["DONGIA"] = 0;
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
                  var maVT = ((DataRowView)bdsCTPX.Current)["MAVT"].ToString();
                  for (int index = 0; index < bdsDSVTCH.Count; index++)
                  {
                     var current = ((DataRowView)bdsDSVTCH[index]);
                     if (current["MAVT"].ToString().Equals(maVT)
                        && quantity > int.Parse(current["SOLUONGTON"].ToString()))
                     {
                        e.Valid = false;
                        e.ErrorText = "Số lượng quá lớn...";
                        break;
                     }
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
                  if (donGia < 0)
                  {
                     e.Valid = false;
                     e.ErrorText = "Đơn giá phải lớn hơn hoặc bằng 0";
                  }
               }
               break;
            default:
               break;
         }
      }

      private void gvCTPX_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
      {
         ColumnView view = sender as ColumnView;
         if ((e.Column.FieldName == "DONGIA" || e.Column.FieldName == "THANHTIEN") && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
         {
            if (!(e.Value is DBNull))
            {
               decimal price = Convert.ToDecimal(e.Value);
               e.DisplayText = string.Format(Cons.CiVNI, "{0:c0}", price);
            }
         }
      }

      private bool IsValidEmptyValue()
      {
         dxErrorProvider.ClearErrors();

         var controlsNotValid = gbDeliveryNote.Controls.OfType<BaseEdit>().Where(c => string.IsNullOrWhiteSpace(c.Text));

         controlsNotValid.ToList().ForEach(c =>
         {
            dxErrorProvider.SetError(c, Cons.ErrorNotNull);
         });

         return !dxErrorProvider.HasErrors;
      }

   }
}