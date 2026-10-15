namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._07_PreserveWholeObject
{
    // BEFORE: Lấy lẻ tẻ các giá trị từ đối tượng rồi truyền vào phương thức
    public class KhachHang_Before
    {
        public int Tuoi { get; set; } = 35;
        public decimal ThuNhap { get; set; } = 25000000;
        public int DiemTinDung { get; set; } = 750;
    }

    public class ThamDinh_Before
    {
        public bool DuDieuKienVay(int tuoi, decimal thuNhap, int diem)
        {
            return tuoi >= 18 && thuNhap >= 10000000 && diem >= 600;
        }
    }
}
