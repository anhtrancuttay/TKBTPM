using System;

namespace DPM235408_TranTuanAnh_Tuan01_Factory_Real_NhanVien_DP
{
    // Concrete Product 1: Cung cáº¥p chi tiáº¿t quyá»n háº¡n cá»§a nhÃ¢n viÃªn bÃ¡n hÃ ng
    public class NhanVienBanHang : INhanVien
    {
        public string HienThiQuyenHan()
        {
            return "{NhÃ¢n viÃªn BÃ¡n hÃ ng} - ÄÆ°á»£c phÃ©p láº­p hÃ³a Ä‘Æ¡n, nháº­p dá»‹ch vá»¥ phÃ¡t sinh vÃ  xem thá»‘ng kÃª hÃ³a Ä‘Æ¡n do mÃ¬nh láº­p.";
        }
    }
}
