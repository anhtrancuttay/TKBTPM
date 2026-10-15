namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._10_ReplaceParameterWithMethodCall
{
    // BEFORE: Caller phải tự gọi phương thức phụ rồi truyền kết quả đó vào phương thức chính
    public class DonHang_Before
    {
        public int SoLuong { get; set; } = 10;
        public decimal DonGia { get; set; } = 150000;

        public decimal LayGiaCoSo() => SoLuong * DonGia;

        // Phương thức nhận giá cơ sở từ bên ngoài truyền vào
        public decimal TinhGiaSauGiam(decimal giaCoSo, int capDo)
        {
            decimal giam = (capDo > 1) ? 0.1m : 0.05m;
            return giaCoSo * (1 - giam);
        }
    }
}
