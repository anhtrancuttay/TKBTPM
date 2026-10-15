using System;
using System.Diagnostics;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._08_IntroduceAssertion
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Ràng buộc hợp lệ dữ liệu xuất kho (frmSoLuongTon.cs)
    // Đảm bảo số lượng xuất không âm, không vượt tồn kho và tỷ lệ chiết khấu hợp lệ
    public class RangBuocXuatKhoNongDuoc_Real
    {
        public decimal TinhGiaSauChietKhau(int soLuongTon, int soLuongXuat, decimal donGia, double tiLeChietKhau)
        {
            // 1. Assertion kiểm tra giả định hệ thống nội bộ
            Debug.Assert(soLuongTon >= 0, "Dữ liệu tồn kho bị lỗi âm!");
            Debug.Assert(donGia > 0, "Đơn giá sản phẩm nông dược phải dương!");

            // 2. Kiểm tra điều kiện đầu vào nghiệp vụ
            if (soLuongXuat <= 0)
                throw new ArgumentException("Số lượng xuất kho phải lớn hơn 0!");

            if (soLuongXuat > soLuongTon)
                throw new InvalidOperationException($"Số lượng xuất ({soLuongXuat}) vượt quá tồn kho khả dụng ({soLuongTon})!");

            if (tiLeChietKhau < 0 || tiLeChietKhau > 0.50)
                throw new ArgumentOutOfRangeException(nameof(tiLeChietKhau), "Tỷ lệ chiết khấu tối đa cho phép là 50%!");

            decimal thanhTienGoc = soLuongXuat * donGia;
            decimal tienChietKhau = thanhTienGoc * (decimal)tiLeChietKhau;
            decimal thanhTienCuoi = thanhTienGoc - tienChietKhau;

            Console.WriteLine($"   [XUẤT KHO THÀNH CÔNG] Xuất: {soLuongXuat} | Tồn còn: {soLuongTon - soLuongXuat} | Tổng tiền: {thanhTienCuoi:N0} đ");
            return thanhTienCuoi;
        }
    }
}
