using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._01_ConsolidateConditionalExpression
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Kiểm tra điều kiện xuất kho bán thuốc BVTV
    // Không cho phép bán nếu: Hết hạn sử dụng, đã bị Bộ Nông nghiệp thu hồi, hoặc chưa được cấp phép lưu hành
    public class KiemTraLuuHanhThuocBVTV_Real
    {
        public bool DuocPhepXuatBan(string tenThuoc, DateTime hanSuDung, bool biCamLuuHanh, bool daKiemDinhChatLuong)
        {
            if (LaThuocKhongHopLe(hanSuDung, biCamLuuHanh, daKiemDinhChatLuong))
            {
                Console.WriteLine($"   [CẢNH BÁO] Thuốc {tenThuoc} không đủ điều kiện lưu hành hoặc xuất kho!");
                return false;
            }

            Console.WriteLine($"   [HỢP LỆ] Thuốc {tenThuoc} đạt chuẩn, cho phép xuất kho bán.");
            return true;
        }

        private bool LaThuocKhongHopLe(DateTime hanSuDung, bool biCamLuuHanh, bool daKiemDinhChatLuong)
        {
            bool hetHan = hanSuDung < DateTime.Today;
            return hetHan || biCamLuuHanh || !daKiemDinhChatLuong;
        }
    }
}
