using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT_DATHANG.Utility
{
   using Constant;
   using DevExpress.XtraEditors;

   public class UtilCommon
   {
      public static void SetupDSCN(System.Windows.Forms.ComboBox comboBox)
      {
         comboBox.DataSource = UtilDB.BdsDSPM;
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
