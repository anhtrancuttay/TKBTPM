using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._01_PullUpField
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Quản lý danh mục sản phẩm (frmSanPham.cs)
    // Đưa các trường dữ liệu chung (MaSanPham, TenSanPham, DonViTinh, DonGia) lên lớp cha VatTuNongNghiep_Real
    public abstract class VatTuNongNghiep_Real
    {
        public string MaSanPham { get; set; } = string.Empty;
        public string TenSanPham { get; set; } = string.Empty;
        public string DonViTinh { get; set; } = "Chai";
        public decimal DonGiaNiemYet { get; set; }

        public virtual void InThongTin()
        {
            Console.WriteLine($"   [{MaSanPham}] {TenSanPham} | ĐVT: {DonViTinh} | Đơn giá: {DonGiaNiemYet:N0} đ");
        }
    }

    public class ThuocTruSauSinhHoc_Real : VatTuNongNghiep_Real
    {
        public string HoatChatDocQuyen { get; set; } = "Emamectin Benzoate";
        public int ThoiGianCachLyNgay { get; set; } = 7;
    }

    public class PhanBonLaCaoCap_Real : VatTuNongNghiep_Real
    {
        public string CongThucNPK { get; set; } = "30-10-10 + TE";
        public double TheTichMl { get; set; } = 500;
    }
}
