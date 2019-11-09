using DevExpress.XtraEditors;
using QLVT_DATHANG.Constant;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT_DATHANG.Utility
{
   public class UtilDB
   {
      public static string ConnectionString = null;
      public static string ServerName = null;
      public static string UserName = null; // Mã nhân viên
      public static string CurrentLogin = null;
      public static string CurrentPassword = null;
      
      public static string BackupLogin = null;
      public static string BackupPassword = null;
      public static string CurrentGroup = null;
      public static string CurrentFullName = null;
      public static int CurrentDepId = 0;

      public static BindingSource BdsDSPM = new BindingSource();  // giữ bdsPM khi đăng nhập
                                                                  //public static frmMain frmChinh;
      public static int Connect()
      {
         try
         {
            ConnectionString = $"Data Source={ServerName};" +
                                $"Initial Catalog={MyConfig.DatabaseName};" +
                                $"User ID={CurrentLogin};" +
                                $"password={CurrentPassword}";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
               connection.Open();
            }
            return 1;
         }

         catch (Exception e)
         {
            XtraMessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " +
                            e.Message, string.Empty, MessageBoxButtons.OK);
            return 0;
         }
      }

      public static bool GetAndSaveUserInfo()
      {
         string cmdText = string.Format(MyConfig.ExecSPThongTinDangNhap, CurrentLogin);
         SqlDataReader reader;
         bool flag = true;
         using (SqlConnection connection = new SqlConnection(ConnectionString))
         {
            connection.Open();
            SqlCommand sqlcmd = new SqlCommand(cmdText, connection);
            sqlcmd.CommandType = CommandType.Text;

            try
            {
               reader = sqlcmd.ExecuteReader();
               if (reader == null) flag = false;

               reader.Read();

               UserName = reader.GetString(0);     // Lay user name
               if (Convert.IsDBNull(UserName))
               {
                  XtraMessageBox.Show(MessageCons.ErrorLogin, MessageCons.CaptionError, MessageBoxButtons.OK);
                  flag = false;
               }
               CurrentFullName = reader.GetString(1);
               CurrentGroup = reader.GetString(2);
            }
            catch (SqlException ex)
            {
               XtraMessageBox.Show(ex.Message);
               flag = false;
            }
         }
         return flag;
      }

      public static DataTable ExecSqlDataTable(string cmdText, string connectionString)
      {
         DataTable dt = new DataTable();
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmdText, connection);
            da.Fill(dt);
         }
         return dt;
      }
   }
}
