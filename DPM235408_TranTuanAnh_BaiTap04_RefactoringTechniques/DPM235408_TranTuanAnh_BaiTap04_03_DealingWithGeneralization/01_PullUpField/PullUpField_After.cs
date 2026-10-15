namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._01_PullUpField
{
    // AFTER: Đưa trường dữ liệu dùng chung lên lớp cha
    public abstract class SanPham_After
    {
        public string MaSanPham { get; set; } = string.Empty;
        public string TenSanPham { get; set; } = string.Empty;
    }

    public class ThuocTruSau_After : SanPham_After
    {
        public string HoatChat { get; set; } = string.Empty;
    }

    public class PhanBon_After : SanPham_After
    {
        public string HamLuongNPK { get; set; } = string.Empty;
    }
}
