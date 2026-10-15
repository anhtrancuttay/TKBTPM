namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._01_PullUpField
{
    // BEFORE: Hai lớp con cùng khai báo trường MaDinhDanh và Ten
    public class SanPham_Before { }

    public class ThuocTruSau_Before : SanPham_Before
    {
        public string MaSanPham { get; set; } = string.Empty;
        public string TenSanPham { get; set; } = string.Empty;
    }

    public class PhanBon_Before : SanPham_Before
    {
        public string MaSanPham { get; set; } = string.Empty;
        public string TenSanPham { get; set; } = string.Empty;
    }
}
