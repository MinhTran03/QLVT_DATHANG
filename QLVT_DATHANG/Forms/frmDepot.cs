using QLVT_DATHANG.Utility;
using System;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using System.Data;
   using System.Data.SqlClient;
   using System.Windows.Forms;

   public partial class frmDepot : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;
      private ButtonActionType _buttonAction;
      private MyStack _userDo;

      public frmDepot()
      {
         InitializeComponent();
         SetupControls();
      }

      private void frmDepot_Load(object sender, EventArgs e)
      {
         _buttonAction = ButtonActionType.None;
         _userDo = new MyStack();
         _userDo.StackPushed += userDo_StackPushed;
         _userDo.StackPopped += userDo_StackPopped;

         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsDepot[0])["MACN"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals("congty"))
         {
            UtilDB.SetupDSCN(this.cboDeployment, LoadTable);
            this.pnPickDepartment.Visible = true;
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDel.Enabled = false;
         }
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
         if (_userDo.Count == 1)
         {
            btnUndo.Enabled = true;
         }
      }

      private void EnableEditMode()
      {
         gcDepot.Enabled = false;
         gbDepot.Enabled = true;

         btnAdd.Enabled = false;
         btnDel.Enabled = false;
         btnEdit.Enabled = false;
         btnExit.Enabled = false;
         btnRefresh.Enabled = false;
         btnUndo.Enabled = false;

         btnCancelEdit.Enabled = true;
         btnCancelEdit.Visibility = BarItemVisibility.Always;

         btnSave.Enabled = true;
         btnSave.Visibility = BarItemVisibility.Always;
      }

      private void DisableEditMode()
      {
         btnDel.Enabled = (bdsDepot.Count == 0) ? false : true;
         txtEmpDepartment.ReadOnly = true;

         gcDepot.Enabled = true;
         gbDepot.Enabled = false;

         btnAdd.Enabled = true;
         btnDel.Enabled = true;
         btnEdit.Enabled = true;
         btnExit.Enabled = true;
         btnRefresh.Enabled = true;
         btnUndo.Enabled = (_userDo.Count == 0) ? false : true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;
      }

      private void LoadTable()
      {
         this.taDepot.Connection.ConnectionString =
            this.taCN.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taCN.Fill(this.dataSet.ChiNhanh);

            this.taDepot.Fill(this.dataSet.Kho);

            this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void SetupControls()
      {

      }

      #endregion

      #region EVENTS

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsDepot.Position;
         _buttonAction = ButtonActionType.Add;

         bdsDepot.AddNew();
         txtEmpDepartment.EditValue = _currentDeploymentId;

         EnableEditMode();
         txtDepotId.Focus();
      }

      private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         EditDepot();
      }

      private void btnDel_ItemClick(object sender, ItemClickEventArgs e)
      {
         DeleteDepot();
      }

      private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
      {
         Undo();
      }

      private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
      {
         LoadTable();
      }

      private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
      {
         this.Close();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         SaveDepot();
      }

      #endregion

      private void EditDepot()
      {
         // lưu lại trạng thái nút ấn
         _currentPosition = bdsDepot.Position;
         _buttonAction = ButtonActionType.Edit;

         // lưu lại data để undo
         var row = ((DataRowView)bdsDepot[_currentPosition]).Row.ItemArray;
         _userDo.Push(new ButtonAction(_buttonAction, row));

         EnableEditMode();
      }

      private void DeleteDepot()
      {
         _currentPosition = bdsDepot.Position;

         string ten = ((DataRowView)bdsDepot[_currentPosition])["TENKHO"].ToString();
         var result = XtraMessageBox.Show(string.Format(Cons.AskDeleteDepot, ten), Cons.CaptionWarning,
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

         if (result == DialogResult.Yes)
         {
            try
            {
               // lưu lại data trước khi xóa
               _userDo.Push(new ButtonAction(ButtonActionType.Delete, ((DataRowView)bdsDepot[_currentPosition]).Row.ItemArray));

               //bdsDepot.RemoveCurrent();
               //this.taDepot.Update(this.dataSet.Kho);
               if (UtilDB.DeleteInDB("Kho", "MAKHO", txtDepotId.EditValue))
               {
                  this.dataSet.EnforceConstraints = false;
                  this.taDepot.Fill(this.dataSet.Kho);
               }
            }
            catch (Exception ex)
            {
               UtilDB.ShowError(ex);
            }
         }
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
                  //position = bdsDepot.Find("MAKHO", action.SaveItems[0]);
                  //bdsDepot.Remove((DataRowView)bdsDepot[position]);
                  if (UtilDB.DeleteInDB("Kho", "MAKHO", action.SaveItems[0]))
                  {
                     this.dataSet.EnforceConstraints = false;
                     this.taDepot.Fill(this.dataSet.Kho);
                  }
                  break;
               case ButtonActionType.Edit:
                  // sửa lại dữ liệu cũ
                  position = bdsDepot.Find("MAKHO", action.SaveItems[0]);
                  ((DataRowView)bdsDepot[position]).Row.ItemArray = action.SaveItems;
                  bdsDepot.EndEdit();
                  //bdsNV.ResetCurrentItem();
                  break;
               case ButtonActionType.Delete:
                  // Thêm dữ liệu cũ vào
                  position = bdsDepot.Count;
                  bdsDepot.AddNew();
                  ((DataRowView)bdsDepot[position]).Row.ItemArray = action.SaveItems;
                  bdsDepot.EndEdit();
                  break;
               case ButtonActionType.None:
               default:
                  break;
            }
            this.taDepot.Update(this.dataSet.Kho);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private bool SaveDepot()
      {
         try
         {
            if (_buttonAction == ButtonActionType.Add &&
               IsExistDepot(txtDepotId.EditValue.ToString()))
            {
               XtraMessageBox.Show(Cons.ErrorDuplicateDeportId, Cons.CaptionWarning,
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtDepotId.Focus();
               txtDepotId.SelectAll();
               return false;
            }

            bdsDepot.EndEdit();
            this.taDepot.Update(this.dataSet.Kho);
            gbDepot.Enabled = false;
            bdsDepot.ResetCurrentItem();
            DisableEditMode();
            if (_buttonAction == ButtonActionType.Add)
            {
               // Lưu vô stack trạng thái nút nhấn và data bị thay đổi
               _userDo.Push(new ButtonAction(_buttonAction, ((DataRowView)bdsDepot[bdsDepot.Position]).Row.ItemArray));
            }
            _buttonAction = ButtonActionType.None;
            bdsDepot.Position = _currentPosition;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
            return false;
         }

         return true;
      }

      private bool IsExistDepot(string depotId)
      {
         bool exist = true;
         string strLenh = string.Format(MyConfig.ExecSPTimKho, depotId);
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

      private void btnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         dxErrorProvider.ClearErrors();

         try
         {
            gbDepot.Enabled = false;
            bdsDepot.CancelEdit();
            bdsDepot.ResetCurrentItem();
            bdsDepot.Position = _currentPosition;
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

   }
}
