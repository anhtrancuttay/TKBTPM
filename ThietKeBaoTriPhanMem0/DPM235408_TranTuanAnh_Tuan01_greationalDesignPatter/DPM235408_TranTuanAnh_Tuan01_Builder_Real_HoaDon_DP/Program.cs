using System;
using System.Text;

namespace DPM235408_TranTuanAnh_Tuan01_Builder_Real_HoaDon_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== MáºªU BUILDER: Láº¬P HÃ“A ÄÆ N BÃN HÃ€NG ===\n");

            var director = new NhanVienThuNgan();
            var builder = new HoaDonDayDuBuilder();
            director.Builder = builder;

            Console.WriteLine("1. Láº­p hÃ³a Ä‘Æ¡n mua táº¡i quáº§y (KhÃ´ng giao hÃ ng, khÃ´ng dá»‹ch vá»¥):");
            director.LapHoaDonCoBan();
            Console.WriteLine(builder.GetHoaDon().HienThiHoaDon());

            Console.WriteLine("2. Láº­p hÃ³a Ä‘Æ¡n giao táº­n nÆ¡i (Äáº§y Ä‘á»§ chi phÃ­, cÃ³ giáº£m giÃ¡):");
            director.LapHoaDonDichVuTamDiem();
            Console.WriteLine(builder.GetHoaDon().HienThiHoaDon());

            Console.ReadLine();
        }
    }
}