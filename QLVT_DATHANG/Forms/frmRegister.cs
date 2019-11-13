using QLVT_DATHANG.Constant;
using QLVT_DATHANG.Utility;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System;

namespace QLVT_DATHANG.Forms
{
   public partial class frmRegister : XtraUserControl
   {
      public frmRegister()
      {
         InitializeComponent();
      }

      private void btnExit_Click(object sender, System.EventArgs e)
      {
         ((Form)this.TopLevelControl).Close();
      }

      private void frmRegister_Load(object sender, System.EventArgs e)
      {
         radCongTy.Tag = Cons.CongTyGroupName;
         radChiNhanh.Tag = Cons.ChiNhanhGroupName;
         radUser.Tag = Cons.UserGroupName;

         txtPassword.Properties.PasswordChar = txtConfirmPassword.Properties.PasswordChar = '•';
         switch (UtilDB.CurrentGroup)
         {
            case Cons.CongTyGroupName:
               radCongTy.Checked = true;
               break;
            case Cons.ChiNhanhGroupName:
               radChiNhanh.Enabled = true;
               radUser.Enabled = true;
               break;
            default:
               break;
         }
      }

      private void textBoxNotNull_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         var value = (sender as TextEdit).EditValue.ToString();
         if (string.IsNullOrWhiteSpace(value))
         {
            errorProvider.SetError((sender as BaseEdit), Cons.ErrorNotNull);
         }
         else
         {
            errorProvider.SetError((sender as BaseEdit), string.Empty);
         }
         e.Cancel = false;
      }

      private void btnRegister_Click(object sender, System.EventArgs e)
      {
         if (ValidateInput())
         {
            string loginName = txtLoginName.Text;
            string pass = txtPassword.Text;
            int empId = int.Parse(txtEmpoyeeId.Text);
            string roleName = GetCheckedRole();
            bool result = CreateLogin(loginName, pass, empId, roleName);
            if (result)
            {
               XtraMessageBox.Show(Cons.SuccessRegis, Cons.CaptionSuccess,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
      }

      private string GetCheckedRole()
      {
         foreach (var control in lcRegister.Controls)
         {
            if(control is RadioButton)
            {
               var radio = (control as RadioButton);
               if (radio.Checked) return radio.Tag.ToString();
            }
         }

         return null;
      }

      private bool CreateLogin(string loginName, string password, int employeeId, string roleName)
      {
         bool result = true;
         string strLenh = string.Format(MyConfig.ExecSPTaoTaiKhoan, loginName, password, employeeId, roleName);
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
            sqlcmd.CommandType = CommandType.Text;
            try
            {
               sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               UtilCommon.ShowError(ex);
               result = false;
            }
         }
         return result;
      }

      private bool ValidateInput()
      {
         bool isValid = true;
         // kiểm tra chuỗi rỗng
         if (errorProvider.HasErrors)
         {
            XtraMessageBox.Show(Cons.ErrorEmptyValue, Cons.CaptionWarning,
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            errorProvider.GetControlsWithError()[0].Select();
            isValid = false;
         }
         // kiểm tra password match
         if(txtPassword.EditValue.Equals(txtConfirmPassword.EditValue) == false)
         {
            XtraMessageBox.Show(Cons.ErrorConfirmPW, Cons.CaptionError,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtConfirmPassword.EditValue = string.Empty;
            txtPassword.SelectAll();
            isValid = false;
         }
         // kiểm tra radio button checked
         if(GetCheckedRole() == null)
         {
            XtraMessageBox.Show(Cons.ErrorNotCheckedRole, Cons.CaptionError,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            isValid = false;
         }
         return isValid;
      }
   }
}