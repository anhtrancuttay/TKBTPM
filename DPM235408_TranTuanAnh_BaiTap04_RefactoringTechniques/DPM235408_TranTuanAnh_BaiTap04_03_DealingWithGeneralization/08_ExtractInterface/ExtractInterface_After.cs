namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._08_ExtractInterface
{
    // AFTER: Trích xuất interface ICoLuong_After chỉ chứa các phương thức mà BangLuong cần
    public interface ICoLuong_After
    {
        decimal Luong { get; }
        decimal TinhTienThuong();
    }

    public class NhanVien_After : ICoLuong_After
    {
        public string Ten { get; set; } = string.Empty;
        public decimal Luong { get; set; }
        public void ChamCong() { }
        public void TinhBaoHiem() { }
        public decimal TinhTienThuong() => Luong * 0.1m;
    }

    public class BangLuong_After
    {
        public decimal TinhTongChiPhi(ICoLuong_After doiTuong)
            => doiTuong.Luong + doiTuong.TinhTienThuong();
    }
}
