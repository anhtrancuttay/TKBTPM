using System;

namespace DPM235408_TranTuanAnh_Tuan01_Builder_Real_HoaDon_DP
{
    // Builder Interface
    public interface IHoaDonBuilder
    {
        void TaoChiTietSanPham();
        void ThemDichVuPhu();
        void ThemChiPhiVanChuyen();
        void ThemGiamGiaKhuyenMai();
        HoaDonBanHang GetHoaDon();
    }
}
