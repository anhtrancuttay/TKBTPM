namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._07_ExtractSuperclass
{
    // BEFORE: Hai lớp riêng biệt nhưng có nhiều thuộc tính và hành vi tương đồng
    public class KhachHang_Before
    {
        public string MaDinhDanh { get; set; } = string.Empty;
        public string Ten { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public decimal TongCongNo { get; set; }
    }

    public class NhaCungCap_Before
    {
        public string MaDinhDanh { get; set; } = string.Empty;
        public string Ten { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public decimal TongCongNo { get; set; }
    }
}
