namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._12_ReplaceConstructorWithFactoryMethod
{
    // BEFORE: Constructor phức tạp với cờ hiệu khó hiểu
    public class NhanVien_Before
    {
        public int Loai { get; }
        public decimal Luong { get; }

        public NhanVien_Before(int loai, decimal luong)
        {
            Loai = loai;
            Luong = luong;
        }
    }
}
