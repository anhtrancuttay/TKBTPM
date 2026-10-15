namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._12_ReplaceConstructorWithFactoryMethod
{
    // AFTER: Thay thế constructor bằng Static Factory Methods tường minh ý nghĩa
    public class NhanVien_After
    {
        public string ChucVu { get; }
        public decimal Luong { get; }

        private NhanVien_After(string chucVu, decimal luong)
        {
            ChucVu = chucVu;
            Luong = luong;
        }

        public static NhanVien_After TaoNhanVienBanHang(decimal luongCoBan)
            => new NhanVien_After("Nhân viên Bán hàng", luongCoBan);

        public static NhanVien_After TaoQuanLyKho(decimal luongCoBan, decimal phuCapTrachNhiem)
            => new NhanVien_After("Thủ kho Quản lý", luongCoBan + phuCapTrachNhiem);
    }
}
