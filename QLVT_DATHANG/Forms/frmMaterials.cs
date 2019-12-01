using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using System.Collections.Generic;
   using Utility;

   public partial class frmMaterials : XtraForm
   {
      private int _currentPosition;
      private ButtonActionType _buttonAction;
      private MyStack _userDo;

      public frmMaterials()
      {
         InitializeComponent();
         SetupControls();
      }

      private void frmMaterials_Load(object sender, EventArgs e)
      {
         _buttonAction = ButtonActionType.None;
         _userDo = new MyStack();
         _userDo.StackPushed += userDo_StackPushed;
         _userDo.StackPopped += userDo_StackPopped;

         LoadTable();
         DisableEditMode();

         cboDVT.DataSource = GetDanhSachDVT();
      }

      #region METHOD

      private void SetupControls()
      {

      }

      private void userDo_StackPopped(object sender, StackEventAgrs e)
      {
         if (_userDo.Count == 0)
         {
            btnUndo.Enabled = false;
         }
      }

      private void userDo_StackPushed(object sender, StackEventAgrs e)
      {
         btnUndo.Enabled = true;
      }

      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taVT.Connection.ConnectionString =
               this.taCTDDH.Connection.ConnectionString =
               this.taCTPN.Connection.ConnectionString =
               this.taCTPX.Connection.ConnectionString =
                              UtilDB.ConnectionString;

         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taVT.Fill(this.dataSet.Vattu);

            this.taCTDDH.Fill(this.dataSet.CTDDH);

            this.taCTPX.Fill(this.dataSet.CTPX);

            this.taCTPN.Fill(this.dataSet.CTPN);

            //this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void EnableEditMode()
      {
         gcVT.Enabled = false;
         gbVT.Enabled = true;

         btnAdd.Enabled = false;
         btnDel.Enabled = false;
         btnEdit.Enabled = false;
         btnExit.Enabled = false;
         btnReload.Enabled = false;
         btnUndo.Enabled = false;

         btnCancelEdit.Enabled = true;
         btnCancelEdit.Visibility = BarItemVisibility.Always;

         btnSave.Enabled = true;
         btnSave.Visibility = BarItemVisibility.Always;
      }

      private void DisableEditMode()
      {
         btnDel.Enabled = (bdsVT.Count == 0) ? false : true;

         gcVT.Enabled = true;
         gbVT.Enabled = false;

         btnAdd.Enabled = true;
         btnDel.Enabled = true;
         btnEdit.Enabled = true;
         btnExit.Enabled = true;
         btnReload.Enabled = true;
         btnUndo.Enabled = (_userDo.Count == 0) ? false : true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;
      }

      private bool IsExistMaterial(string materialId)
      {
         string strLenh = string.Format(MyConfig.ExecSPTimVatTu, materialId);
         bool exist = true;
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
            sqlcmd.CommandType = CommandType.Text;
            try
            {
               SqlDataReader myreader = sqlcmd.ExecuteReader();
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
         return exist;
      }

      private bool SaveMaterials()
      {
         try
         {
            if (_buttonAction == ButtonActionType.Add &&
               IsExistMaterial(txtMaterialId.EditValue.ToString()))
            {
               XtraMessageBox.Show(Cons.ErrorDuplicateMaterialId, Cons.CaptionWarning,
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtMaterialId.Focus();
               return false;
            }

            bdsVT.EndEdit();
            this.taVT.Update(this.dataSet.Vattu);
            gbVT.Enabled = false;
            bdsVT.ResetCurrentItem();
            DisableEditMode();
            if (_buttonAction == ButtonActionType.Add)
            {
               // Lưu vô stack trạng thái nút nhấn và data bị thay đổi
               _userDo.Push(new ButtonAction(_buttonAction, ((DataRowView)bdsVT[bdsVT.Position]).Row.ItemArray));
            }
            _buttonAction = ButtonActionType.None;
            bdsVT.Position = _currentPosition;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
            return false;
         }
         return true;
      }

      private void Undo()
      {
         ButtonAction action = (ButtonAction)_userDo.Pop();
         int position = -1;

         try
         {
            switch (action.ActionType)
            {
               case ButtonActionType.Add:
                  // xóa dữ liệu mới
                  //position = bdsVT.Find("MAVT", action.SaveItems[0]);
                  //bdsVT.Remove((DataRowView)bdsVT[position]);
                  if (UtilDB.DeleteInDB("Vattu", "MAVT", action.SaveItems[0]))
                  {
                     this.dataSet.EnforceConstraints = false;
                     this.taVT.Fill(this.dataSet.Vattu);
                  }
                  break;
               case ButtonActionType.Edit:
                  // sửa lại dữ liệu cũ
                  position = bdsVT.Find("MAVT", action.SaveItems[0]);
                  ((DataRowView)bdsVT[position]).Row.ItemArray = action.SaveItems;
                  bdsVT.EndEdit();
                  //bdsNV.ResetCurrentItem();
                  break;
               case ButtonActionType.Delete:
                  // Thêm dữ liệu cũ vào
                  position = bdsVT.Count;
                  bdsVT.AddNew();
                  ((DataRowView)bdsVT[position]).Row.ItemArray = action.SaveItems;
                  bdsVT.EndEdit();
                  break;
               case ButtonActionType.None:
               default:
                  break;
            }
            this.taVT.Update(this.dataSet.Vattu);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private List<string> GetDanhSachDVT()
      {
         using (var connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (var command = new SqlCommand(MyConfig.SpGetDanhSachDVT, connection))
            {
               command.CommandType = CommandType.StoredProcedure;

               using (SqlDataReader reader = command.ExecuteReader())
               {
                  List<string> dsDVT = new List<string>();
                  while (reader.Read())
                  {
                     dsDVT.Add(reader.GetString(0));
                  }
                  return dsDVT;
               }
            }
         }
      }

      #endregion

      #region EVENTS

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _buttonAction = ButtonActionType.Add;
         _currentPosition = bdsVT.Position;

         bdsVT.AddNew();
         EnableEditMode();

         txtMaterialId.Focus();
      }

      private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         _buttonAction = ButtonActionType.Edit;
         _currentPosition = bdsVT.Position;
         var row = ((DataRowView)bdsVT[_currentPosition]).Row.ItemArray;

         _userDo.Push(new ButtonAction(_buttonAction, row));
         EnableEditMode();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         SaveMaterials();
         cboDVT.DataSource = GetDanhSachDVT();
      }

      private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
      {
         Undo();
         cboDVT.DataSource = GetDanhSachDVT();
      }

      private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
      {
         this.Close();
      }

      private void btnReload_ItemClick(object sender, ItemClickEventArgs e)
      {
         LoadTable();
      }

      private void btnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         dxErrorProvider.ClearErrors();

         try
         {
            gbVT.Enabled = false;
            bdsVT.CancelEdit();
            bdsVT.ResetCurrentItem();
            bdsVT.Position = _currentPosition;
            if (_buttonAction == ButtonActionType.Edit)
               _userDo.Pop();
            _buttonAction = ButtonActionType.None;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
         DisableEditMode();
      }

      private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
      {
         string constraint = CheckConstraint();
         if (constraint != null)
         {
            string text = string.Format(Cons.ErrorDeleteMaterial, constraint);
            XtraMessageBox.Show(text, Cons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         _currentPosition = bdsVT.Position;

         string ten = ((DataRowView)bdsVT[_currentPosition])["TENVT"].ToString();
         var result = XtraMessageBox.Show(string.Format(Cons.AskDeleteMaterials, ten), Cons.CaptionQuestion,
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

         if (result == DialogResult.Yes)
         {
            try
            {
               // lưu lại data trước khi xóa
               _userDo.Push(new ButtonAction(ButtonActionType.Delete, ((DataRowView)bdsVT[_currentPosition]).Row.ItemArray));

               //bdsVT.RemoveCurrent();
               //this.taVT.Update(this.dataSet.Vattu);
               if (UtilDB.DeleteInDB("Vattu", "MAVT", txtMaterialId.EditValue))
               {
                  this.dataSet.EnforceConstraints = false;
                  this.taVT.Fill(this.dataSet.Vattu);
               }
            }
            catch (Exception ex)
            {
               UtilDB.ShowError(ex);
            }
         }

         cboDVT.DataSource = GetDanhSachDVT();
      }

      private string CheckConstraint()
      {
         string message = null;
         if (bdsCTDDH.Count > 0)
         {
            message = Cons.DonDatHang;
         }
         else if (bdsCTPN.Count > 0)
         {
            message = Cons.PhieuLap;
         }
         else if (bdsCTPX.Count > 0)
         {
            message = Cons.PhieuXuat;
         }
         return message;
      }

      #endregion

      private void frmMaterials_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (gbVT.Enabled == true)
         {
            var result = XtraMessageBox.Show(Cons.AskExitWhileEditing, Cons.CaptionQuestion,
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Question);
            switch (result)
            {
               case DialogResult.Yes:
                  // kiểm tra nút được nhấn [thêm, sửa] => [Lưu lại, update]
                  e.Cancel = !(SaveMaterials());
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
   }
}
