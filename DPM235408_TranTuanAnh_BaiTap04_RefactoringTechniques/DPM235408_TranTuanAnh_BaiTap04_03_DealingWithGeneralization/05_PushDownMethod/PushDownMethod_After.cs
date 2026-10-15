namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._05_PushDownMethod
{
    // AFTER: Đẩy phương thức xuống lớp con chuyên biệt
    public class BaoBi_After { }

    public class BaoBiPhanBon_After : BaoBi_After { }

    public class BaoBiThuocDoc_After : BaoBi_After
    {
        public void KichHoatPhaoTuHuy()
        {
            System.Console.WriteLine("Kích hoạt quy trình bao bì tự hủy chống tái sử dụng.");
        }
    }
}
