namespace DPM235408_TranTuanAnh_BaiTap03_03_OrganizingData._01_ChangeValueToReference
{
    // BEFORE: Tạo Customer mới cho từng đơn hàng làm mất tính nhất quán
    public class KhachHang_Before { public string Ten { get; set; } = ""; }
    public class DonHang_Before
    {
        public KhachHang_Before Khach { get; set; }
        public DonHang_Before(string ten) { Khach = new KhachHang_Before { Ten = ten }; }
    }
}
