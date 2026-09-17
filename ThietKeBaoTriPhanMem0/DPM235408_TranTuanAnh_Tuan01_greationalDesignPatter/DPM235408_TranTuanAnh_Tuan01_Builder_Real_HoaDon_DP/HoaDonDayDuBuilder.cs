using System;

namespace DPM235408_TranTuanAnh_Tuan01_Builder_Real_HoaDon_DP
{
    // Concrete Builder: XÃ¢y dá»±ng hÃ³a Ä‘Æ¡n Ä‘áº§y Ä‘á»§ (cÃ³ váº­n chuyá»ƒn, cÃ³ giáº£m giÃ¡)
    public class HoaDonDayDuBuilder : IHoaDonBuilder
    {
        private HoaDonBanHang _hoaDon = new HoaDonBanHang();

        public HoaDonDayDuBuilder() { this.Reset(); }
        public void Reset() { this._hoaDon = new HoaDonBanHang(); }

        public void TaoChiTietSanPham() { this._hoaDon.Add("Sáº£n pháº©m: Thuá»‘c trá»« sÃ¢u ABC (SL: 10)"); }
        public void ThemDichVuPhu() { this._hoaDon.Add("Dá»‹ch vá»¥ phá»¥: Phun thuá»‘c há»™"); }
        public void ThemChiPhiVanChuyen() { this._hoaDon.Add("PhÃ­ váº­n chuyá»ƒn: 50.000 VNÄ"); }
        public void ThemGiamGiaKhuyenMai() { this._hoaDon.Add("Giáº£m giÃ¡: 10% (ChÆ°Æ¡ng trÃ¬nh MÃ¹a Vá»¥)"); }

        public HoaDonBanHang GetHoaDon()
        {
            HoaDonBanHang result = this._hoaDon;
            this.Reset();
            return result;
        }
    }
}
