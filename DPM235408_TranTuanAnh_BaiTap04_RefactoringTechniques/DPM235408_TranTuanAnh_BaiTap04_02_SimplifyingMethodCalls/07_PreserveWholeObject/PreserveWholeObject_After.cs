namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._07_PreserveWholeObject
{
    // AFTER: Truyền nguyên vẹn đối tượng KhachHang vào phương thức
    public class KhachHang_After
    {
        public int Tuoi { get; set; } = 35;
        public decimal ThuNhap { get; set; } = 25000000;
        public int DiemTinDung { get; set; } = 750;
    }

    public class ThamDinh_After
    {
        public bool DuDieuKienVay(KhachHang_After khachHang)
        {
            return khachHang.Tuoi >= 18 && khachHang.ThuNhap >= 10000000 && khachHang.DiemTinDung >= 600;
        }
    }
}
