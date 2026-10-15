using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._02_RemoveParameter
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Xử lý tiêu hủy thuốc BVTV hết hạn (frmSanphamHethan.cs)
    // Loại bỏ tham số dư thừa maNhanVienCu và soDienThoai (vì hệ thống đã tự lấy từ Context phiên đăng nhập)
    public class TieuHuyThuocHetHan_Real
    {
        public void LapBienBanTieuHuy(string maLoThuoc, string tenThuoc, int soLuongHuy, string lyDo)
        {
            Console.WriteLine($"   [BIÊN BẢN TIÊU HỦY] Lô: {maLoThuoc} | Tên thuốc: {tenThuoc} | Số lượng: {soLuongHuy} chai/gói | Lý do: {lyDo}");
            Console.WriteLine($"   -> Đã trừ tồn kho và gửi báo cáo thanh lý đến Chi cục BVTV tỉnh An Giang.");
        }
    }
}
