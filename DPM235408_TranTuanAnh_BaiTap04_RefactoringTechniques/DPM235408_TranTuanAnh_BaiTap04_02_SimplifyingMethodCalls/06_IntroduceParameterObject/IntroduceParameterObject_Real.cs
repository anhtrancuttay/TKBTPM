using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._06_IntroduceParameterObject
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Báo cáo doanh thu đa chiều theo khoảng thời gian (frmDoanhThu.cs)
    // Đóng gói các tham số lọc rườm rà thành đối tượng BoLocThongKeDoanhThu_Real
    public record BoLocThongKeDoanhThu_Real
    {
        public DateTime TuNgay { get; init; } = DateTime.Today.AddDays(-30);
        public DateTime DenNgay { get; init; } = DateTime.Today;
        public string HuyenThi { get; init; } = "Châu Phú";
        public string NhomHang { get; init; } = "Thuốc Trừ Bệnh";
        public bool ChiLayDonDaThuTien { get; init; } = true;
    }

    public class ThongKeDoanhThuNongDuoc_Real
    {
        public void XuatBaoCaoDoanhThu(BoLocThongKeDoanhThu_Real boLoc)
        {
            Console.WriteLine("   ================= BÁO CÁO DOANH THU NÔNG DƯỢC =================");
            Console.WriteLine($"   * Khoảng thời gian: {boLoc.TuNgay:dd/MM/yyyy} -> {boLoc.DenNgay:dd/MM/yyyy}");
            Console.WriteLine($"   * Địa bàn huyện:   {boLoc.HuyenThi}");
            Console.WriteLine($"   * Nhóm sản phẩm:   {boLoc.NhomHang}");
            Console.WriteLine($"   * Đã thu tiền:     {(boLoc.ChiLayDonDaThuTien ? "Chỉ lấy hóa đơn hoàn tất" : "Tất cả")}");
            Console.WriteLine("   -> Tổng doanh thu ước đạt: 1,280,000,000 VNĐ | Lợi nhuận gộp: 185,000,000 VNĐ");
        }
    }
}
