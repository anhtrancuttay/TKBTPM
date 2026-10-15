using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._02_PullUpMethod
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Xử lý in ấn chứng từ kho (frmInPhieuBan.cs / frmInPhieuNhap.cs)
    // Kéo phương thức in Footer ký xác nhận 3 bên lên lớp cha chung PhieuKhoBase_Real
    public abstract class PhieuKhoBase_Real
    {
        public string SoChungTu { get; set; } = string.Empty;
        public DateTime NgayPhatSinh { get; set; } = DateTime.Today;
        public decimal TongGiaTri { get; set; }

        // Pull Up Method: Đưa lên lớp cha
        public void InFooterXacNhanKyTen()
        {
            Console.WriteLine($"   --- [CHỨNG TỪ: {SoChungTu}] - Ngày: {NgayPhatSinh:dd/MM/yyyy} - Trị giá: {TongGiaTri:N0} đ ---");
            Console.WriteLine("   [Thủ kho ký]            [Kế toán trưởng ký]            [Khách hàng / Tài xế ký]");
            Console.WriteLine("   (Ký, ghi rõ họ tên)     (Ký, ghi rõ họ tên)            (Ký, ghi rõ họ tên)");
        }
    }

    public class PhieuXuatKhoBanLe_Real : PhieuKhoBase_Real
    {
        public string TenKhachHang { get; set; } = "Bà con xã Vĩnh Thạnh Trung";
    }

    public class PhieuNhapVatTuTuNhaMay_Real : PhieuKhoBase_Real
    {
        public string TenNhaMayCungCap { get; set; } = "Công ty TNHH Syngenta Việt Nam";
    }
}
