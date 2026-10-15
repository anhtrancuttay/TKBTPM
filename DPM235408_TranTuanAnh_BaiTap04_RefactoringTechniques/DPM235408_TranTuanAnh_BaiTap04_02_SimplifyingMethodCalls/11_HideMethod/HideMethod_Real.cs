using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._11_HideMethod
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Xử lý ghi nhận phiếu thu công nợ (frmThanhToan.cs)
    // Ẩn các phương thức xử lý sổ cái kế toán nhạy cảm (Hide Method) để đảm bảo toàn vẹn dữ liệu
    public class QuanLyCongNoNongDuoc_Real
    {
        // Điểm truy cập công khai duy nhất cho nhân viên thu ngân
        public void ThuTienCongNo(string maKhachHang, decimal soTienThu, string nguoiThu)
        {
            if (soTienThu <= 0) throw new ArgumentException("Số tiền thu phải lớn hơn 0");

            KiemTraKhoaSoKeToan();
            GhiVaoSoQuyTienMat(maKhachHang, soTienThu);
            CapNhatDuNoKhachHang(maKhachHang, soTienThu);
            Console.WriteLine($"   [KẾ TOÁN ĐÃ DUYỆT] Thu nợ KH: {maKhachHang} | Số tiền: {soTienThu:N0} đ | Người thu: {nguoiThu}");
        }

        // Ẩn (private) các thao tác hạch toán nội bộ
        private void KiemTraKhoaSoKeToan()
        {
            // Kiểm tra kỳ kế toán tháng hiện tại có đang mở hay không
        }

        private void GhiVaoSoQuyTienMat(string maKH, decimal tien)
        {
            // Ghi nhật ký định khoản Nợ TK 111 / Có TK 131
        }

        private void CapNhatDuNoKhachHang(string maKH, decimal tien)
        {
            // Giảm số dư nợ của đại lý trên hệ thống
        }
    }
}
