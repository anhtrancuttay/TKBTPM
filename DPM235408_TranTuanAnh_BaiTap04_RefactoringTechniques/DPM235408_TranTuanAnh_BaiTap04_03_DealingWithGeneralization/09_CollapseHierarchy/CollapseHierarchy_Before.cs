namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._09_CollapseHierarchy
{
    // BEFORE: Phân cấp thừa kế rườm rà (Lazy Class) khi lớp con không hề có hành vi hay dữ liệu đặc thù
    public class NhanVien_Before
    {
        public string Ten { get; set; } = string.Empty;
        public decimal Luong { get; set; }
    }

    // Lớp con này hoàn toàn rỗng, không có giá trị phân biệt
    public class NhanVienThuong_Before : NhanVien_Before { }
}
