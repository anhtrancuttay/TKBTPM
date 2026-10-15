using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._03_DecomposeConditional
{
    // BEFORE: Biểu thức điều kiện lộn xộn trong if-else khiến code khó đọc
    public class TinhPhiDichVu_Before
    {
        public decimal TinhGia(DateTime ngay, int soLuong, decimal donGia)
        {
            decimal ketQua;
            if (ngay.Month >= 6 && ngay.Month <= 8)
            {
                ketQua = soLuong * donGia * 1.2m; // Mùa cao điểm phụ thu 20%
            }
            else
            {
                ketQua = soLuong * donGia;
            }
            return ketQua;
        }
    }
}
