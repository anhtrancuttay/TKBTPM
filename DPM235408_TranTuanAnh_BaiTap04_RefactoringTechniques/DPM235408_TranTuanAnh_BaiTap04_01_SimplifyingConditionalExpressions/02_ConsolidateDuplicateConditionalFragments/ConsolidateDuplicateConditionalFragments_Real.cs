using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._02_ConsolidateDuplicateConditionalFragments
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Xử lý xuất kho bán sỉ/bán lẻ thuốc BVTV
    // Trích xuất thao tác ghi sổ kho và in biên nhận ra ngoài phân nhánh loại khách
    public class LapPhieuXuatKhoNongDuoc_Real
    {
        public void LapPhieuXuat(string maPhieu, bool laBanSi, decimal giaTriHang, decimal phuPhiVanChuyen)
        {
            decimal tongTien;
            if (laBanSi)
            {
                // Bán sỉ: Chiết khấu đại lý 10%
                decimal chietKhau = giaTriHang * 0.10m;
                tongTien = (giaTriHang - chietKhau) + phuPhiVanChuyen;
                Console.WriteLine($"   [XUẤT BÁN SỈ] Phiếu {maPhieu} | Chiết khấu 10%: {chietKhau:N0} đ | Tổng: {tongTien:N0} đ");
            }
            else
            {
                // Bán lẻ: Không chiết khấu, áp dụng giá bán niêm yết
                tongTien = giaTriHang + phuPhiVanChuyen;
                Console.WriteLine($"   [XUẤT BÁN LẺ] Phiếu {maPhieu} | Không chiết khấu | Tổng: {tongTien:N0} đ");
            }

            // Gộp thao tác trùng lặp (Consolidate Duplicate Conditional Fragments)
            CapNhatTheKhoVaSoCongNo(maPhieu, tongTien);
            InPhieuGiaoNhanHang(maPhieu);
        }

        private void CapNhatTheKhoVaSoCongNo(string maPhieu, decimal tongTien)
        {
            Console.WriteLine($"   -> [HỆ THỐNG] Đã cập nhật thẻ kho & ghi nợ phiếu {maPhieu} với số tiền: {tongTien:N0} đ");
        }

        private void InPhieuGiaoNhanHang(string maPhieu)
        {
            Console.WriteLine($"   -> [MÁY IN] Đã xuất lệnh in phiếu giao hàng 3 liên cho phiếu {maPhieu}");
        }
    }
}
