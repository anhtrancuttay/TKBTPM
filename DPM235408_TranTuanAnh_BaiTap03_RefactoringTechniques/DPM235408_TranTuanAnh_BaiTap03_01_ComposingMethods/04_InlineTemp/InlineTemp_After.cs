namespace DPM235408_TranTuanAnh_BaiTap03_01_ComposingMethods._04_InlineTemp
{
    // AFTER: Inline Temp
    public class TinhGia_After
    {
        public bool KiemTraGiaCao(DonHang_After dh) => dh.LayDonGia() > 1000000;
    }
    public class DonHang_After { public double LayDonGia() => 1500000; }
}
