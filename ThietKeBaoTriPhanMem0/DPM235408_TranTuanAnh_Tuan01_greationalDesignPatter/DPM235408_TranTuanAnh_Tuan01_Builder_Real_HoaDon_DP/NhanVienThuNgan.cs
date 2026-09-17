using System;

namespace DPM235408_TranTuanAnh_Tuan01_Builder_Real_HoaDon_DP
{
    // Director: Quáº£n lÃ½ luá»“ng táº¡o hÃ³a Ä‘Æ¡n
    public class NhanVienThuNgan
    {
        private IHoaDonBuilder? _builder;
        public IHoaDonBuilder Builder { set { _builder = value; } }

        public void LapHoaDonCoBan()
        {
            this._builder?.TaoChiTietSanPham();
        }

        public void LapHoaDonDichVuTamDiem()
        {
            this._builder?.TaoChiTietSanPham();
            this._builder?.ThemDichVuPhu();
            this._builder?.ThemChiPhiVanChuyen();
            this._builder?.ThemGiamGiaKhuyenMai();
        }
    }
}
