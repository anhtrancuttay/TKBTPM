using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._04_ReplaceConditionalWithPolymorphism
{
    // BEFORE: Sử dụng switch-case hoặc if-else theo mã loại để tính toán hành vi
    public class ChietKhauNhanVien_Before
    {
        public const int NHAN_VIEN_THU_VIEC = 1;
        public const int NHAN_VIEN_CHINH_THUC = 2;
        public const int TRUONG_PHONG = 3;

        public decimal TinhThuong(int loaiNhanVien, decimal doanhSo)
        {
            switch (loaiNhanVien)
            {
                case NHAN_VIEN_THU_VIEC:
                    return doanhSo * 0.02m;
                case NHAN_VIEN_CHINH_THUC:
                    return doanhSo * 0.05m;
                case TRUONG_PHONG:
                    return doanhSo * 0.10m + 2000000m;
                default:
                    throw new ArgumentException("Loại nhân viên không hợp lệ");
            }
        }
    }
}
