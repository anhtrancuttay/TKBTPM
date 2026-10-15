namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._04_ReplaceConditionalWithPolymorphism
{
    // AFTER: Đa hình hóa thành các lớp con với phương thức trừu tượng
    public abstract class NhanVien_After
    {
        public abstract decimal TinhThuong(decimal doanhSo);
    }

    public class NhanVienThuViec_After : NhanVien_After
    {
        public override decimal TinhThuong(decimal doanhSo) => doanhSo * 0.02m;
    }

    public class NhanVienChinhThuc_After : NhanVien_After
    {
        public override decimal TinhThuong(decimal doanhSo) => doanhSo * 0.05m;
    }

    public class TruongPhong_After : NhanVien_After
    {
        public override decimal TinhThuong(decimal doanhSo) => doanhSo * 0.10m + 2000000m;
    }
}
