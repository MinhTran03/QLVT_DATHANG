using System;

namespace QLVT_DATHANG
{
   public class MyConfig
   {
      public static string MachineName = Environment.MachineName;

      public static string DisplayMemberDSPM = "TENCN";
      public static string ValueMemberDSPM = "TENSERVER";
      public static string DatabaseName = "QLVT_DATHANG";
      public static string RemoteLogin = "HTKN";
      public static string RemotePassword = "123456";

      public static string ExecSPThongTinDangNhap = "EXEC sp_login '{0}'";
   }
}
