namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._05_ParameterizeMethod
{
    // BEFORE: Nhiều phương thức làm việc tương tự chỉ khác nhau giá trị số
    public class TangGia_Before
    {
        public decimal TangGia5PhanTram(decimal giaHienTai) => giaHienTai * 1.05m;
        public decimal TangGia10PhanTram(decimal giaHienTai) => giaHienTai * 1.10m;
        public decimal TangGia15PhanTram(decimal giaHienTai) => giaHienTai * 1.15m;
    }
}
