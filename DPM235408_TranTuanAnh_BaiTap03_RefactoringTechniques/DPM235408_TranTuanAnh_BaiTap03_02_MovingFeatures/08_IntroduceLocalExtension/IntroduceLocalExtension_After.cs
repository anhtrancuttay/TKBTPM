using System;
namespace DPM235408_TranTuanAnh_BaiTap03_02_MovingFeatures._08_IntroduceLocalExtension
{
    // AFTER: Extension Methods (Local Extension trong C#)
    public static class DateTimeExtensions
    {
        public static bool IsHetHan(this DateTime hsd) => (hsd.Date - DateTime.Today).Days < 0;
        public static bool IsCanDate(this DateTime hsd) => (hsd.Date - DateTime.Today).Days is >= 0 and <= 30;
    }
}
