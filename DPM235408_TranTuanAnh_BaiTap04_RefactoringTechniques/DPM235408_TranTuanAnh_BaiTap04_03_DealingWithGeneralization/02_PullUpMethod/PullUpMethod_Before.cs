using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._02_PullUpMethod
{
    // BEFORE: Hai lớp con có phương thức thực hiện hành vi hoàn toàn giống nhau
    public abstract class ChungTu_Before { }

    public class PhieuThu_Before : ChungTu_Before
    {
        public decimal SoTien { get; set; } = 500000;
        public void InTemBienLai() => Console.WriteLine($"Biên lai tài chính: {SoTien:N0} đ");
    }

    public class PhieuChi_Before : ChungTu_Before
    {
        public decimal SoTien { get; set; } = 200000;
        public void InTemBienLai() => Console.WriteLine($"Biên lai tài chính: {SoTien:N0} đ");
    }
}
