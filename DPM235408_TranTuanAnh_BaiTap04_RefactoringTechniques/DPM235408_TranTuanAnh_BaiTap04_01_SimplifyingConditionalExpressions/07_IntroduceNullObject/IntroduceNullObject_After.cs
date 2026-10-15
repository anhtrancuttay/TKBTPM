using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._07_IntroduceNullObject
{
    // AFTER: Giới thiệu Null Object để cung cấp hành vi mặc định, loại bỏ hoàn toàn kiểm tra null
    public interface IKhachHang_After
    {
        string Ten { get; }
        decimal TinhGiamGia();
        bool IsNull { get; }
    }

    public class KhachHangThanhVien_After : IKhachHang_After
    {
        public string Ten { get; set; } = string.Empty;
        public decimal TinhGiamGia() => 0.05m;
        public bool IsNull => false;
    }

    // Null Object đóng gói hành vi cho trường hợp không có khách hàng
    public class NullKhachHang_After : IKhachHang_After
    {
        public string Ten => "Khách vãng lai";
        public decimal TinhGiamGia() => 0m;
        public bool IsNull => true;
    }

    public class DonHang_After
    {
        public IKhachHang_After KhachHang { get; set; } = new NullKhachHang_After();

        public void InThongTin()
        {
            // Không cần if (KhachHang == null) nữa!
            Console.WriteLine($"Khách: {KhachHang.Ten} | Giảm giá: {KhachHang.TinhGiamGia():P0}");
        }
    }
}
