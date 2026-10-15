using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._07_PreserveWholeObject
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Thẩm định lô thuốc BVTV xuất bán (frmBanLe / frmBanSi)
    // Thay vì truyền lẻ tẻ từng trường, truyền nguyên vẹn đối tượng LoThuocBaoVeThucVat_Real
    public class LoThuocBaoVeThucVat_Real
    {
        public string MaLo { get; set; } = "LO-2026-TILT";
        public string TenThuoc { get; set; } = "Tilt Super 300EC";
        public DateTime HanSuDung { get; set; } = DateTime.Today.AddDays(180);
        public int SoLuongTon { get; set; } = 250;
        public decimal NhietDoBaoQuanHienTai { get; set; } = 24.5m; // Yêu cầu dưới 30 độ C
    }

    public class KiemDinhXuatKho_Real
    {
        // Truyền nguyên đối tượng (Preserve Whole Object)
        public bool KiemTraLoDatChuanXuatKho(LoThuocBaoVeThucVat_Real loThuoc, int soLuongCanXuat)
        {
            bool conHan = loThuoc.HanSuDung > DateTime.Today.AddDays(30);
            bool duSoLuong = loThuoc.SoLuongTon >= soLuongCanXuat;
            bool baoQuanTot = loThuoc.NhietDoBaoQuanHienTai <= 30.0m;

            if (conHan && duSoLuong && baoQuanTot)
            {
                Console.WriteLine($"   [ĐẠT CHUẨN XUẤT KHO] Lô: {loThuoc.MaLo} ({loThuoc.TenThuoc}) | Tồn: {loThuoc.SoLuongTon} | HSD: {loThuoc.HanSuDung:dd/MM/yyyy}");
                return true;
            }

            Console.WriteLine($"   [TỪ CHỐI] Lô {loThuoc.MaLo} không đủ điều kiện xuất kho!");
            return false;
        }
    }
}
