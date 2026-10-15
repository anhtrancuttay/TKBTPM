namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._08_ExtractInterface
{
    // BEFORE: Client phụ thuộc trực tiếp vào lớp cụ thể chứa quá nhiều phương thức không cần thiết
    public class NhanVien_Before
    {
        public string Ten { get; set; } = string.Empty;
        public decimal Luong { get; set; }
        public void ChamCong() { }
        public void TinhBaoHiem() { }
        public decimal TinhTienThuong() => Luong * 0.1m;
    }

    public class BangLuong_Before
    {
        public decimal TinhTongChiPhi(NhanVien_Before nv) => nv.Luong + nv.TinhTienThuong();
    }
}
