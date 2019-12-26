using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmdText, connection);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                    dt = null;
                }
            }
            return dt;
        }

        /// <summary>
        /// Kiểm tra kết nối dùng username và password người dùng nhập
        /// </summary>
        /// <returns></returns>
        public static bool Connect()
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
                return true;
            }

            catch (Exception ex)
            {
                if (ex is SqlException exAsSqlEx)
                {
                    switch (exAsSqlEx.Number)
                    {
                        case Cons.ErrorLoginNameCannotConnectCode:
                            //sai login name
                            XtraMessageBox.Show(Cons.ErrorLoginNameOrPW, Cons.CaptionError,
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            XtraMessageBox.Show(Cons.ErrorCannotConnectServer, Cons.CaptionError,
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }

                return false;
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
             if (UtilDB.Connect() == false)
                {
                    XtraMessageBox.Show(Cons.ErrorConnectDepartment, Cons.CaptionError, MessageBoxButtons.OK);
                }
                else
                {
                    loadTable();
                }
            };
        }

        public static string GetDepartIdInFilterClause(string filterClause)
        {
            filterClause = filterClause.Substring(9, 3);
            Regex pattern = new Regex(MyConfig.PatternGetDepartId);
            Match match = pattern.Match(filterClause);
            return filterClause;
        }

        public static void ShowError(Exception e)
        {
            //if (e is SqlException)
            //{
            //   Console.WriteLine("MsgNumber: {0}", ((SqlException)e).Number.ToString());
            //   Console.WriteLine((e as SqlException).Message);
            //}
            string message = e.Message + "\n";
            string source = "Source: " + e.Source + "\n";
            string targetSite = "Method: " + e.TargetSite + "\n";
            XtraMessageBox.Show(source + targetSite + message, Cons.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(e.StackTrace);
        }

        public static void TrimDataInControl(GroupControl groupControl)
        {
            foreach (var control in groupControl.Controls)
            {
                if (control is TextEdit textEdit && textEdit.ReadOnly == false)
                {
                    textEdit.EditValue = textEdit.EditValue.ToString().Trim();
                }
            }
        }

        public static int GenerateEmployeeId()
        {
            // lay ds ma nv da co trong csdl
            var listEmployeeId = GetListEmployeeId();
            var count = listEmployeeId.Count;

            for (int index = 0; index < count; index++)
            {
                int expectValue = index + 1;
                if (expectValue != listEmployeeId[index]) return expectValue;
            }
            return listEmployeeId[count - 1] + 1;
        }

        private static List<int> GetListEmployeeId()
        {
            using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(MyConfig.SpGetAllMaNV, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<int> list = new List<int>();
                        while (reader.Read())
                        {
                            list.Add(reader.GetInt32(0));
                        }
                        return list;
                    }
                }
            }
        }

        public static void SetFont(GridView gridView, GroupControl groupControl)
        {
            gridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridView.Appearance.SelectedRow.Font =
               gridView.Appearance.HeaderPanel.Font =
               gridView.Appearance.Row.Font =
               new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            groupControl.AppearanceCaption.Font =
               new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //foreach (var item in groupControl.Controls)
            //{
            //   (item as BaseEdit).Font =
            //      new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //}
            groupControl.Controls.OfType<BaseEdit>().ToList().ForEach(c => c.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            groupControl.Controls.OfType<Label>().ToList().ForEach(c => c.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
        }

        public static async Task<bool> DeleteInDB(string table, string filterColumn, object key)
        {
            bool isSuccess = false;
            using (var connection = new SqlConnection(UtilDB.ConnectionString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand()
                {
                    //CommandText = MyConfig.SpDeleteByKey,
                    //CommandType = CommandType.StoredProcedure,
                    CommandText = string.Format("delete from {0} where {1} = @key", table, filterColumn),
                    CommandType = CommandType.Text,
                    Connection = connection
                })
                {
                    command.Parameters.AddWithValue("@key", key);

               try
               {
                  await command.ExecuteNonQueryAsync();
                  isSuccess = true;
               }
               catch (Exception ex)
               {
                  throw ex;
               }
            }
         }
         return isSuccess;
      }

      public static SqlDataAdapter GetAdapter(object tableAdapter)
      {
         Type tableAdapterType = tableAdapter.GetType();
         SqlDataAdapter adapter = (SqlDataAdapter)tableAdapterType.GetProperty("Adapter",
                BindingFlags.Instance | BindingFlags.NonPublic).GetValue(tableAdapter, null);
         return adapter;
      }

      public static void UpdateWithTransaction(Action updateAction, params object[] tableAdapters)
      {
         using (var connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            var trans = connection.BeginTransaction();

            SqlDataAdapter[] sqlDataAdapters = new SqlDataAdapter[tableAdapters.Length];
            for (int index = 0; index < tableAdapters.Length; index++)
            {
               sqlDataAdapters[index] = GetAdapter(tableAdapters[index]);
               sqlDataAdapters[index].InsertCommand.Connection = trans.Connection;
               sqlDataAdapters[index].InsertCommand.Transaction = trans;
            }

            try
            {
               updateAction();
               trans.Commit();
            }
            catch (Exception ex)
            {
               trans.Rollback();
               throw ex;
            }
         }
      }
      private static SqlTransaction transaction = null;

      public static void SetIsolationOnRow(string tableName, object key)
      {
         var connection = new SqlConnection(UtilDB.ConnectionString);
         connection.Open();
         transaction = connection.BeginTransaction();

         // block row
         using (var command = connection.CreateCommand())
         {
            command.Connection = connection;
            command.Transaction = transaction;
            command.CommandText = "SET TRANSACTION ISOLATION LEVEL REPEATABLE READ\nSELECT * FROM NHANVIEN WHERE MANV=14";
            command.CommandType = CommandType.Text;
            try
            {
               command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
               throw ex;
            }
         }
      }
   }
}
