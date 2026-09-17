using System;

namespace DPM235408_TranTuanAnh_Tuan01_Singleton_Real_Database_DP
{
    // Singleton class
    public sealed class PhienDangNhap
    {
        private static PhienDangNhap? _instance;
        private static readonly object _lock = new object();

        // Thuá»™c tÃ­nh cá»§a phiÃªn Ä‘Äƒng nháº­p
        public string TenNhanVien { get; private set; } = string.Empty;
        public string QuyenHan { get; private set; } = string.Empty;
        public DateTime ThoiGianDangNhap { get; private set; }

        // Constructor private Ä‘á»ƒ ngÄƒn cháº·n dÃ¹ng tá»« khÃ³a new tá»« bÃªn ngoÃ i
        private PhienDangNhap() { }

        // Cung cáº¥p Ä‘iá»ƒm truy cáº­p toÃ n cá»¥c
        public static PhienDangNhap GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PhienDangNhap();
                    }
                }
            }
            return _instance;
        }

        public void DangNhap(string tenNhanVien, string quyenHan)
        {
            TenNhanVien = tenNhanVien;
            QuyenHan = quyenHan;
            ThoiGianDangNhap = DateTime.Now;
            Console.WriteLine($"[Há»‡ thá»‘ng] {TenNhanVien} ({QuyenHan}) Ä‘Ã£ Ä‘Äƒng nháº­p thÃ nh cÃ´ng lÃºc {ThoiGianDangNhap}.");
        }
    }
}
