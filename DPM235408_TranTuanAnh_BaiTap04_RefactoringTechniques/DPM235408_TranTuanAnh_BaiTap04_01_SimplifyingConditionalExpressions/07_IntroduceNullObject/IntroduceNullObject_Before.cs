using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._07_IntroduceNullObject
{
    // BEFORE: Phải liên tục kiểm tra if (khachHang == null) ở khắp nơi trong mã nguồn
    public class KhachHang_Before
    {
        public string Ten { get; set; } = string.Empty;
        public decimal TinhGiamGia() => 0.05m;
    }

    public class DonHang_Before
    {
        public KhachHang_Before? KhachHang { get; set; }

        public void InThongTin()
        {
            string ten = (KhachHang == null) ? "Khách vãng lai" : KhachHang.Ten;
            decimal giamGia = (KhachHang == null) ? 0 : KhachHang.TinhGiamGia();

            Console.WriteLine($"Khách: {ten} | Giảm giá: {giamGia:P0}");
        }
    }
}
