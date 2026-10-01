using System;
namespace DPM235408_TranTuanAnh_BaiTap03_02_MovingFeatures._07_IntroduceForeignMethod
{
    // AFTER: Introduce Foreign Method tại Client
    public class Client_After
    {
        public DateTime NgayGiaoKeTiep(DateTime ngay) => ngay.AddDays(1);
    }
}
