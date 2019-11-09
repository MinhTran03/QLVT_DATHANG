using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using Utility;
   using Constant;
   using DevExpress.XtraEditors;

   public partial class frmLogin : XtraForm
   {
      public frmLogin()
      {
         InitializeComponent();
         txtMK.Properties.PasswordChar = '•';
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
         if (txtTK.Text.Trim() == string.Empty || txtMK.Text.Trim() == string.Empty)
         {
            XtraMessageBox.Show(MessageCons.ErrorEmptyValueLogin, MessageCons.CaptionError, MessageBoxButtons.OK);
            return;
         }

         // gán username và password vào connectionString và kết nối thử
         if (!IsLogin()) return;

         UtilDB.CurrentDepId = cboChiNhanh.SelectedIndex;
         UtilDB.BackupLogin = UtilDB.CurrentLogin;
         UtilDB.BackupPassword = UtilDB.CurrentPassword;

         if (!UtilDB.GetAndSaveUserInfo()) return;

         // Copy tren stack overflow
         frmMain formMain = new frmMain();
         this.Hide();
         formMain.Closed += (s, args) => this.Show();
         formMain.Show();
      }
   }
}
