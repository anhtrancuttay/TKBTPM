namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._11_HideMethod
{
    // BEFORE: Phương thức trợ giúp nội bộ nhưng lại được khai báo public
    public class MayChu_Before
    {
        public void KhoiDong()
        {
            DocCauHinh();
            KetNoiCoSoDuLieu();
        }

        // Các hàm này chỉ dùng nội bộ khi khởi động, để public dễ bị gọi sai quy trình
        public void DocCauHinh() => System.Console.WriteLine("Đọc cấu hình hệ thống...");
        public void KetNoiCoSoDuLieu() => System.Console.WriteLine("Kết nối CSDL...");
    }
}
