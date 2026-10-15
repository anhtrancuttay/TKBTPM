namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._10_ReplaceParameterWithMethodCall
{
    // AFTER: Phương thức tự gọi LayGiaCoSo() nội bộ, loại bỏ tham số trung gian
    public class DonHang_After
    {
        public int SoLuong { get; set; } = 10;
        public decimal DonGia { get; set; } = 150000;

        public decimal LayGiaCoSo() => SoLuong * DonGia;

        public decimal TinhGiaSauGiam(int capDo)
        {
            decimal giaCoSo = LayGiaCoSo(); // Tự gọi thay vì bắt caller truyền vào
            decimal giam = (capDo > 1) ? 0.1m : 0.05m;
            return giaCoSo * (1 - giam);
        }
    }
}
