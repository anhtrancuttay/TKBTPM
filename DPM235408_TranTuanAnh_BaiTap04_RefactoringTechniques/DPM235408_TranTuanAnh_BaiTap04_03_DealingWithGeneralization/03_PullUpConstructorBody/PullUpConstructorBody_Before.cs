using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._03_PullUpConstructorBody
{
    // BEFORE: Constructor của các lớp con đều lặp lại việc gán MaSo, Ten, NgayTao
    public class NhanVien_Before
    {
        public string MaSo { get; protected set; } = string.Empty;
        public string Ten { get; protected set; } = string.Empty;
        public DateTime NgayVaoLam { get; protected set; }
    }

    public class QuanLy_Before : NhanVien_Before
    {
        public decimal PhuCap { get; }

        public QuanLy_Before(string ma, string ten, DateTime ngay, decimal phuCap)
        {
            MaSo = ma;
            Ten = ten;
            NgayVaoLam = ngay;
            PhuCap = phuCap;
        }
    }

    public class NhanVienThuKho_Before : NhanVien_Before
    {
        public string MaKhoPhuTrach { get; }

        public NhanVienThuKho_Before(string ma, string ten, DateTime ngay, string maKho)
        {
            MaSo = ma;
            Ten = ten;
            NgayVaoLam = ngay;
            MaKhoPhuTrach = maKho;
        }
    }
}
