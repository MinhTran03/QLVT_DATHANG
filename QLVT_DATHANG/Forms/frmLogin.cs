using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraEditors;
   using Utility;

   public partial class frmLogin : XtraForm
   {
      public frmLogin()
      {
         InitializeComponent();
         txtMK.Properties.PasswordChar = '•';
         pbHienPW.Properties.AllowFocused = false;
      }

      private void frmLogin_Load(object sender, EventArgs e)
      {
         string cnnStr = $"Data Source={MyConfig.RootServerName};" +
                        $"Initial Catalog={MyConfig.DatabaseName};" +
                        $"Integrated Security=True";

         try
         {
            UtilDB.BdsDSPM.DataSource = UtilDB.ExecSqlDataTable($"SELECT * FROM {MyConfig.ViewDSPMName}  ORDER BY {MyConfig.DisplayMemberDSPM}", cnnStr);
            if (UtilDB.BdsDSPM.DataSource == null)
            {
               Close();
               return;
            }

            cboChiNhanh.DataSource = UtilDB.BdsDSPM;
            cboChiNhanh.DisplayMember = MyConfig.DisplayMemberDSPM;
            cboChiNhanh.ValueMember = MyConfig.ValueMemberDSPM;

            cboChiNhanh.SelectedIndex = -1;
            cboChiNhanh.SelectedIndex = 0;
         }
         catch (SqlException ex)
         {
            UtilDB.ShowError(ex);
         }
         txtTK.Select();
      }

      private void cboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cboChiNhanh.SelectedValue == null) return;
         try
         {
            UtilDB.ServerName = cboChiNhanh.SelectedValue.ToString();
            lblServerPM.Text = UtilDB.ServerName;
         }
         catch (Exception ex) { UtilDB.ShowError(ex); }
      }

      private void btnDangNhap_Click(object sender, EventArgs e)
      {
         if (errorProvider.HasErrors)
         {
            XtraMessageBox.Show(Cons.ErrorEmptyValueLogin, Cons.CaptionWarning,
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            errorProvider.GetControlsWithError()[0].Select();
            return;
         }

         // gán username và password vào connectionString và kết nối thử
         if (!IsLogin()) return;

         UtilDB.CurrentDeployment = cboChiNhanh.SelectedIndex;
         UtilDB.BackupLogin = UtilDB.CurrentLogin;
         UtilDB.BackupPassword = UtilDB.CurrentPassword;

         if (!GetAndSaveUserInfoFromDB()) return;

         // Copy tren stack overflow
         frmMain formMain = new frmMain();
         this.Hide();
         formMain.Closed += (s, args) => 
         {
            this.Show();
         };
         formMain.Show();
      }

      private void pbHienPW_MouseDown(object sender, MouseEventArgs e)
      {
         txtMK.Properties.PasswordChar = '\0';
         pbHienPW.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
      }

      private void pbHienPW_MouseUp(object sender, MouseEventArgs e)
      {
         txtMK.Properties.PasswordChar = '•';
         pbHienPW.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void txtTK_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         var value = (sender as TextEdit).EditValue.ToString();
         if (string.IsNullOrWhiteSpace(value))
         {
            errorProvider.SetError((sender as BaseEdit), Cons.ErrorNotNullUserName);
         }
         else
         {
            errorProvider.SetError((sender as BaseEdit), string.Empty);
         }
         e.Cancel = false;
      }

      private void txtMK_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         var value = (sender as TextEdit).EditValue.ToString();
         if (string.IsNullOrWhiteSpace(value))
         {
            errorProvider.SetError((sender as BaseEdit), Cons.ErrorNotNullPassword);
         }
         else
         {
            errorProvider.SetError((sender as BaseEdit), string.Empty);
         }
         e.Cancel = false;
      }

      /// <summary>
      /// Kiểm tra username và mật khẩu có connect được với server
      /// Lưu lại username và mật khẩu vào UtilDB
      /// </summary>
      /// <returns>true nếu connect thành công</returns>
      private bool IsLogin()
      {
         UtilDB.CurrentLogin = txtTK.Text;
         UtilDB.CurrentPassword = txtMK.Text;

         return UtilDB.Connect();
      }

      /// <summary>
      /// Dùng username và mật khẩu khi connect thành công
      /// Exec sp_login để lấy Nhóm quyền, Tên, Mã NV
      /// </summary>
      /// <returns></returns>
      public static bool GetAndSaveUserInfoFromDB()
      {
         bool flag = true;
         string cmdText = string.Format(MyConfig.ExecSPThongTinDangNhap, UtilDB.CurrentLogin);
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            SqlCommand sqlcmd = new SqlCommand(cmdText, connection);
            sqlcmd.CommandType = CommandType.Text;

            using (SqlDataReader reader = sqlcmd.ExecuteReader())
            {
               try
               {
                  if (reader == null) flag = false;

                  reader.Read();

                  UtilDB.UserName = reader.GetString(0);     // Lay MANV
                  if (Convert.IsDBNull(UtilDB.UserName))
                  {
                     XtraMessageBox.Show(Cons.ErrorLogin, Cons.CaptionError, MessageBoxButtons.OK);
                     flag = false;
                  }
                  else
                  {
                     UtilDB.CurrentFullName = reader.GetString(1);
                     UtilDB.CurrentGroup = reader.GetString(2);
                  }
               }
               catch (Exception ex)
               {
                  UtilDB.ShowError(ex);
                  flag = false;
               }
            }
         }
         return flag;
      }
   }
}
