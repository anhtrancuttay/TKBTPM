using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._08_RemoveSettingMethod
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Tính bất biến của chứng từ bán hàng (BusinessObject/PhieuBan.cs)
    // Loại bỏ setter của MaPhieu, NgayLap, NguoiLap để ngăn chặn sửa đổi chứng từ tài chính trái phép
    public class ChungTuBanHangNongDuoc_Real
    {
        // Immutable properties: Chỉ được gán trong Constructor
        public string MaPhieu { get; }
        public DateTime NgayLapPhieu { get; }
        public string MaNhanVienLap { get; }

        // Mutable properties: Có thể cập nhật trạng thái thanh toán
        public decimal TongTienThanhToan { get; private set; }
        public bool DaThanhToanXong { get; private set; }

        public ChungTuBanHangNongDuoc_Real(string maPhieu, DateTime ngayLap, string maNhanVien, decimal tongTien)
        {
            if (string.IsNullOrWhiteSpace(maPhieu))
                throw new ArgumentException("Mã phiếu không được rỗng!");

            MaPhieu = maPhieu;
            NgayLapPhieu = ngayLap;
            MaNhanVienLap = maNhanVien;
            TongTienThanhToan = tongTien;
            DaThanhToanXong = false;
        }

        public void XacNhanThanhToan()
        {
            DaThanhToanXong = true;
            Console.WriteLine($"   [KẾ TOÁN] Đã xác nhận thanh toán phiếu {MaPhieu} ({TongTienThanhToan:N0} đ). Mã phiếu và ngày lập được bảo toàn.");
        }
    }
}
