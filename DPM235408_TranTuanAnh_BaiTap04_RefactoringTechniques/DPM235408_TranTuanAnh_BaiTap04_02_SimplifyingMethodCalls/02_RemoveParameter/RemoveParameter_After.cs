namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._02_RemoveParameter
{
    // AFTER: Loại bỏ tham số dư thừa giúp chữ ký hàm gọn gàng, giảm nhầm lẫn cho caller
    public class ChuyenKho_After
    {
        public void ThucHienChuyenKho(string maLoHang, int soLuong, string maKhoMoi)
        {
            System.Console.WriteLine($"Chuyển {soLuong} đơn vị của lô {maLoHang} sang kho {maKhoMoi}.");
        }
    }
}
