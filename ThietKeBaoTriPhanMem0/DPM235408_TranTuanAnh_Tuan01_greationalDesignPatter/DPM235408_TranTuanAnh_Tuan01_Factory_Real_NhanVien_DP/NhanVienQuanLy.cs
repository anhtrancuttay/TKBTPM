using System;

namespace DPM235408_TranTuanAnh_Tuan01_Factory_Real_NhanVien_DP
{
    // Concrete Product 2: Cung cáº¥p chi tiáº¿t quyá»n háº¡n cá»§a nhÃ¢n viÃªn quáº£n lÃ½
    public class NhanVienQuanLy : INhanVien
    {
        public string HienThiQuyenHan()
        {
            return "{NhÃ¢n viÃªn Quáº£n lÃ½} - ÄÆ°á»£c phÃ©p cáº¥u hÃ¬nh nháº­p/xuáº¥t kho (FIFO), phÃ¢n lÃ´ hÃ ng vÃ  xem toÃ n bá»™ thá»‘ng kÃª cÃ´ng ty.";
        }
    }
}
