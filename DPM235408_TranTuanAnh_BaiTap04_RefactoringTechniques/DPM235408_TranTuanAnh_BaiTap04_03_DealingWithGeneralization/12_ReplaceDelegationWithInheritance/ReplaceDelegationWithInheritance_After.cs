namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._12_ReplaceDelegationWithInheritance
{
    // AFTER: Chuyển sang kế thừa trực tiếp để loại bỏ mã boilerplate ủy quyền rườm rà
    public class Nguoi_After
    {
        public string Ten { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
    }

    public class NhanVien_After : Nguoi_After
    {
        public string MaNhanVien { get; set; } = string.Empty;
    }
}
