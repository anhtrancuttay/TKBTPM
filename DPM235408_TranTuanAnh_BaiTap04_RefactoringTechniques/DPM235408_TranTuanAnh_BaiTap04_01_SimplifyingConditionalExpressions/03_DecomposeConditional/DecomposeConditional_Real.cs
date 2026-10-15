using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._03_DecomposeConditional
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Định giá vật tư theo mùa vụ canh tác lúa
    // Vụ lúa Đông Xuân (Tháng 11 đến Tháng 3 năm sau): Áp dụng chính sách trợ giá và chiết khấu theo gói lớn
    // Các tháng mùa kiệt khác: Áp dụng đơn giá thông thường
    public class DinhGiaMuaVuNongDuoc_Real
    {
        public decimal TinhTienPhanBon(DateTime ngayMua, int soBao, decimal donGiaGoc)
        {
            if (LaMuaVuDongXuan(ngayMua))
                return TinhGiaTroCapDongXuan(soBao, donGiaGoc);

            return TinhGiaThongThuong(soBao, donGiaGoc);
        }

        // Tách biểu thức điều kiện phức tạp (Decompose Conditional Expression)
        public bool LaMuaVuDongXuan(DateTime ngay)
        {
            return ngay.Month == 11 || ngay.Month == 12 || ngay.Month <= 3;
        }

        // Tách nhánh then thành hàm rõ nghĩa
        private decimal TinhGiaTroCapDongXuan(int soBao, decimal donGiaGoc)
        {
            // Trợ giá 8% trực tiếp cho bà con nông dân vào mùa xuống giống
            decimal giaUuDai = donGiaGoc * 0.92m;
            return soBao * giaUuDai;
        }

        // Tách nhánh else thành hàm rõ nghĩa
        private decimal TinhGiaThongThuong(int soBao, decimal donGiaGoc)
        {
            return soBao * donGiaGoc;
        }
    }
}
