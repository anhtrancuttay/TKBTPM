using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._09_CollapseHierarchy
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Tối giản phân cấp danh mục thuốc (frmSanPham.cs)
    // Sáp nhập lớp con lười biếng ThuocDangBot_Real vào lớp ThuocBaoVeThucVat_Real (Collapse Hierarchy)
    public class ThuocBaoVeThucVat_Real
    {
        public string MaThuoc { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public decimal DonGia { get; set; }

        // Thay vì tách riêng lớp con ThuocDangBot, dùng thuộc tính DangBaoChe
        public string DangBaoChe { get; set; } = "Nhũ dầu (EC)"; // Dạng bột (WP, WG), dạng nước (SL, SC)

        public void InThongTinChiTiet()
        {
            Console.WriteLine($"   [THUỐC BVTV] {MaThuoc} - {TenThuoc} | Dạng bào chế: {DangBaoChe} | Giá: {DonGia:N0} đ");
        }
    }
}
