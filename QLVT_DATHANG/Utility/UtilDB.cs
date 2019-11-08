using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT_DATHANG.Utility
{
   public class UtilDB
   {
      public static string DisplayMemberDSPM = "TENCN";
      public static string ValueMemberDSPM = "TENSERVER";

      public static SqlConnection SqlConnection = new SqlConnection();
      public static string ConnectionString = null;
      public static SqlDataReader MyReader;
      public static string ServerName = null;
      public static string UserName = null; // Mã nhân viên
      public static string CurrentLogin = null;
      public static string CurrentPassword = null;

      public static string DatabaseName = "QLVT_DATHANG";
      public static string RemoteLogin = "HTKN";
      public static string RemotePassword = "123456";
      public static string BackupLogin = null;
      public static string BackupPassword = null;
      public static string CurrentGroup = null;
      public static string CurrentFullName = null;
      public static int CurrentDepId = 0;

      public static BindingSource BdsDSPM = new BindingSource();  // giữ bdsPM khi đăng nhập
                                                                  //public static frmMain frmChinh;
      public static int Connect()
      {
         if (SqlConnection != null && SqlConnection.State == ConnectionState.Open)
            SqlConnection.Close();
         try
         {
            ConnectionString = $"Data Source={ServerName};" +
                    $"Initial Catalog={DatabaseName};" +
                    $"User ID={CurrentLogin};" +
                    $"password={CurrentPassword}";
            SqlConnection.ConnectionString = ConnectionString;
            SqlConnection.Open();
            return 1;
         }

         catch (Exception e)
         {
            MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " +
                            e.Message, string.Empty, MessageBoxButtons.OK);
            return 0;
         }
      }

      public static void OpenConnection()
      {
         if (null != SqlConnection && SqlConnection.State == ConnectionState.Closed)
            SqlConnection.Open();
      }

      public static SqlDataReader ExecSqlDataReader(string cmdText)
      {
         SqlDataReader myreader;
         SqlCommand sqlcmd = new SqlCommand(cmdText, SqlConnection);
         sqlcmd.CommandType = CommandType.Text;

         OpenConnection();
         try
         {
            myreader = sqlcmd.ExecuteReader();
            return myreader;
         }
         catch (SqlException ex)
         {
            SqlConnection.Close();
            MessageBox.Show(ex.Message);
            return null;
         }
      }

      public static DataTable ExecSqlDataTable(string cmdText)
      {
         if (SqlConnection.State == ConnectionState.Closed)
         {
            SqlConnection.Open();
         }

         DataTable dt = new DataTable();
         SqlDataAdapter da = new SqlDataAdapter(cmdText, SqlConnection);
         da.Fill(dt);

         SqlConnection.Close();
         return dt;
      }
   }
}
