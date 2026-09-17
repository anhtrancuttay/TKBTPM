using System;

namespace DPM235408_TranTuanAnh_Tuan01_Factory_Real_NhanVien_DP
{
    // Concrete Creator 2: Xá»­ lÃ½ tuyá»ƒn dá»¥ng/táº¡o tÃ i khoáº£n cho nhÃ¢n viÃªn quáº£n lÃ½
    public class PhongNhanSuQuanLy : PhongNhanSu
    {
        public override INhanVien TaoNhanVien()
        {
            return new NhanVienQuanLy();
        }
    }
}
