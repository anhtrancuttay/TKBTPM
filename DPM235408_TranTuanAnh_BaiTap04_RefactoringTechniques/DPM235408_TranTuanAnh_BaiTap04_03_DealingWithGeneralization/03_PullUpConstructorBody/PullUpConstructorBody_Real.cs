using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._03_PullUpConstructorBody
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Khởi tạo chứng từ kho (BusinessObject/)
    // Đưa phần thân khởi tạo chung (MaPhieu, NgayLap, NhanVienLap, GhiChu) lên constructor của lớp cha
    public abstract class ChungTuKhoNongDuoc_Real
    {
        public string MaPhieu { get; }
        public DateTime NgayLap { get; }
        public string NhanVienLap { get; }
        public string GhiChu { get; }

        protected ChungTuKhoNongDuoc_Real(string maPhieu, DateTime ngayLap, string nhanVienLap, string ghiChu)
        {
            MaPhieu = maPhieu;
            NgayLap = ngayLap;
            NhanVienLap = nhanVienLap;
            GhiChu = ghiChu;
        }
    }

    public class PhieuXuatKhoNongSan_Real : ChungTuKhoNongDuoc_Real
    {
        public string MaKhachHang { get; }
        public decimal TongTienXuat { get; }

        public PhieuXuatKhoNongSan_Real(string maPhieu, DateTime ngayLap, string nhanVienLap, string ghiChu, string maKhachHang, decimal tongTien)
            : base(maPhieu, ngayLap, nhanVienLap, ghiChu)
        {
            MaKhachHang = maKhachHang;
            TongTienXuat = tongTien;
        }

        public void InThongTin()
        {
            Console.WriteLine($"   [PHIẾU XUẤT] {MaPhieu} | Ngày: {NgayLap:dd/MM/yyyy} | NV: {NhanVienLap} | KH: {MaKhachHang} | Tiền: {TongTienXuat:N0} đ");
        }
    }
}
