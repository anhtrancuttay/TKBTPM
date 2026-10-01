using System;
namespace DPM235408_TranTuanAnh_BaiTap03_02_MovingFeatures._08_IntroduceLocalExtension
{
    // BEFORE: Code tiện ích cho DateTime lặp lại
    public class KiemTra_Before
    {
        public bool IsHetHan(DateTime hsd) => (hsd.Date - DateTime.Today).Days < 0;
    }
}
