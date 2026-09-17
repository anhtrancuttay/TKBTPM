using System;
using System.Text;

namespace DPM235408_TranTuanAnh_Tuan01_Singleton_Real_Database_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== MáºªU SINGLETON: QUáº¢N LÃ PHIÃŠN ÄÄ‚NG NHáº¬P ===\n");

            // NÆ¡i nÃ o trong chÆ°Æ¡ng trÃ¬nh cÅ©ng gá»i Ä‘Æ°á»£c GetInstance() vÃ  nÃ³ luÃ´n trá» vá» 1 Ä‘á»‘i tÆ°á»£ng duy nháº¥t
            PhienDangNhap session1 = PhienDangNhap.GetInstance();
            session1.DangNhap("Nguyá»…n Tuáº¥n Anh", "Admin");

            PhienDangNhap session2 = PhienDangNhap.GetInstance();

            Console.WriteLine($"\nKiá»ƒm tra Session 2: User Ä‘ang login lÃ  {session2.TenNhanVien}");

            if (session1 == session2)
            {
                Console.WriteLine("=> Singleton hoáº¡t Ä‘á»™ng Ä‘Ãºng: session1 vÃ  session2 lÃ  cÃ¹ng má»™t phiÃªn Ä‘Äƒng nháº­p.");
            }
            Console.ReadLine();
        }
    }
}