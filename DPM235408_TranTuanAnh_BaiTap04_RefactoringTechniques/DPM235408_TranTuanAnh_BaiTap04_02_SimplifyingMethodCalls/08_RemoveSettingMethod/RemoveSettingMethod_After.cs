namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._08_RemoveSettingMethod
{
    // AFTER: Bỏ setter hoặc dùng init-only/private setter để đảm bảo tính bất biến của định danh
    public class TaiKhoan_After
    {
        public string MaTaiKhoan { get; }
        public decimal SoDu { get; private set; }

        public TaiKhoan_After(string maTaiKhoan, decimal soDuBanDau)
        {
            MaTaiKhoan = maTaiKhoan;
            SoDu = soDuBanDau;
        }

        public void CongTien(decimal soTien) => SoDu += soTien;
    }
}
