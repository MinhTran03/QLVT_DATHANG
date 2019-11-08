using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
   using DevExpress.Utils;
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using DevExpress.XtraEditors.Controls;
   using DevExpress.XtraEditors.Mask;
   using DevExpress.XtraGrid.Views.Base;
   using Constant;
   using Utility;

   public partial class frmEmployee : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;
      private ButtonActionType _buttonAction;
      private MyStack _userDo;
      private DataRow _row;

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
         if (UtilDB.CurrentGroup.Equals("congty"))
         {
            SetupDSCN();
            this.cboEmpDep.Visible = true;
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDel.Enabled = false;
         }
      }

      #region METHOD

      public void SetupControls()
      {
         string nameRegex = "[\u0000-\u001F\007F-\u009F]+(\\s{1}[\u0000-\u001F\007F-\u009F]+)*"; // regex with one space between 2 character

         txtEmpId.Properties.Mask.MaskType = MaskType.RegEx;
         txtEmpId.Properties.Mask.EditMask = "\\d+";
         txtEmpId.Properties.Mask.BeepOnError = true;
         txtEmpId.Properties.AllowNullInput = DefaultBoolean.True;
         ////txtEmpId.Properties.NullValuePrompt = "Id here";

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
         dtpEmpBirth.Properties.Mask.EditMask = "dd//MM//yyyy";
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
         if (_userDo.Count == 1)
         {
            btnUndo.Enabled = true;
         }
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

            // TODO: This line of code loads data into the 'dataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.taPX.Fill(this.dataSet.PhieuXuat);

            // TODO: This line of code loads data into the 'dataSet.DatHang' table. You can move, or remove it, as needed.
            this.taDH.Fill(this.dataSet.DatHang);

            // TODO: This line of code loads data into the 'dataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.taPN.Fill(this.dataSet.PhieuNhap);

            this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            ShowError(ex);
         }
      }

      public void SetupDSCN()
      {
         this.cboEmpDep.DataSource = UtilDB.BdsDSPM;
         this.cboEmpDep.DisplayMember = UtilDB.DisplayMemberDSPM;
         this.cboEmpDep.ValueMember = UtilDB.ValueMemberDSPM;
      }

      private void EnableEditMode()
      {
         gcNV.Enabled = false;
         gbNV.Enabled = true;

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
         btnDel.Enabled = (bdsNV.Count == 0) ? false : true;
         txtEmpDelStatus.ReadOnly = true;
         txtEmpDepartment.ReadOnly = true;

         gcNV.Enabled = true;
         gbNV.Enabled = false;

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

      public void ShowError(Exception e)
      {
         string message = e.Message + "\n";
         string source = "Source: " + e.Source + "\n";
         string targetSite = "Method: " + e.TargetSite + "\n";
         XtraMessageBox.Show(source + targetSite + message, MessageCons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
         Console.WriteLine(e.StackTrace);
         if (e.GetType() == typeof(SqlException))
         {
            Console.WriteLine("===>" + ((SqlException)e).Number.ToString());
         }
      }

      private void Undo()
      {
         ButtonAction action = (ButtonAction)_userDo.Pop();
         switch (action.ActionType)
         {
            case ButtonActionType.Add:
               // xóa dữ liệu mới
               bdsNV.Remove(action.SaveDataRow);
               break;
            case ButtonActionType.Edit:
               // sửa lại dữ liệu cũ
               int position = bdsNV.Find("MANV", action.SaveDataRow["MANV"]);
               for (int i = 0; i < 7; i++)
               {
                  ((DataRowView)bdsNV[position])[i] = action.SaveDataRow[i];
               }
               bdsNV.EndEdit();
               bdsNV.ResetCurrentItem();
               break;
            case ButtonActionType.None:
               break;
            default:
               break;
         }
         this.taNV.Update(this.dataSet.NhanVien);
      }

      private bool SaveEmployee()
      {
         try
         {
            if (_buttonAction == ButtonActionType.Add)
            {
               if (IsExistEmployee(int.Parse(txtEmpId.EditValue.ToString())))
               {
                  XtraMessageBox.Show("Mã tồn tại");
                  txtEmpId.Focus();
                  txtEmpId.SelectAll();
                  return false;
               }
               _userDo.Push(new ButtonAction(_buttonAction, (DataRowView)bdsNV[bdsNV.Position]));
            }
            _buttonAction = ButtonActionType.None;

            bdsNV.EndEdit();
            gbNV.Enabled = false;
            bdsNV.ResetCurrentItem();
            this.taNV.Update(this.dataSet.NhanVien);
         }
         catch (Exception ex)
         {
            // #load lại từ database
            dataSet.EnforceConstraints = false;
            this.taNV.Fill(this.dataSet.NhanVien);
            dataSet.EnforceConstraints = true;
            ShowError(ex);
            return false;
         }
         bdsNV.Position = _currentPosition;
         DisableEditMode();
         return true;
      }

      private void EditEmployee()
      {
         // lưu lại trạng thái nút ấn
         _currentPosition = bdsNV.Position;
         _buttonAction = ButtonActionType.Edit;

         // lưu lại datarow để undo
         _row = ((DataRow)bdsNV[_currentPosition]);
         _userDo.Push(new ButtonAction(_buttonAction, ((DataRowView)bdsNV[_currentPosition])));

         EnableEditMode();
      }

      #endregion

      #region BUTTON EVENT

      private void cboEmpDep_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cboEmpDep.SelectedValue.ToString() == "System.Data.DataRowView") return;

         // đổi server
         UtilDB.ServerName = cboEmpDep.SelectedValue.ToString();

         // đổi login
         if (cboEmpDep.SelectedIndex != UtilDB.CurrentDepId)
         {
            UtilDB.CurrentLogin = UtilDB.RemoteLogin;
            UtilDB.CurrentPassword = UtilDB.RemotePassword;
         }
         else
         {
            UtilDB.CurrentLogin = UtilDB.BackupLogin;
            UtilDB.CurrentPassword = UtilDB.BackupPassword;
         }

         //
         if (UtilDB.Connect() == 0)
         {
            XtraMessageBox.Show(MessageCons.ErrorConnectDepartment, string.Empty, MessageBoxButtons.OK);
         }
         else
         {
            LoadTable();
            _currentDeploymentId = ((DataRowView)bdsNV[0])["MACN"].ToString();
         }
      }

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsNV.Position;
         _buttonAction = ButtonActionType.Add;

         bdsNV.AddNew();
         txtEmpDelStatus.EditValue = "0";
         txtEmpDepartment.EditValue = _currentDeploymentId;
         spiEmpSalary.EditValue = CommonCons.MinSalary;

         EnableEditMode();
         txtEmpId.Focus();
      }

      private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         EditEmployee();
      }

      private void btnDel_ItemClick(object sender, ItemClickEventArgs e)
      {
         string phieuLap = CheckPhieuDaLap();
         if (phieuLap != null)
         {
            string text = string.Format(MessageCons.ErrorDeleteEmployee, phieuLap);
            XtraMessageBox.Show(text, MessageCons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else
         {
            _currentPosition = bdsNV.Position;
            string ho = ((DataRowView)bdsNV[_currentPosition])["HO"].ToString();
            string ten = ((DataRowView)bdsNV[_currentPosition])["TEN"].ToString();
            var result = XtraMessageBox.Show(string.Format(MessageCons.DeleteEmployee, ho, ten), MessageCons.CaptionQuestion,
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               try
               {
                  bdsNV.RemoveCurrent();
                  this.taNV.Update(this.dataSet.NhanVien);
               }
               catch (Exception ex)
               {
                  ShowError(ex);
               }
            }
         }
      }

      private string CheckPhieuDaLap()
      {
         string message = null;
         if (bdsDH.Count > 0)
         {
            message = CommonCons.DonDatHang;
         }
         else if (bdsPN.Count > 0)
         {
            message = CommonCons.PhieuLap;
         }
         else if (bdsPX.Count > 0)
         {
            message = CommonCons.PhieuXuat;
         }
         return message;
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
            gbNV.Enabled = false;
            bdsNV.CancelEdit();
            bdsNV.ResetCurrentItem();
            bdsNV.Position = _currentPosition;
            _buttonAction = ButtonActionType.None;
         }
         catch (Exception ex)
         {
            ShowError(ex);
         }
         DisableEditMode();
      }

      private void gcNV_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         EditEmployee();
      }

      private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (gbNV.Enabled == true)
         {
            var result = XtraMessageBox.Show(MessageCons.ExitWhileEditing, MessageCons.CaptionQuestion,
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
               e.DisplayText = string.Format(CommonCons.CiVNI, "{0:c0}", price);
            }
         }
      }

      private void spiEmpSalary_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
      {
         if (!(e.Value is DBNull))
         {
            decimal price = Convert.ToDecimal(e.Value);
            e.DisplayText = string.Format(CommonCons.CiVNI, "{0:c0}", price);
         }
      }

      private void txtEmpFirstName_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
      {
         if (!(e.Value is DBNull))
         {
            TextInfo cultInfo = new CultureInfo("vi-VN", false).TextInfo;
            (sender as TextEdit).EditValue = cultInfo.ToTitleCase(e.DisplayText);
         }
      }

      private void txtEmpLastName_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
      {
         if (!(e.Value is DBNull))
         {
            TextInfo cultInfo = new CultureInfo("vi-VN", false).TextInfo;
            (sender as TextEdit).EditValue = cultInfo.ToTitleCase(e.DisplayText);
         }
      }

      #endregion

      #region VALIDATE

      private bool IsExistEmployee(int employeeId)
      {
         string strLenh = string.Format("EXEC sp_timnhanvien {0}", employeeId);
         SqlCommand sqlcmd = new SqlCommand(strLenh, UtilDB.SqlConnection);
         sqlcmd.CommandType = CommandType.Text;

         try
         {
            UtilDB.OpenConnection();
            SqlDataReader myreader = sqlcmd.ExecuteReader();
            return true;
         }
         catch (SqlException)
         {
            return false;
         }
      }

      //private bool ValidateFormEmp()
      //{
      //   List<bool> valids = new List<bool>();
      //   valids.Add(ValidateLength(txtEmpId));
      //   valids.Add(ValidateLength(txtEmpFirstName));
      //   valids.Add(ValidateLength(txtEmpLastName));
      //   valids.Add(ValidateLength(txtEmpAddr));
      //   valids.Add(ValidateLength(spiEmpSalary));
      //   valids.Add(ValidateLength(dtpEmpBirth));
      //   if (!(valids.Contains(false)))
      //   {
      //      XtraMessageBox.Show("Đúng");
      //   }
      //   else
      //   {
      //      XtraMessageBox.Show("Sai");
      //      return false;
      //   }
      //   return true;
      //}

      //private bool ValidateLength(BaseEdit baseEdit)
      //{
      //   bool valid = true;
      //   if (baseEdit.EditValue == null || baseEdit.EditValue.Equals(""))
      //   {
      //      dxErrorProvider.SetError(baseEdit, CommonCons.ErrorNotNull);
      //      valid = false;
      //   }
      //   return valid;
      //}

      #endregion

   }
}
