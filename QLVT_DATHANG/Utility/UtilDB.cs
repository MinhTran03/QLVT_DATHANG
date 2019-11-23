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

         catch (Exception)
         {
            XtraMessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại Tên đăng nhập và Mật khẩu.\n",
                                 Cons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
         }
      }

      /// <summary>
      /// Setup combobox hiển thị các chi nhánh hiện có và
      /// callback load lại Table khi chuyển chi nhánh
      /// </summary>
      /// <param name="comboBox">Control ComboBox</param>
      /// <param name="loadTable">Action load các bindingSource khi chuyển chi nhánh</param>
      public static void SetupDSCN(System.Windows.Forms.ComboBox comboBox, Action loadTable)
      {
         comboBox.DataSource = BdsDSPM;
         comboBox.DisplayMember = MyConfig.DisplayMemberDSPM;
         comboBox.ValueMember = MyConfig.ValueMemberDSPM;

         comboBox.SelectedIndexChanged += (o, e) =>
         {
            // đổi server
            UtilDB.ServerName = comboBox.SelectedValue.ToString();

            // đổi login
            if (comboBox.SelectedIndex != UtilDB.CurrentDeployment)
            {
               UtilDB.CurrentLogin = MyConfig.RemoteLogin;
               UtilDB.CurrentPassword = MyConfig.RemotePassword;
            }
            else
            {
               UtilDB.CurrentLogin = UtilDB.BackupLogin;
               UtilDB.CurrentPassword = UtilDB.BackupPassword;
            }

            //
            if (UtilDB.Connect() == 0)
            {
               XtraMessageBox.Show(Cons.ErrorConnectDepartment, Cons.CaptionError, MessageBoxButtons.OK);
            }
            else
            {
               loadTable();
            }
         };
      }

      public static void ShowError(Exception e)
      {
         if (e is SqlException)
         {
            Console.WriteLine("MsgNumber: {0}", ((SqlException)e).Number.ToString());
            XtraMessageBox.Show((e as SqlException).Message, Cons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else
         {
            string message = e.Message + "\n";
            string source = "Source: " + e.Source + "\n";
            string targetSite = "Method: " + e.TargetSite + "\n";
            XtraMessageBox.Show(source + targetSite + message, Cons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(e.StackTrace);
         }
      }

      public static void TrimDataInControl(GroupControl groupControl)
      {
         foreach (var control in groupControl.Controls)
         {
            TextEdit textEdit = null;
            if (control is TextEdit && (textEdit = (control as TextEdit)).ReadOnly == false)
            {
               textEdit.EditValue = textEdit.EditValue.ToString().Trim();
            }
         }
      }
   }
}
