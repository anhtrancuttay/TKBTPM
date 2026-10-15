namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._12_ReplaceDelegationWithInheritance
{
    // BEFORE: Lớp con ủy quyền toàn bộ phương thức cho một đối tượng mà nó thực sự có mối quan hệ "is-a"
    public class Nguoi_Before
    {
        public string Ten { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
    }

    public class NhanVien_Before
    {
        private readonly Nguoi_Before _nguoi = new();

        // Viết lại hàng loạt phương thức ủy quyền đơn giản (Middle Man)
        public string Ten { get => _nguoi.Ten; set => _nguoi.Ten = value; }
        public string SoDienThoai { get => _nguoi.SoDienThoai; set => _nguoi.SoDienThoai = value; }
    }
}
