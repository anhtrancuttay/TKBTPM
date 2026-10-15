namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._06_ExtractSubclass
{
    // BEFORE: Lớp KhachHang chứa các thuộc tính đặc biệt chỉ dùng cho khách VIP
    public class KhachHang_Before
    {
        public string Ten { get; set; } = string.Empty;
        public decimal TongMua { get; set; }

        // Các thuộc tính dưới đây chỉ dùng khi LaKhachVIP = true
        public bool LaKhachVIP { get; set; }
        public decimal HanMucTinDungVIP { get; set; }
        public string ChuyenVienTuVanRieng { get; set; } = string.Empty;
    }
}
