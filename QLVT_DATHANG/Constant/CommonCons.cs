using System;
using System.Globalization;

namespace QLVT_DATHANG.Constant
{
   public class CommonCons
   {
      public static string MachineName = Environment.MachineName;
      public static CultureInfo CiVNI = new CultureInfo("vi-VN");

      public static string DonDatHang = "đơn đặt hàng";
      public static string PhieuLap = "phiếu nhập";
      public static string PhieuXuat = "phiếu xuất";

      public static int MinSalary = 4000000;
      public static string ErrorName = "Tên không hợp lệ";
      public static string ErrorSalary = "Lương phải lớn hơn " + string.Format(CiVNI, "{0:c0}", Convert.ToDecimal(MinSalary));
      public static string ErrorEmployeeId = "Mã nhân viên không hợp lệ";
      public static string ErrorNotNull = "Vui lòng nhập dữ liệu";
   }
}
