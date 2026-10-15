using System;
using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._10_ReplaceParameterWithMethodCall
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Tính chiết khấu đơn hàng bán sỉ (frmBanSi.cs)
    // Phương thức tự tính tiền hàng gốc qua danh sách chi tiết thay vì bắt Form UI truyền vào
    public class DonHangBanSiNongDuoc_Real
    {
        public List<(string TenThuoc, int SoLuong, decimal DonGia)> ChiTietHangHoa { get; } = new();
        public int HangDaiLy { get; set; } = 1; // Đại lý cấp 1

        public decimal TinhTienHangGoc()
        {
            decimal tong = 0;
            foreach (var item in ChiTietHangHoa)
                tong += item.SoLuong * item.DonGia;
            return tong;
        }

        // Tự gọi TinhTienHangGoc() bên trong (Replace Parameter with Method Call)
        public decimal TinhTienThanhToanSauChietKhau()
        {
            decimal tienGoc = TinhTienHangGoc();
            double tiLeChietKhau = (HangDaiLy == 1) ? 0.12 : 0.06;
            decimal tienSauChietKhau = tienGoc * (1 - (decimal)tiLeChietKhau);

            Console.WriteLine($"   [BÁN SỈ NÔNG DƯỢC] Tiền gốc: {tienGoc:N0} đ | CK Cấp {HangDaiLy} ({tiLeChietKhau:P0}) -> Thanh toán: {tienSauChietKhau:N0} đ");
            return tienSauChietKhau;
        }
    }
}
