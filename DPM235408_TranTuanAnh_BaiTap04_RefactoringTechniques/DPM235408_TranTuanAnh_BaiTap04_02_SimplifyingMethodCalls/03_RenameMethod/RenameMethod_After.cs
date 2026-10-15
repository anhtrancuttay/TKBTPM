namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._03_RenameMethod
{
    // AFTER: Đổi tên phương thức tường minh, phản ánh đúng mục đích nghiệp vụ
    public class TinhToan_After
    {
        public decimal TinhTienSauChietKhau(decimal tongTienGoc, double phanTramChietKhau)
        {
            decimal tienGiam = tongTienGoc * (decimal)phanTramChietKhau;
            return tongTienGoc - tienGiam;
        }
    }
}
