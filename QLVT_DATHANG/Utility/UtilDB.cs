using DevExpress.XtraEditors;
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
      public static int CurrentDeployment = 0;

      public static BindingSource BdsDSPM = new BindingSource();  // giữ bdsPM khi đăng nhập

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

      /// <summary>
      /// Kiểm tra kết nối dùng username và password người dùng nhập
      /// </summary>
      /// <returns></returns>
      public static int Connect()
      {
         try
         {
            UtilDB.ConnectionString = $"Data Source={UtilDB.ServerName};" +
                                $"Initial Catalog={MyConfig.DatabaseName};" +
                                $"User ID={UtilDB.CurrentLogin};" +
                                $"password={UtilDB.CurrentPassword}";
            using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
            {
               connection.Open();
            }
            return 1;
         }

         catch (Exception e)
         {
            XtraMessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại Tên đăng nhập và Mật khẩu.\n" +
                            e.Message, Cons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
         }
      }

      /// <summary>
      /// Setup combobox hiển thị các chi nhánh hiện có
      /// </summary>
      /// <param name="comboBox"></param>
      public static void SetupDSCN(System.Windows.Forms.ComboBox comboBox)
      {
         comboBox.DataSource = BdsDSPM;
         comboBox.DisplayMember = MyConfig.DisplayMemberDSPM;
         comboBox.ValueMember = MyConfig.ValueMemberDSPM;
      }

      public static void ShowError(Exception e)
      {
         string message = e.Message + "\n";
         string source = "Source: " + e.Source + "\n";
         string targetSite = "Method: " + e.TargetSite + "\n";
         XtraMessageBox.Show(source + targetSite + message, Cons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
         Console.WriteLine(e.StackTrace);
         if (e.GetType() == typeof(SqlException))
         {
            Console.WriteLine("===>" + ((SqlException)e).Number.ToString());
         }
      }
   }
}
