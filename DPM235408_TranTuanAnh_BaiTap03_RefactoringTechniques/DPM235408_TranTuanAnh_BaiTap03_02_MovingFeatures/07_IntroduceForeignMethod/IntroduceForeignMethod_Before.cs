using System;
namespace DPM235408_TranTuanAnh_BaiTap03_02_MovingFeatures._07_IntroduceForeignMethod
{
    // BEFORE: Viết logic xử lý ngày của lớp DateTime rải rác
    public class Client_Before
    {
        public void Xuly(DateTime ngay)
        {
            DateTime ngaySau = ngay.AddDays(1);
        }
    }
}
