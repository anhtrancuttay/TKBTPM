using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._01_AddParameter
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Tính tổng hóa đơn bán sỉ nông dược (frmBanSi.cs)
    // Bổ sung thêm tham số thuế VAT và phụ phí vận chuyển xe tải vào phương thức
    public class TinhHoaDonBanSiNongDuoc_Real
    {
        public decimal TinhTongHoaDonBanSi(decimal tienHang, double tiLeChietKhau, double tiLeThueVAT, decimal phiXeTaiGiaoRuong)
        {
            decimal tienChietKhau = tienHang * (decimal)tiLeChietKhau;
            decimal tienSauChietKhau = tienHang - tienChietKhau;
            decimal tienVAT = tienSauChietKhau * (decimal)tiLeThueVAT;
            decimal tongThanhToan = tienSauChietKhau + tienVAT + phiXeTaiGiaoRuong;

            Console.WriteLine($"   [BÁN SỈ] Tiền hàng: {tienHang:N0} đ | CK ({tiLeChietKhau:P0}): -{tienChietKhau:N0} đ | VAT ({tiLeThueVAT:P0}): +{tienVAT:N0} đ | Xe tải: +{phiXeTaiGiaoRuong:N0} đ -> Tổng: {tongThanhToan:N0} đ");
            return tongThanhToan;
        }
    }
}
