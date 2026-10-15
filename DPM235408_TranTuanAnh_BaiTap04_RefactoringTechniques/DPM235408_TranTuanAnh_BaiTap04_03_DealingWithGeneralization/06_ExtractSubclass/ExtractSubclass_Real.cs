using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._06_ExtractSubclass
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Phân cấp Đại lý phân phối (frmDaiLy.cs)
    // Tách lớp con DaiLyCap1VIP_Real để quản lý hạn mức công nợ lớn và chính sách kỹ sư túc trực
    public class DaiLyPhanPhoi_Real
    {
        public string MaDaiLy { get; set; } = string.Empty;
        public string TenDaiLy { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public decimal DoanhSoNam { get; set; }

        public virtual decimal TinhHanMucCongNo() => 50000000m; // 50 triệu
    }

    public class DaiLyCap1VIP_Real : DaiLyPhanPhoi_Real
    {
        public string KySuNongNghiepPhuTrach { get; set; } = "Kỹ sư Trần Văn Lúa";
        public decimal TienThuongCuoiNam { get; set; } = 80000000m;

        // Ghi đè hạn mức tín dụng đặc biệt cho đại lý chiến lược
        public override decimal TinhHanMucCongNo() => 500000000m; // 500 triệu

        public void InChinhSachVIP()
        {
            Console.WriteLine($"   [ĐẠI LÝ VIP CẤP 1] {TenDaiLy} | Hạn mức nợ: {TinhHanMucCongNo():N0} đ | KS hỗ trợ: {KySuNongNghiepPhuTrach}");
        }
    }
}
