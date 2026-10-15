using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._03_PullUpConstructorBody
{
    // AFTER: Đưa phần gán dữ liệu chung lên constructor lớp cha và gọi base(...)
    public class NhanVien_After
    {
        public string MaSo { get; }
        public string Ten { get; }
        public DateTime NgayVaoLam { get; }

        public NhanVien_After(string ma, string ten, DateTime ngay)
        {
            MaSo = ma;
            Ten = ten;
            NgayVaoLam = ngay;
        }
    }

    public class QuanLy_After : NhanVien_After
    {
        public decimal PhuCap { get; }

        public QuanLy_After(string ma, string ten, DateTime ngay, decimal phuCap)
            : base(ma, ten, ngay)
        {
            PhuCap = phuCap;
        }
    }

    public class NhanVienThuKho_After : NhanVien_After
    {
        public string MaKhoPhuTrach { get; }

        public NhanVienThuKho_After(string ma, string ten, DateTime ngay, string maKho)
            : base(ma, ten, ngay)
        {
            MaKhoPhuTrach = maKho;
        }
    }
}
