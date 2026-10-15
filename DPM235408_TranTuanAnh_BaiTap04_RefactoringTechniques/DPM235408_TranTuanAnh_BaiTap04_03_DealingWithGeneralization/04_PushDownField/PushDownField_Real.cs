using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._04_PushDownField
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Phân loại an toàn hóa chất nông nghiệp (frmSanPham.cs)
    // Đẩy trường ChiSoDocCapTinhLD50 và VachMauCanhBao từ lớp cha xuống lớp con ThuocBVTVDocHai_Real
    public abstract class MatHangNongNghiep_Real
    {
        public string MaHang { get; set; } = string.Empty;
        public string TenHang { get; set; } = string.Empty;
        public decimal GiaBan { get; set; }
    }

    // Mặt hàng an toàn: Không chứa độc chất
    public class PhanHuuCoViSinh_Real : MatHangNongNghiep_Real
    {
        public string LoaiChungViSinh { get; set; } = "Trichoderma";
    }

    // Mặt hàng nguy hiểm: Cần quản lý nghiêm ngặt chỉ số độc tính
    public class ThuocBaoVeThucVatDocHai_Real : MatHangNongNghiep_Real
    {
        // Push Down Field: Chỉ lớp này mới cần quản lý LD50 và Vạch màu
        public int ChiSoDocCapTinhLD50 { get; set; } = 450; // mg/kg
        public string VachMauCanhBao { get; set; } = "Vàng (Độc trung bình - Nhóm II)";

        public void InThongTinAnToan()
        {
            Console.WriteLine($"   [HÓA CHẤT ĐỘC] {TenHang} | LD50: {ChiSoDocCapTinhLD50} mg/kg | Cảnh báo: {VachMauCanhBao}");
        }
    }
}
