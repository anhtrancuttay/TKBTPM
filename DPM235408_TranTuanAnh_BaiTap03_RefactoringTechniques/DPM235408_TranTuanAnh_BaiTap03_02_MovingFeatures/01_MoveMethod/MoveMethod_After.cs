namespace DPM235408_TranTuanAnh_BaiTap03_02_MovingFeatures._01_MoveMethod
{
    // AFTER: Move Method về TaiKhoan
    public class TaiKhoan_After
    {
        public double SoDu { get; private set; } = 5000000;
        public void RutTien(double tien) => SoDu -= tien;
    }
}
