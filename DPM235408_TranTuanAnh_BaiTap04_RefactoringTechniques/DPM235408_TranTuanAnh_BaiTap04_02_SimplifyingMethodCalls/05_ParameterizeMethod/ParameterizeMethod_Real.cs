using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._05_ParameterizeMethod
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Chính sách trợ giá và bình ổn thị trường vật tư nông nghiệp
    // Gộp các phương thức giảm giá cố định thành phương thức nhận tỷ lệ phần trăm và lý do hỗ trợ
    public class BinhOnGiaNongDuoc_Real
    {
        public decimal ApDungChinhSachHoTro(string tenVatTu, decimal donGiaGoc, double tiLeGiam, string lyDoHoTro)
        {
            decimal tienGiam = donGiaGoc * (decimal)tiLeGiam;
            decimal donGiaSauHoTro = donGiaGoc - tienGiam;

            Console.WriteLine($"   [CHÍNH SÁCH BÌNH ỔN] {tenVatTu} | Giá gốc: {donGiaGoc:N0} đ | Giảm {tiLeGiam:P0} ({lyDoHoTro}): -{tienGiam:N0} đ -> Giá mới: {donGiaSauHoTro:N0} đ");
            return donGiaSauHoTro;
        }
    }
}
