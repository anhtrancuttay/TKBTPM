namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._11_HideMethod
{
    // AFTER: Ẩn các phương thức trợ giúp nội bộ bằng private/protected
    public class MayChu_After
    {
        public void KhoiDong()
        {
            DocCauHinh();
            KetNoiCoSoDuLieu();
            System.Console.WriteLine("Máy chủ đã sẵn sàng hoạt động!");
        }

        // Chuyển thành private để tuân thủ nguyên tắc đóng gói (Encapsulation)
        private void DocCauHinh() => System.Console.WriteLine("Đọc cấu hình hệ thống...");
        private void KetNoiCoSoDuLieu() => System.Console.WriteLine("Kết nối CSDL...");
    }
}
