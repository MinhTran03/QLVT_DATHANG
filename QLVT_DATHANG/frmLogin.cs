using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
   using Utility;
   using Constant;

   public partial class frmLogin : Form
   {
      public frmLogin()
      {
         InitializeComponent();
         txtMK.PasswordChar = '•';
      }

      private void frmLogin_Load(object sender, EventArgs e)
      {
         string chuoiketnoi = $"Data Source={CommonCons.MachineName};" +
                                 $"Initial Catalog={UtilDB.DatabaseName};" +
                                 $"Integrated Security=True";

         UtilDB.SqlConnection.ConnectionString = chuoiketnoi;
         try
         {
            //UtilDB.conn.Open();
            DataTable dataTable = new DataTable();
            dataTable = UtilDB.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            UtilDB.BdsDSPM.DataSource = dataTable;

            cboChiNhanh.DataSource = dataTable;
            cboChiNhanh.DisplayMember = UtilDB.DisplayMemberDSPM;
            cboChiNhanh.ValueMember = UtilDB.ValueMemberDSPM;

            cboChiNhanh.SelectedIndex = -1;
            cboChiNhanh.SelectedIndex = 0;
         }
         catch (SqlException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            if (UtilDB.SqlConnection.State == ConnectionState.Open)
            {
               UtilDB.SqlConnection.Close();
            }
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

      private void btnDangNhap_Click(object sender, EventArgs e)
      {
         if (txtTK.Text.Trim() == string.Empty || txtMK.Text.Trim() == string.Empty)
         {
            MessageBox.Show(MessageCons.ErrorEmptyValueLogin, string.Empty, MessageBoxButtons.OK);
            return;
         }

         UtilDB.CurrentLogin = txtTK.Text;
         UtilDB.CurrentPassword = txtMK.Text;
         if (UtilDB.Connect() == 0) return;

         UtilDB.CurrentDepId = cboChiNhanh.SelectedIndex;

         UtilDB.BackupLogin = UtilDB.CurrentLogin;
         UtilDB.BackupPassword = UtilDB.CurrentPassword;
         string strLenh = $"EXEC sp_login '{UtilDB.CurrentLogin}'";

         UtilDB.MyReader = UtilDB.ExecSqlDataReader(strLenh);
         if (UtilDB.MyReader == null) return;
         UtilDB.MyReader.Read();

         UtilDB.UserName = UtilDB.MyReader.GetString(0);     // Lay user name
         if (Convert.IsDBNull(UtilDB.UserName))
         {
            MessageBox.Show(MessageCons.ErrorLogin, string.Empty, MessageBoxButtons.OK);
            return;
         }
         UtilDB.CurrentFullName = UtilDB.MyReader.GetString(1);
         UtilDB.CurrentGroup = UtilDB.MyReader.GetString(2);
         UtilDB.MyReader.Close();
         UtilDB.SqlConnection.Close();

         // Copy tren stack overflow
         frmMain formMain = new frmMain();
         this.Hide();
         formMain.Closed += (s, args) => this.Show();
         formMain.Show();
         formMain.ShowMenu();
      }
   }
}
