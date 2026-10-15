namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._08_RemoveSettingMethod
{
    // BEFORE: Thuộc tính Id hoặc MaKhoanVay có setter công khai, cho phép thay đổi tùy tiện sau khi khởi tạo
    public class TaiKhoan_Before
    {
        public string MaTaiKhoan { get; set; } = string.Empty;
        public decimal SoDu { get; set; }
    }
}
