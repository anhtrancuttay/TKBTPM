using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._12_ReplaceDelegationWithInheritance
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Chứng từ bán lẻ thuốc BVTV (BusinessObject/PhieuBan.cs)
    // Thay vì ủy quyền trung gian từng thuộc tính cho ChungTuBanHang, kế thừa trực tiếp để tái sử dụng mã nguồn
    public class ChungTuBanHangGoc_Real
    {
        public string MaChungTu { get; set; } = string.Empty;
        public DateTime NgayGiaoDich { get; set; } = DateTime.Today;
        public decimal TongTienThanhToan { get; set; }

        public virtual void InBanInChungTu()
        {
            Console.WriteLine($"   [CHỨNG TỪ BÁN HÀNG] Số: {MaChungTu} | Ngày: {NgayGiaoDich:dd/MM/yyyy} | Tổng: {TongTienThanhToan:N0} đ");
        }
    }

    // Kế thừa trực tiếp (Replace Delegation with Inheritance)
    public class PhieuBanLeNongDuoc_Real : ChungTuBanHangGoc_Real
    {
        public string TenNongDanMua { get; set; } = string.Empty;
        public string DiaChiNhanThuoc { get; set; } = string.Empty;

        public override void InBanInChungTu()
        {
            base.InBanInChungTu();
            Console.WriteLine($"   -> Giao trực tiếp cho nông dân: '{TenNongDanMua}' tại: '{DiaChiNhanThuoc}'");
        }
    }
}
