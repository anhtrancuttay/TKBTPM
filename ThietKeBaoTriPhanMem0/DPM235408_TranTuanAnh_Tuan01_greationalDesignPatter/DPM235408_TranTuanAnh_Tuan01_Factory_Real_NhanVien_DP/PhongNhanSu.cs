using System;

namespace DPM235408_TranTuanAnh_Tuan01_Factory_Real_NhanVien_DP
{
    // Lá»›p Creator trá»«u tÆ°á»£ng (NhÃ  mÃ¡y/PhÃ²ng nhÃ¢n sá»± chung)
    public abstract class PhongNhanSu
    {
        // Factory Method
        public abstract INhanVien TaoNhanVien();

        // Core business logic (SomeOperation)
        public string PhanCongCongViec()
        {
            // Gá»i factory method Ä‘á»ƒ táº¡o Ä‘á»‘i tÆ°á»£ng nhÃ¢n viÃªn
            var nhanVien = TaoNhanVien();
            // Sá»­ dá»¥ng Ä‘á»‘i tÆ°á»£ng vá»«a táº¡o vÃ o quy trÃ¬nh nghiá»‡p vá»¥ chung
            var ketQua = "Há»‡ thá»‘ng phÃ¢n cÃ´ng thÃ nh cÃ´ng: " + nhanVien.HienThiQuyenHan();
            return ketQua;
        }
    }
}
