using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._08_ExtractInterface
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Quy chuẩn kiểm định KCS lô hàng trước xuất kho
    // Trích xuất Interface IKiemDinhChatLuongNongDuoc_Real để Module KCS chỉ làm việc với hợp đồng kiểm định
    public interface IKiemDinhChatLuongNongDuoc_Real
    {
        string MaLoHang { get; }
        DateTime HanSuDung { get; }
        double TiLeTapChatPhanTram { get; }
        bool KiemTraDatChuanTieuChuanCoSo();
    }

    public class LoThuocTruSau_Real : IKiemDinhChatLuongNongDuoc_Real
    {
        public string MaLoHang { get; set; } = "LO-TS-2026";
        public string TenThuoc { get; set; } = "Beam 75WP";
        public DateTime HanSuDung { get; set; } = DateTime.Today.AddMonths(18);
        public double TiLeTapChatPhanTram { get; set; } = 0.02; // 0.02%

        public bool KiemTraDatChuanTieuChuanCoSo() => TiLeTapChatPhanTram <= 0.05 && HanSuDung > DateTime.Today;
    }

    public class LoPhanBonNhapKhau_Real : IKiemDinhChatLuongNongDuoc_Real
    {
        public string MaLoHang { get; set; } = "LO-PB-DAP-2026";
        public string XuatXuQuocGia { get; set; } = "Philippines";
        public DateTime HanSuDung { get; set; } = DateTime.Today.AddYears(2);
        public double TiLeTapChatPhanTram { get; set; } = 0.01;

        public bool KiemTraDatChuanTieuChuanCoSo() => TiLeTapChatPhanTram <= 0.03;
    }

    public class ChuyenVienKCS_Real
    {
        public void ThamDinhLo(IKiemDinhChatLuongNongDuoc_Real loHang)
        {
            bool dat = loHang.KiemTraDatChuanTieuChuanCoSo();
            Console.WriteLine($"   [KCS THẨM ĐỊNH] Lô: {loHang.MaLoHang} | Tạp chất: {loHang.TiLeTapChatPhanTram:P2} | Kết luận: {(dat ? "ĐẠT TIÊU CHUẨN XUẤT XƯỞNG" : "KHÔNG ĐẠT")}");
        }
    }
}
