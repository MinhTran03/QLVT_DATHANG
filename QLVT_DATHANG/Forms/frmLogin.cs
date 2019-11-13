using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using Constant;
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
         string cnnStr = $"Data Source={MyConfig.MachineName};" +
                        $"Initial Catalog={MyConfig.DatabaseName};" +
                        $"Integrated Security=True";

         try
         {
            UtilDB.BdsDSPM.DataSource = UtilDB.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH", cnnStr);

            UtilCommon.SetupDSCN(cboChiNhanh);

            cboChiNhanh.SelectedIndex = -1;
            cboChiNhanh.SelectedIndex = 0;
         }
         catch (SqlException ex)
         {
            UtilCommon.ShowError(ex);
         }
         txtTK.Select();
      }

      private void cboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
      {
         try
         {
            UtilDB.ServerName = cboChiNhanh.SelectedValue.ToString();
            lblServerPM.Text = UtilDB.ServerName;
         }
         catch (Exception) { };
      }

      private bool IsLogin()
      {
         UtilDB.CurrentLogin = txtTK.Text;
         UtilDB.CurrentPassword = txtMK.Text;

         if (UtilDB.Connect() == 0) return false;
         return true;
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

         if (!UtilDB.GetAndSaveUserInfo()) return;

         // Copy tren stack overflow
         frmMain formMain = new frmMain();
         this.Hide();
         formMain.Closed += (s, args) => this.Show();
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
   }
}
