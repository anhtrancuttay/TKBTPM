namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._02_RemoveParameter
{
    // BEFORE: Tham số maKhoCu không còn được sử dụng trong thân phương thức nhưng vẫn tồn tại
    public class ChuyenKho_Before
    {
        public void ThucHienChuyenKho(string maLoHang, int soLuong, string maKhoMoi, string maKhoCu)
        {
            // maKhoCu không hề được sử dụng ở đây
            System.Console.WriteLine($"Chuyển {soLuong} đơn vị của lô {maLoHang} sang kho {maKhoMoi}.");
        }
    }
}
