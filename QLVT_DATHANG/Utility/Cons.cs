using System;
using System.Globalization;

namespace QLVT_DATHANG.Utility
{
   public class Cons
   {
      public static CultureInfo CiVNI = new CultureInfo("vi-VN", false);

      public const string DonDatHang = "đơn đặt hàng";
      public const string PhieuLap = "phiếu nhập";
      public const string PhieuXuat = "phiếu xuất";

      public const int MinSalary = 4000000;
      public const string ErrorName = "Tên không hợp lệ";
      public static string ErrorSalary = "Lương phải lớn hơn " + string.Format(CiVNI, "{0:c0}", Convert.ToDecimal(MinSalary));
      public const string ErrorEmployeeId = "Mã nhân viên không hợp lệ";
      public const string ErrorNotNull = "Vui lòng nhập dữ liệu";
      public const string ErrorNotNullUserName = "Vui lòng nhập Tên đăng nhập";
      public const string ErrorNotNullPassword = "Vui lòng nhập Mật khẩu";
      public const string ErrorConfirmPW = "Mật khẩu và Mật khẩu nhập lại không khớp";
      public const string ErrorNotCheckedRole = "Vui lòng chọn quyền cho tài khoản";
      public const string ErrorDuplicateEmpoyeeId = "Mã nhân viên đã tồn tại";

      public const string WarningUserCreateTK = "User không có quyền tạo tài khoản";

      public const string SuccessRegis = "Đăng ký thành công";

      public const string CongTyGroupName = "congty";
      public const string ChiNhanhGroupName = "chinhanh";
      public const string UserGroupName = "user";

      public const string AskDeleteEmployee = "Bạn có chắc muốn xóa nhân viên {0} {1}";
      public const string AskDeleteMaterials = "Bạn có chắc muốn xóa vật tư {0}";
      public const string AskExitWhileEditing = "Bạn có muốn lưu thay đổi trước khi thoát?";

      public const string ErrorDeleteEmployee = "Nhập viên đã lập {0}, không được xóa!!!";
      public const string ErrorConnectDepartment = "Lỗi kết nối về chi nhánh mới";
      public const string ErrorEmptyValueLogin = "Tên đăng nhập và Mật khẩu không được để trống";
      public const string ErrorEmptyValue = "Vui lòng nhập đầy đủ dữ liệu";
      public const string ErrorLogin = "Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password";

      public const string CaptionCreateLogin = "ĐĂNG KÝ TÀI KHOẢN";
      public const string CaptionQuestion = "QUESTION";
      public const string CaptionError = "ERROR";
      public const string CaptionWarning = "WARNING";
      public const string CaptionSuccess = "SUCCESS";
   }
}
