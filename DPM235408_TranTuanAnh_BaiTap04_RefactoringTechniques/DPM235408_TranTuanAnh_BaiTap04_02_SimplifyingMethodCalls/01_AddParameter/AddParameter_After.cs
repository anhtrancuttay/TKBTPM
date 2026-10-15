namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._01_AddParameter
{
    // AFTER: Bổ sung tham số cần thiết vào phương thức
    public class HoaDon_After
    {
        public decimal TinhTongTien(decimal tienHang, double tiLeThueVAT)
        {
            decimal thue = tienHang * (decimal)tiLeThueVAT;
            return tienHang + thue;
        }
    }
}
