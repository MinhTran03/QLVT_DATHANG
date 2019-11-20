using QLVT_DATHANG.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.Utils;
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using DevExpress.XtraEditors.Mask;

   public partial class frmMaterials : XtraForm
   {
      private string _currentDeploymentId;
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

         LoadTable();
         EnableForm();

         _currentDeploymentId = ((DataRowView)bdsVT[0])["MAVT"].ToString().Trim();
      }

      #region METHOD

      private void SetupControls()
      {
         string nameRegex = "[\u0000-\u001F\007F-\u009F]+(\\s{1}[\u0000-\u001F\007F-\u009F]+)*"; // regex with one space between 2 character

         txtMaterialName.Properties.Mask.MaskType = MaskType.None;
         txtMaterialName.Properties.Mask.EditMask = nameRegex;
         txtMaterialName.Properties.Mask.BeepOnError = true;
         txtMaterialName.Properties.AllowNullInput = DefaultBoolean.True;

         spiSLT.Properties.Mask.MaskType = MaskType.Numeric;
         spiSLT.Properties.Increment = 1;
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

      private void DisableForm()
      {
         btnDel.Enabled = (bdsVT.Count == 0) ? false : true;

         gcVT.Enabled = false;
         gbVT.Enabled = true;

         btnAdd.Enabled = false;
         btnEdit.Enabled = false;
         btnDel.Enabled = false;
         btnReload.Enabled = false;
         btnExit.Enabled = false;

         btnCancelEdit.Enabled = true;
         btnCancelEdit.Visibility = BarItemVisibility.Always;

         btnSave.Enabled = true;
         btnSave.Visibility = BarItemVisibility.Always;

         btnUndo.Enabled = true;
         btnUndo.Visibility = BarItemVisibility.Always;
      }

      private void EnableForm()
      {
         gbVT.Enabled = false;
         gcVT.Enabled = true;

         btnAdd.Enabled = true;
         btnEdit.Enabled = true;
         btnDel.Enabled = true;
         btnExit.Enabled = true;
         btnReload.Enabled = true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;

         btnUndo.Enabled = false;
         btnUndo.Visibility = BarItemVisibility.Never;
      }

      private bool IsExistMaterial(string departmentId)
      {
         string strLenh = string.Format(MyConfig.ExecSPTimVatTu, departmentId);
         bool exist = false;
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
            sqlcmd.CommandType = CommandType.Text;
            try
            {
               SqlDataReader myreader = sqlcmd.ExecuteReader();
               exist = true;
            }
            catch (Exception ex)
            {
               if (ex is SqlException && (ex as SqlException).Class == MyConfig.ErrorCodeDatabase)
                  exist = false;
               else
                  UtilDB.ShowError(ex);
            }
         }
         return exist;
      }

      private bool SaveMaterials()
      {
         try
         {
            if (_buttonAction == ButtonActionType.Add)
            {
               if (IsExistMaterial(txtMaterialId.EditValue.ToString()))
               {
                  XtraMessageBox.Show("Mã vật tư đã tồn tại");
                  txtMaterialId.Focus();
                  return false;
               }
               else
               {
                  _userDo.Push(new ButtonAction(_buttonAction, ((DataRowView)bdsVT[bdsVT.Position]).Row.ItemArray));

                  _buttonAction = ButtonActionType.None;

                  bdsVT.EndEdit();
                  gbVT.Enabled = false;
                  bdsVT.ResetCurrentItem();
                  this.taVT.Update(this.dataSet.Vattu);
               }

            }
            else
            {
               bdsVT.EndEdit();
               gbVT.Enabled = false;
               bdsVT.ResetCurrentItem();
               this.taVT.Update(this.dataSet.Vattu);
            }

         }
         catch (Exception ex)
         {
            // #load lại từ database
            dataSet.EnforceConstraints = false;

            this.taVT.Fill(this.dataSet.Vattu);

            //dataSet.EnforceConstraints = true;
            UtilDB.ShowError(ex);
            return false;
         }
         bdsVT.Position = _currentPosition;
         EnableForm();
         return true;
      }

      private void Undo()
      {
         ButtonAction action = (ButtonAction)_userDo.Pop();
         switch (action.ActionType)
         {
            case ButtonActionType.Add:
               // xóa dữ liệu mới
               bdsVT.Remove(action.SaveItems);
               break;
            case ButtonActionType.Edit:
               // sửa lại dữ liệu cũ
               //((DataRowView)bdsNV[5]) = action.SaveDataRow;
               break;
            case ButtonActionType.None:
               break;
            default:
               break;
         }
         this.taVT.Update(this.dataSet.Vattu);
      }

      #endregion

      #region EVENTS

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _buttonAction = ButtonActionType.Add;
         _currentPosition = bdsVT.Position;

         bdsVT.AddNew();
         DisableForm();
         txtMaterialId.Focus();
      }

      private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         _buttonAction = ButtonActionType.Edit;
         _currentPosition = bdsVT.Position;
         DisableForm();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         SaveMaterials();
      }

      private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
      {
         Undo();
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
         try
         {
            bdsVT.CancelEdit();
            bdsVT.ResetCurrentItem();
            bdsVT.Position = _currentPosition;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
         EnableForm();
      }

      private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsVT.Position;
         string ten = ((DataRowView)bdsVT[_currentPosition])["TENVT"].ToString();
         var result = XtraMessageBox.Show(string.Format(Cons.AskDeleteMaterials, ten), Cons.CaptionQuestion,
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (result == DialogResult.Yes)
         {
            try
            {
               bdsVT.RemoveCurrent();
               this.taVT.Update(this.dataSet.Vattu);
            }
            catch (Exception ex)
            {
               UtilDB.ShowError(ex);
            }
         }
      }

      #endregion
   }
}
