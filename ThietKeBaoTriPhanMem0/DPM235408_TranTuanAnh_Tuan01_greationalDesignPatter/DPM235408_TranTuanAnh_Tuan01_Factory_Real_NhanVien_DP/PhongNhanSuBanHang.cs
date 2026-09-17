using System;

namespace DPM235408_TranTuanAnh_Tuan01_Factory_Real_NhanVien_DP
{
    // Concrete Creator 1: Xá»­ lÃ½ tuyá»ƒn dá»¥ng/táº¡o tÃ i khoáº£n cho nhÃ¢n viÃªn bÃ¡n hÃ ng
    public class PhongNhanSuBanHang : PhongNhanSu
    {
        public override INhanVien TaoNhanVien()
        {
            return new NhanVienBanHang();
        }
    }
}
