using System;

namespace QLVT_DATHANG
{
    public class MyConfig
    {
        public static string RootServerName = Environment.MachineName + "\\KAI";

      public const string ViewDSPMName = "V_DS_PHANMANH";
      public const string DisplayMemberDSPM = "TENCN";
      public const string ValueMemberDSPM = "TENSERVER";
      public const string FilterClauseDSPM = "FILTERCLAUSE";
      public const string PatternGetDepartId = @"(?<departId>[\w\d\s]{10})";

        public const string DatabaseName = "QLVT_DATHANG";
        public const string RemoteLogin = "HTKN";
        public const string RemotePassword = "123456";

        public const string CongTyGroupName = "congty";
        public const string ChiNhanhGroupName = "chinhanh";
        public const string UserGroupName = "user";

        public const string ExecSPThongTinDangNhap = "EXEC sp_login '{0}'";
        public const string ExecSPTaoTaiKhoan = "EXEC sp_createlogin '{0}', '{1}', '{2}', '{3}'";
        public const string ExecSPKiemTraNVCoTaiKhoan = "EXEC sp_timtaikhoannhanvien '{0}'";
        public const string ExecSPTimNhanVien = "EXEC sp_timnhanvien {0}";
        public const string ExecSPTimVatTu = "EXEC sp_timvattu '{0}'";
        public const string ExecSPTimKho = "EXEC sp_timkho '{0}'";
        public const string ExecSPTimDDH = "EXEC sp_timddh '{0}'";
        public const string ExecSPXoaLogin = "EXEC sp_removelogin '{0}'";
        public const string ExecSPTimPhieuNhap = "EXEC sp_timphieunhap '{0}'";
        public const string ExecSPTimPhieuXuat = "EXEC sp_timphieuxuat '{0}'";
        public const string SpGetAllMaNV = "sp_getallmanv";
      public const string SpChuyenChiNhanh = "sp_chuyenchinhanh";

      // Mã error khi exec sp raise error
      public const int ErrorCodeDatabase = 18;
      public const int ErrorMsgNumNotExistObject = 50001;
      public const int ErrorMsgNumEmployeeHaveLogin = 50002;
   }
}
