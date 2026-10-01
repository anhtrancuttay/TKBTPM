namespace DPM235408_TranTuanAnh_BaiTap03_02_MovingFeatures._02_MoveField
{
    // AFTER: Move Field về đúng LoaiTaiKhoan
    public class LoaiTaiKhoan_After
    {
        public double TiLeLaiSuat { get; set; } = 0.05;
    }
    public class TaiKhoan_After
    {
        public LoaiTaiKhoan_After Loai { get; set; } = new();
        public double LayLaiSuat() => Loai.TiLeLaiSuat;
    }
}
