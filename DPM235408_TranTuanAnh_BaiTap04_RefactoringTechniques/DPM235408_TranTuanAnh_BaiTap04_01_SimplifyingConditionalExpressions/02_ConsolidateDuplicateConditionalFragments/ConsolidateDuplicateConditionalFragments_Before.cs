using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._02_ConsolidateDuplicateConditionalFragments
{
    // BEFORE: Đoạn mã gửi thông báo và ghi log bị trùng lặp ở cả hai nhánh điều kiện
    public class XuLyDonHang_Before
    {
        public void XuLyGiaoHang(bool laDonGiaoNhanh, decimal tienHang)
        {
            decimal phiVanChuyen;
            if (laDonGiaoNhanh)
            {
                phiVanChuyen = 50000;
                Console.WriteLine($"Tính phí: {phiVanChuyen:N0} đ");
                GuiThongBaoKhachHang();
                GhiNhatKyHeThong();
            }
            else
            {
                phiVanChuyen = 20000;
                Console.WriteLine($"Tính phí: {phiVanChuyen:N0} đ");
                GuiThongBaoKhachHang();
                GhiNhatKyHeThong();
            }
        }

        private void GuiThongBaoKhachHang() => Console.WriteLine("Đã gửi SMS cho khách hàng.");
        private void GhiNhatKyHeThong() => Console.WriteLine("Đã ghi log đơn hàng.");
    }
}
