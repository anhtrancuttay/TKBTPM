using System;
using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._14_ReplaceExceptionWithTest
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Tra cứu bảng giá niêm yết khi quét mã vạch (frmSanPham.cs)
    // Dùng TryGetValue kiểm tra trước thay vì bắt KeyNotFoundException gây suy giảm hiệu năng
    public class TraCuuGiaNongDuoc_Real
    {
        private readonly Dictionary<string, (string TenThuoc, decimal DonGia)> _danhMucGia = new()
        {
            ["8935001"] = ("Tilt Super 300EC", 240000m),
            ["8935002"] = ("Anvil 5SC", 145000m),
            ["8935003"] = ("Ridomil Gold 68WG", 195000m)
        };

        public decimal TraCuuDonGia(string maVach, out string tenThuoc)
        {
            // Kiểm tra điều kiện trước (Replace Exception with Test)
            if (_danhMucGia.TryGetValue(maVach, out var thongTin))
            {
                tenThuoc = thongTin.TenThuoc;
                Console.WriteLine($"   [TÌM THẤY] Mã {maVach}: {thongTin.TenThuoc} - Đơn giá: {thongTin.DonGia:N0} đ");
                return thongTin.DonGia;
            }

            tenThuoc = "Sản phẩm chưa có trong danh mục";
            Console.WriteLine($"   [KHÔNG TÌM THẤY] Mã vạch '{maVach}' chưa được cấu hình giá niêm yết!");
            return 0;
        }
    }
}
