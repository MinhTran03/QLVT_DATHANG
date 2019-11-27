using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.Utils;
   using DevExpress.XtraBars;
   using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
   using DevExpress.XtraEditors;
   using DevExpress.XtraEditors.Controls;
   using DevExpress.XtraEditors.Mask;
   using DevExpress.XtraGrid.Views.Base;
   using UserControls;
   using Utility;

   public partial class frmEmployee : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;
      private ButtonActionType _buttonAction;
      private MyStack _userDo;

      public frmEmployee()
      {
         InitializeComponent();
         SetupControls();
      }

      private void frmEmployee_Load(object sender, EventArgs e)
      {
         _buttonAction = ButtonActionType.None;
         _userDo = new MyStack();
         _userDo.StackPushed += userDo_StackPushed;
         _userDo.StackPopped += userDo_StackPopped;

         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsNV[0])["MACN"].ToString().Trim();

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
            this.btnEdit.Enabled = false;
            this.btnDel.Enabled = false;
            this.btnSwitchDepartment.Enabled = false;
         }
         else if (grName.Equals(MyConfig.UserGroupName))
         {
            btnCreateLogin.Visible = false;
         }
      }

      private void SetupControls()
      {
         string nameRegex = "[\\p{L}]+(\\s{1}[\\p{L}]+)*"; // regex with one space between 2 character

         txtEmpId.Properties.Mask.MaskType = MaskType.RegEx;
         txtEmpId.Properties.Mask.EditMask = "\\d+";
         txtEmpId.Properties.Mask.BeepOnError = true;
         txtEmpId.Properties.AllowNullInput = DefaultBoolean.True;
         txtEmpId.Properties.NullText = "Ma nhan vien la tu dong";
         txtEmpId.ReadOnly = true;

         txtEmpFirstName.Properties.Mask.MaskType = MaskType.None;
         txtEmpFirstName.Properties.Mask.EditMask = nameRegex;
         txtEmpFirstName.Properties.Mask.BeepOnError = true;
         txtEmpFirstName.Properties.AllowNullInput = DefaultBoolean.True;
         ////txtEmpFirstName.Properties.NullValuePrompt = "First name here";

         txtEmpLastName.Properties.Mask.MaskType = MaskType.None;
         txtEmpLastName.Properties.Mask.EditMask = nameRegex;
         txtEmpLastName.Properties.Mask.BeepOnError = true;
         txtEmpLastName.Properties.AllowNullInput = DefaultBoolean.True;
         ////txtEmpLastName.Properties.NullValuePrompt = "Last name here";

         txtEmpAddr.Properties.Mask.BeepOnError = true;
         txtEmpAddr.Properties.AllowNullInput = DefaultBoolean.True;
         ////txtEmpAddr.Properties.NullValuePrompt = "Address here";

         spiEmpSalary.Properties.Mask.MaskType = MaskType.Numeric;
         //spiEmpSalary.Properties.MinValue = CommonCons.MinSalary;
         spiEmpSalary.Properties.Increment = 100000;
         spiEmpSalary.Properties.Mask.BeepOnError = true;
         spiEmpSalary.Properties.AllowNullInput = DefaultBoolean.True;
         //spiEmpSalary.Properties.NullValuePrompt = $"Min {CommonCons.MinSalary}";

         dtpEmpBirth.Properties.Mask.MaskType = MaskType.DateTime;
         dtpEmpBirth.Properties.Mask.EditMask = "dd/MM/yyyy";
         dtpEmpBirth.Properties.MaxValue = DateTime.Today.AddDays(-1);
         dtpEmpBirth.Properties.Mask.BeepOnError = true;
         dtpEmpBirth.Properties.AllowNullInput = DefaultBoolean.True;
         //dtpEmpBirth.Properties.NullValuePrompt = "Pick a day";
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
         this.taNV.Connection.ConnectionString =
            this.taCN.Connection.ConnectionString =
            this.taDH.Connection.ConnectionString =
            this.taPN.Connection.ConnectionString =
            this.taPX.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dataSet.ChiNhanh' table. You can move, or remove it, as needed.
            this.taCN.Fill(this.dataSet.ChiNhanh);

            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            this.taNV.Fill(this.dataSet.NhanVien);

            // TODO: This line of code loads data into the 'dataSet.DatHang' table. You can move, or remove it, as needed.
            this.taDH.Fill(this.dataSet.DatHang);

            // TODO: This line of code loads data into the 'dataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.taPX.Fill(this.dataSet.PhieuXuat);

            // TODO: This line of code loads data into the 'dataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.taPN.Fill(this.dataSet.PhieuNhap);

            this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void EnableEditMode()
      {
         gcEmployee.Enabled = false;
         gbEmployee.Enabled = true;

         btnAdd.Enabled = false;
         btnDel.Enabled = false;
         btnEdit.Enabled = false;
         btnExit.Enabled = false;
         btnRefresh.Enabled = false;
         btnUndo.Enabled = false;
         btnSwitchDepartment.Enabled = false;

         btnCancelEdit.Enabled = true;
         btnCancelEdit.Visibility = BarItemVisibility.Always;

         btnSave.Enabled = true;
         btnSave.Visibility = BarItemVisibility.Always;
      }

      private void DisableEditMode()
      {
         btnDel.Enabled = (bdsNV.Count == 0) ? false : true;
         txtEmpDelStatus.ReadOnly = true;
         txtEmpDepartment.ReadOnly = true;

         gcEmployee.Enabled = true;
         gbEmployee.Enabled = false;

         btnAdd.Enabled = true;
         btnDel.Enabled = true;
         btnEdit.Enabled = true;
         btnExit.Enabled = true;
         btnRefresh.Enabled = true;
         btnUndo.Enabled = (_userDo.Count == 0) ? false : true;
         btnSwitchDepartment.Enabled = true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;
      }

      private void Undo()
      {
         ButtonAction action = (ButtonAction)_userDo.Pop();
         int position = -1;

         switch (action.ActionType)
         {
            case ButtonActionType.Add:
               // xóa dữ liệu mới
               position = bdsNV.Find("MANV", action.SaveItems[0]);
               bdsNV.Remove((DataRowView)bdsNV[position]);
               break;
            case ButtonActionType.Edit:
               // sửa lại dữ liệu cũ
               position = bdsNV.Find("MANV", action.SaveItems[0]);
               ((DataRowView)bdsNV[position]).Row.ItemArray = action.SaveItems;
               bdsNV.EndEdit();
               //bdsNV.ResetCurrentItem();
               break;
            case ButtonActionType.Delete:
               // Thêm dữ liệu cũ vào
               position = bdsNV.Count;
               bdsNV.AddNew();
               ((DataRowView)bdsNV[position]).Row.ItemArray = action.SaveItems;
               bdsNV.EndEdit();
               break;
            case ButtonActionType.None:
            default:
               break;
         }
         this.taNV.Update(this.dataSet.NhanVien);
      }

      private bool SaveEmployee()
      {
         // sinh ma nv tu dong
         txtEmpId.EditValue = UtilDB.GenerateEmployeeId();

         if (!IsValidEmptyValue())
         {
            (dxErrorProvider.GetControlsWithError()[0] as BaseEdit).SelectAll();
            return false;
         }
         try
         {
            if (_buttonAction == ButtonActionType.Add)
            {
               if (IsExistEmployee(int.Parse(txtEmpId.EditValue.ToString())))
               {
                  XtraMessageBox.Show(Cons.ErrorDuplicateEmpoyeeId, Cons.CaptionWarning,
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  txtEmpId.SelectAll();
                  return false;
               }

               // Lưu vô stack trạng thái nút nhấn và data bị mới
               _userDo.Push(new ButtonAction(_buttonAction, ((DataRowView)bdsNV[bdsNV.Position]).Row.ItemArray));
            }

            EndEdit();
         }
         catch (Exception ex)
         {
            // #load lại từ database
            dataSet.EnforceConstraints = false;
            this.taNV.Fill(this.dataSet.NhanVien);
            dataSet.EnforceConstraints = true;

            UtilDB.ShowError(ex);
            return false;
         }
         return true;
      }

      private void EndEdit()
      {
         try
         {
            bdsNV.EndEdit();
            gbEmployee.Enabled = false;
            //bdsNV.ResetCurrentItem();
            this.taNV.Update(this.dataSet.NhanVien);
            _buttonAction = ButtonActionType.None;
            bdsNV.Position = _currentPosition;
            DisableEditMode();
         }
         catch (Exception e)
         {
            throw e;
         }
      }

      private void EditEmployee()
      {
         // lưu lại trạng thái nút ấn
         _currentPosition = bdsNV.Position;
         _buttonAction = ButtonActionType.Edit;

         // lưu lại data để undo
         var row = ((DataRowView)bdsNV[_currentPosition]).Row.ItemArray;
         _userDo.Push(new ButtonAction(_buttonAction, row));

         EnableEditMode();
      }

      private void DeleteEmployee(int position)
      {
         string phieuLap = CheckPhieuDaLap();
         if (phieuLap != null)
         {
            string text = string.Format(Cons.ErrorDeleteEmployee, phieuLap);
            XtraMessageBox.Show(text, Cons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         else if (txtEmpDelStatus.Text.Equals("1"))
         {
            XtraMessageBox.Show(Cons.ErrorDeleteSwitchedEmployee, Cons.CaptionError,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         string ho = txtEmpFirstName.Text;
         string ten = txtEmpLastName.Text;
         var result = XtraMessageBox.Show(string.Format(Cons.AskDeleteEmployee, ho, ten), Cons.CaptionWarning,
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

         if (result == DialogResult.Yes)
         {
            try
            {
               // lưu lại data trước khi xóa
               _userDo.Push(new ButtonAction(ButtonActionType.Delete, ((DataRowView)bdsNV[position]).Row.ItemArray));

               bdsNV.RemoveCurrent();
               this.taNV.Update(this.dataSet.NhanVien);
            }
            catch (Exception ex)
            {
               UtilDB.ShowError(ex);
            }
         }
      }

      private void RemoveLoginInStack()
      {
         while (_userDo.Count > 0)
         {
            ButtonAction action = (ButtonAction)_userDo.Pop();
            if (action.ActionType == ButtonActionType.Delete)
            {
               object[] data = action.SaveItems;
               RemoveLogin(data[0].ToString());
            }
         }
      }

      private bool RemoveLogin(string employeeId)
      {
         bool isSuccess = false;
         string strLenh = string.Format(MyConfig.ExecSPXoaLogin, employeeId);
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (SqlCommand sqlcmd = new SqlCommand(strLenh, connection))
            {
               sqlcmd.CommandType = CommandType.Text;
               try
               {
                  sqlcmd.ExecuteNonQuery();
                  isSuccess = true;
               }
               catch (Exception ex)
               {
                  UtilDB.ShowError(ex);
               }
            }
         }
         return isSuccess;
      }

      #endregion

      #region EVENTS

      private void btnCreateLogin_Click(object sender, EventArgs e)
      {
         int employeeId = int.Parse(txtEmpId.EditValue.ToString());

         string strLenh = string.Format(MyConfig.ExecSPKiemTraNVCoTaiKhoan, employeeId);
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (SqlCommand command = new SqlCommand(strLenh, connection))
            {
               command.CommandType = CommandType.Text;
               try
               {
                  command.ExecuteNonQuery();
                  FlyoutAction flyoutAction = new FlyoutAction()
                  {
                     Caption = Cons.CaptionCreateLogin,
                  };
                  CustomFlyoutDialog.ShowForm(this, flyoutAction, new frmRegister(employeeId));
               }
               catch (Exception ex)
               {
                  if (ex is SqlException exAsSqlEx && exAsSqlEx.Number == MyConfig.ErrorMsgNumEmployeeHaveLogin)
                  {
                     XtraMessageBox.Show(exAsSqlEx.Message, Cons.CaptionError,
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                  else
                  {
                     UtilDB.ShowError(ex);
                  }
               }
            }
         }
      }

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsNV.Position;
         _buttonAction = ButtonActionType.Add;

         bdsNV.AddNew();
         txtEmpDelStatus.EditValue = "0";
         txtEmpDepartment.EditValue = _currentDeploymentId;
         spiEmpSalary.EditValue = Cons.MinSalary;

         EnableEditMode();
         txtEmpFirstName.Focus();
      }

      private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         EditEmployee();
      }

      private void btnDel_ItemClick(object sender, ItemClickEventArgs e)
      {
         //var selectedPosition = gvNV.GetSelectedRows();
         //int length = selectedPosition.Length;
         //if (length > 0)
         //{
         //   var result = XtraMessageBox.Show(string.Format("Bạn chắc chắn muốn xóa {0} nhân viên", length), Cons.CaptionQuestion, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
         //   if (result == DialogResult.OK)
         //   {
         //      for (int index = 0; index < selectedPosition.Length; index++)
         //      {
         //         DeleteEmployee(selectedPosition[index]);
         //      }
         //   }
         //}
         DeleteEmployee(bdsNV.Position);
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
         UtilDB.TrimDataInControl(gbEmployee);
         SaveEmployee();
      }

      private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
      {
         Undo();
      }

      private void btnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         dxErrorProvider.ClearErrors();
         try
         {
            //txtEmpDep.Text = null;
            gbEmployee.Enabled = false;
            bdsNV.CancelEdit();
            //bdsNV.ResetCurrentItem();
            bdsNV.Position = _currentPosition;
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

      private void gcNV_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         EditEmployee();
      }

      private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (gbEmployee.Enabled == true)
         {
            var result = XtraMessageBox.Show(Cons.AskExitWhileEditing, Cons.CaptionQuestion,
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Question);
            switch (result)
            {
               case DialogResult.Yes:
                  // kiểm tra nút được nhấn [thêm, sửa] => [Lưu lại, update]
                  e.Cancel = !(SaveEmployee());
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

         RemoveLoginInStack();
      }

      #endregion

      #region FORMAT STRING

      private void gvNV_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
      {
         ColumnView view = sender as ColumnView;
         if (e.Column.FieldName == "LUONG" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
         {
            if (!(e.Value is DBNull))
            {
               decimal price = Convert.ToDecimal(e.Value);
               e.DisplayText = string.Format(Cons.CiVNI, "{0:c0}", price);
            }
         }
      }

      private void spiEmpSalary_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
      {
         if (!(e.Value is DBNull))
         {
            decimal price = Convert.ToDecimal(e.Value);
            e.DisplayText = string.Format(Cons.CiVNI, "{0:c0}", price);
         }
      }

      private void txtEmpFirstName_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
      {
         if (!(e.Value is DBNull))
         {
            TextInfo cultInfo = Cons.CiVNI.TextInfo;
            (sender as TextEdit).EditValue = cultInfo.ToTitleCase(e.DisplayText);
         }
      }

      private void txtEmpLastName_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
      {
         if (!(e.Value is DBNull))
         {
            TextInfo cultInfo = Cons.CiVNI.TextInfo;
            (sender as TextEdit).EditValue = cultInfo.ToTitleCase(e.DisplayText);
         }
      }

      #endregion

      #region VALIDATE

      private bool IsExistEmployee(int employeeId)
      {
         bool exist = true;
         string strLenh = string.Format(MyConfig.ExecSPTimNhanVien, employeeId);
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
               catch (Exception ex)
               {
                  if (ex is SqlException exAsSqlEx && exAsSqlEx.Number == MyConfig.ErrorMsgNumNotExistObject)
                     exist = false;
                  else
                     UtilDB.ShowError(ex);
               }
            }
         }
         return exist;
      }

      private string CheckPhieuDaLap()
      {
         string message = null;
         if (bdsDH.Count > 0)
         {
            message = Cons.DonDatHang;
         }
         else if (bdsPN.Count > 0)
         {
            message = Cons.PhieuLap;
         }
         else if (bdsPX.Count > 0)
         {
            message = Cons.PhieuXuat;
         }
         return message;
      }

      private bool IsValidEmptyValue()
      {
         var controlsNotValid = gbEmployee.Controls.OfType<BaseEdit>()
                                       .Where(control => string.IsNullOrEmpty(control.EditValue.ToString()))
                                       .OrderBy(control => control.TabIndex);

         controlsNotValid.ToList().ForEach(c =>
         {
            dxErrorProvider.SetError(c, Cons.ErrorNotNull);
         });

         return !dxErrorProvider.HasErrors;
      }

      #endregion

      private void btnSwitchDepartment_ItemClick(object sender, ItemClickEventArgs e)
      {
         object[] switchEmployeeData = ((DataRowView)bdsNV[bdsNV.Position]).Row.ItemArray;
         if (int.Parse(switchEmployeeData[7].ToString()) == 1)
         {
            XtraMessageBox.Show(Cons.ErrorSwitchEmployeeAlready, Cons.CaptionError,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         FlyoutAction flyoutAction = new FlyoutAction()
         {
            Caption = "Chuyển chi nhánh",
         };
         int id = int.Parse(switchEmployeeData[0].ToString());
         string fullName = $"{switchEmployeeData[1].ToString()} {switchEmployeeData[2].ToString()}";
         frmSwitchDepartment frmSwitch = new frmSwitchDepartment(int.Parse(switchEmployeeData[0].ToString()), fullName);
         CustomFlyoutDialog.ShowForm(this, flyoutAction, frmSwitch);
      }
   }
}
