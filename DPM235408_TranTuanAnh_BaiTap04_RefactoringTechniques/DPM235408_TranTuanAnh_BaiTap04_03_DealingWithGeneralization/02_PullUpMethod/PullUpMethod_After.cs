using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._02_PullUpMethod
{
    // AFTER: Đưa phương thức chung lên lớp cha
    public abstract class ChungTu_After
    {
        public decimal SoTien { get; set; }

        public void InTemBienLai() => Console.WriteLine($"Biên lai tài chính: {SoTien:N0} đ");
    }

    public class PhieuThu_After : ChungTu_After { }
    public class PhieuChi_After : ChungTu_After { }
}
