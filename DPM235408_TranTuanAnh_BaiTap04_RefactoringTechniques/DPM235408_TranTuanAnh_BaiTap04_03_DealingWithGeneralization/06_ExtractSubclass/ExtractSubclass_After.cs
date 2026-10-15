namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._06_ExtractSubclass
{
    // AFTER: Tách thành lớp con riêng cho trường hợp đặc thù
    public class KhachHang_After
    {
        public string Ten { get; set; } = string.Empty;
        public decimal TongMua { get; set; }
    }

    public class KhachHangVIP_After : KhachHang_After
    {
        public decimal HanMucTinDungVIP { get; set; } = 100000000;
        public string ChuyenVienTuVanRieng { get; set; } = string.Empty;
    }
}
