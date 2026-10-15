using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._07_IntroduceNullObject
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Xử lý khách hàng bán lẻ (frmBanLe.cs)
    // Áp dụng Null Object Pattern cho Khách hàng vãng lai không đăng ký hồ sơ
    public interface IKhachHangBanLe_Real
    {
        string MaKhachHang { get; }
        string HoTen { get; }
        string SoDienThoai { get; }
        decimal HanMucCongNo { get; }
        void TichDiemThuong(decimal soTienMua);
        bool ChoPhepGhiNo { get; }
    }

    // 1. Khách hàng thân thiết có hồ sơ lưu trữ
    public class KhachHangThanhVien_Real : IKhachHangBanLe_Real
    {
        public string MaKhachHang { get; set; } = "KH001";
        public string HoTen { get; set; } = "Nguyễn Văn Nông (Tri Tôn)";
        public string SoDienThoai { get; set; } = "0918123456";
        public decimal HanMucCongNo => 20000000m;
        public int DiemTichLuy { get; private set; }

        public void TichDiemThuong(decimal soTienMua)
        {
            int diemMoi = (int)(soTienMua / 100000);
            DiemTichLuy += diemMoi;
            Console.WriteLine($"   -> [TÍCH ĐIỂM] Khách '{HoTen}' được cộng {diemMoi} điểm. Tổng điểm: {DiemTichLuy}");
        }

        public bool ChoPhepGhiNo => true;
    }

    // 2. Null Object: Khách mua lẻ vãng lai (không đăng ký hồ sơ)
    public class KhachHangVangLai_Real : IKhachHangBanLe_Real
    {
        public string MaKhachHang => "VL-AN-GIANG";
        public string HoTen => "Khách mua lẻ vãng lai (Không lưu hồ sơ)";
        public string SoDienThoai => "Không có";
        public decimal HanMucCongNo => 0m;

        public void TichDiemThuong(decimal soTienMua)
        {
            // Null behavior: Khách vãng lai không tích điểm, không gây lỗi NullReferenceException
            Console.WriteLine("   -> [THÔNG BÁO] Khách vãng lai không tích điểm thành viên.");
        }

        public bool ChoPhepGhiNo => false;
    }
}
