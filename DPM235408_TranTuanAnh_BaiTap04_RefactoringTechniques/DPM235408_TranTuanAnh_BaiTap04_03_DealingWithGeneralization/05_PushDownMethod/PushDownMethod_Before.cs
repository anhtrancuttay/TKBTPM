namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._05_PushDownMethod
{
    // BEFORE: Lớp cha chứa phương thức KichHoatBaoBiTuHuy nhưng chỉ lớp con hóa chất nguy hiểm mới cần
    public class BaoBi_Before
    {
        public void KichHoatPhaoTuHuy()
        {
            System.Console.WriteLine("Kích hoạt quy trình bao bì tự hủy chống tái sử dụng.");
        }
    }

    public class BaoBiPhanBon_Before : BaoBi_Before { }
    public class BaoBiThuocDoc_Before : BaoBi_Before { }
}
