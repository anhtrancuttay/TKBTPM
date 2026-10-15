using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._06_ReplaceNestedConditionalWithGuardClauses
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Thẩm định duyệt phiếu nhập kho vật tư (frmNhapHang.cs)
    // Áp dụng Guard Clauses kiểm tra các điều kiện tiên quyết trước khi nhập kho
    public class ThamDinhNhapKhoNongDuoc_Real
    {
        public bool KiemTraHopLeNhapKho(string maNCC, int soLuongNhap, int hsdConLaiThang, int sucChuaKhoConLai, out string lyDoTuChoi)
        {
            // Guard clause 1: Nhà cung cấp phải hợp lệ
            if (string.IsNullOrWhiteSpace(maNCC))
            {
                lyDoTuChoi = "Mã Nhà cung cấp không được để trống!";
                return false;
            }

            // Guard clause 2: Số lượng nhập phải lớn hơn 0
            if (soLuongNhap <= 0)
            {
                lyDoTuChoi = "Số lượng nhập kho phải lớn hơn 0!";
                return false;
            }

            // Guard clause 3: Hạn dùng của lô thuốc nhập mới phải còn trên 6 tháng
            if (hsdConLaiThang < 6)
            {
                lyDoTuChoi = "Hạn sử dụng còn lại dưới 6 tháng, từ chối nhập kho!";
                return false;
            }

            // Guard clause 4: Sức chứa của kho phải đủ
            if (soLuongNhap > sucChuaKhoConLai)
            {
                lyDoTuChoi = $"Kho không đủ chỗ chứa (Cần {soLuongNhap}, chỉ còn {sucChuaKhoConLai})!";
                return false;
            }

            // Tuyến tính - Luồng thành công (Happy Path)
            lyDoTuChoi = "Phiếu nhập kho hợp lệ, sẵn sàng ghi nhận thẻ kho.";
            Console.WriteLine($"   [DUYỆT THÀNH CÔNG] NCC: {maNCC} | Số lượng: {soLuongNhap} | HSD: {hsdConLaiThang} tháng");
            return true;
        }
    }
}
