using System;
using System.Globalization;

namespace QLVT_DATHANG.Utility
{
   public class Cons
   {
      public static CultureInfo CiVNI = new CultureInfo("vi-VN", false);

      public const int ErrorDuplicateLoginNameCode = 15025;
      public const int ErrorDuplicateUserNameCode = 15023;
      public const int ErrorLoginNameCannotConnectCode = 18456;

      public const string DonDatHang = "đơn đặt hàng";
      public const string PhieuLap = "phiếu nhập";
      public const string PhieuXuat = "phiếu xuất";

      public const int MinSalary = 4000000;
      public static string ErrorSalary = "Lương phải lớn hơn " + string.Format(CiVNI, "{0:c0}", Convert.ToDecimal(MinSalary));

      public const string ErrorName = "Tên không hợp lệ";
      public const string ErrorDeleteSwitchedEmployee = "Không thể xóa nhân viên đã chuyển chi nhánh";
      public const string ErrorEditSwitchedEmployee = "Không thể sửa nhân viên đã chuyển chi nhánh";
      public const string ErrorEmployeeId = "Mã nhân viên không hợp lệ";
      public const string ErrorNotNull = "Vui lòng nhập dữ liệu";
      public const string ErrorNotNullUserName = "Vui lòng nhập Tên đăng nhập";
      public const string ErrorNotNullPassword = "Vui lòng nhập Mật khẩu";
      public const string ErrorConfirmPW = "Mật khẩu và Mật khẩu nhập lại không khớp";
      public const string ErrorNotCheckedRole = "Vui lòng chọn quyền cho tài khoản";
      public const string ErrorOutOfQuantity = "Số lượng bạn chọn vượt quá số lượng tồn";
      public const string ErrorBelowThenZero = "Giá trị không được nhỏ hơn 0";
      public const string ErrorLoginNameOrPW = "Tên đăng nhập hoặc mật khẩu không chính xác\nVui lòng kiểm tra lại.";
      public const string ErrorCannotConnectServer = "Không thể connect tới server, Vui lòng kiểm tra lại.";
      public const string ErrorSwitchDepartToCurrent = "Không thể chuyển nhân viên tới chi nhánh hiện tại.\nVui lòng chọn chi nhánh khác";
      public const string ErrorSwitchDepart = "Chuyển chi nhánh thất bại";
      public const string ErrorSwitchEmployeeAlready = "Nhân viên đã chuyển chi nhánh";

      public const string ErrorEmployeeHaveLogin = "Nhân viên đã tạo tài khoản";
      public const string ErrorDuplicateLoginName = "Login name đã tồn tại, vui lòng chọn login name khác";
      public const string ErrorDuplicateEmpoyeeId = "Mã nhân viên đã tồn tại";
      public const string ErrorDuplicateMaterialId = "Mã vật tư đã tồn tại";
      public const string ErrorDuplicateDeportId = "Mã kho đã tồn tại";
      public const string ErrorDuplicateOrderId = "Mã đơn đặt hàng đã tồn tại";
      public const string ErrorDuplicatePNId = "Mã phiếu nhập đã tồn tại";
      public const string ErrorDuplicatePXId = "Mã phiếu xuất đã tồn tại";

      public const string WarningUserCreateTK = "User không có quyền tạo tài khoản";

      public const string SuccessRegis = "Đăng ký thành công";
      public const string SuccessSwitchDepart = "Chuyển chi nhánh thành công";

      public const string AskDeleteEmployee = "Bạn có chắc muốn xóa nhân viên {0} {1}";
      public const string AskDeleteMaterials = "Bạn có chắc muốn xóa vật tư {0}";
      public const string AskDeleteOrder = "Bạn có chắc muốn xóa đơn đặt hàng {0}";
      public const string AskDeleteDepot = "Bạn có chắc muốn xóa kho hàng {0}";
      public const string AskExitWhileEditing = "Bạn có muốn lưu thay đổi trước khi thoát?";
      public const string AskExit = "Bạn chắc chắn muốn thoát, dữ liệu trên form sẽ không được lưu???";

      public const string ErrorDeleteEmployee = "Nhập viên đã lập {0}, không được xóa!!!";
      public const string ErrorDeleteMaterial = "Vật tư có trong {0}, không được xóa!!!";
      public const string ErrorConnectDepartment = "Lỗi kết nối về chi nhánh mới";
      public const string ErrorEmptyValueLogin = "Tên đăng nhập và Mật khẩu không được để trống";
      public const string ErrorEmptyValue = "Vui lòng nhập đầy đủ dữ liệu";
      public const string ErrorLogin = "Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password";

      public const string CaptionCreateLogin = "ĐĂNG KÝ TÀI KHOẢN";
      public const string CaptionCreateOrderDetail = "Nhập Chi Tiết Đơn Đặt Hàng";
      public const string CaptionCreateReceivedNote = "Nhập Chi Tiết Phiếu Nhập";
      public const string CaptionCreateDeliveryNote = "Nhập Chi Tiết Phiếu Xuất";
      public const string CaptionQuestion = "QUESTION";
      public const string CaptionError = "ERROR";
      public const string CaptionWarning = "WARNING";
      public const string CaptionSuccess = "SUCCESS";
   }
}
