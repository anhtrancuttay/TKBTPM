using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._07_ExtractSuperclass
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Đối tác kinh doanh (frmKhachHang.cs & frmNhaCungCap.cs)
    // Trích xuất lớp cha trừu tượng DoiTacKinhDoanhNongDuoc_Real từ Khách Hàng và Nhà Cung Cấp
    public abstract class DoiTacKinhDoanhNongDuoc_Real
    {
        public string MaDoiTac { get; set; } = string.Empty;
        public string TenDoiTac { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public decimal SoDuCongNoHienTai { get; protected set; }

        public void GhiNhanPhatSinhNo(decimal soTien) => SoDuCongNoHienTai += soTien;
        public void GhiNhanThanhToan(decimal soTien) => SoDuCongNoHienTai = Math.Max(0, SoDuCongNoHienTai - soTien);

        public virtual void InThongTinDoiTac()
        {
            Console.WriteLine($"   [{MaDoiTac}] {TenDoiTac} | ĐT: {SoDienThoai} | Dư nợ: {SoDuCongNoHienTai:N0} đ");
        }
    }

    public class KhachHangNongDan_Real : DoiTacKinhDoanhNongDuoc_Real
    {
        public string TenCanhDongRuong { get; set; } = "Cánh đồng Ba Thê";
    }

    public class NhaCungCapHoaChat_Real : DoiTacKinhDoanhNongDuoc_Real
    {
        public string GiayPhepKinhDoanhHoaChat { get; set; } = "GP-2024-AG";
    }
}
