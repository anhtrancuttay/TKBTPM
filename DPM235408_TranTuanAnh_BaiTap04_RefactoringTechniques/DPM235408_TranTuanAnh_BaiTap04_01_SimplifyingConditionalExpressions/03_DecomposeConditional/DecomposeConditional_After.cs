using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._03_DecomposeConditional
{
    // AFTER: Phân rã điều kiện thành phương thức boolean và tách logic nhánh rõ nghĩa
    public class TinhPhiDichVu_After
    {
        public decimal TinhGia(DateTime ngay, int soLuong, decimal donGia)
        {
            if (LaMuaCaoDiem(ngay))
                return TinhGiaMuaCaoDiem(soLuong, donGia);

            return TinhGiaBinhThuong(soLuong, donGia);
        }

        private bool LaMuaCaoDiem(DateTime ngay) => ngay.Month >= 6 && ngay.Month <= 8;

        private decimal TinhGiaMuaCaoDiem(int soLuong, decimal donGia) => soLuong * donGia * 1.2m;

        private decimal TinhGiaBinhThuong(int soLuong, decimal donGia) => soLuong * donGia;
    }
}
