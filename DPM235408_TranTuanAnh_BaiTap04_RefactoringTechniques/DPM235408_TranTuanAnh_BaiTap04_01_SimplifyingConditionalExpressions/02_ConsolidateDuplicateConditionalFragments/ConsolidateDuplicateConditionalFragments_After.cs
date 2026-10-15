using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._02_ConsolidateDuplicateConditionalFragments
{
    // AFTER: Đưa các đoạn mã trùng lặp ra ngoài câu lệnh điều kiện
    public class XuLyDonHang_After
    {
        public void XuLyGiaoHang(bool laDonGiaoNhanh, decimal tienHang)
        {
            decimal phiVanChuyen = laDonGiaoNhanh ? 50000 : 20000;
            Console.WriteLine($"Tính phí: {phiVanChuyen:N0} đ");

            // Đưa ra ngoài if-else vì cả 2 nhánh đều thực thi
            GuiThongBaoKhachHang();
            GhiNhatKyHeThong();
        }

        private void GuiThongBaoKhachHang() => Console.WriteLine("Đã gửi SMS cho khách hàng.");
        private void GhiNhatKyHeThong() => Console.WriteLine("Đã ghi log đơn hàng.");
    }
}
