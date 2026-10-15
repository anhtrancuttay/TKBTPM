namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._07_ExtractSuperclass
{
    // AFTER: Trích xuất lớp cha trừu tượng DoiTac_After chứa các thuộc tính chung
    public abstract class DoiTac_After
    {
        public string MaDinhDanh { get; set; } = string.Empty;
        public string Ten { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public decimal TongCongNo { get; set; }
    }

    public class KhachHang_After : DoiTac_After
    {
        public int DiemTichLuy { get; set; }
    }

    public class NhaCungCap_After : DoiTac_After
    {
        public string MaSoThue { get; set; } = string.Empty;
    }
}
