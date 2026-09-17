using System;
using System.Text;

namespace DPM235408_TranTuanAnh_Tuan01_Prototype_Real_LoHang_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== MáºªU PROTOTYPE: QUáº¢N LÃ LÃ” HÃ€NG ===\n");

            // Táº¡o lÃ´ hÃ ng gá»‘c
            LoHangNongDuoc loGoc = new LoHangNongDuoc("L001", "PhÃ¢n bÃ³n NPK", "CÃ´ng ty ABC", new DateTime(2027, 1, 1));
            Console.WriteLine("ThÃ´ng tin LÃ´ hÃ ng gá»‘c:");
            loGoc.HienThiThongTin();

            Console.WriteLine("\nThá»±c hiá»‡n nháº­p kho lÃ´ má»›i cÃ¹ng loáº¡i hÃ ng, chá»‰ khÃ¡c Háº¡n sá»­ dá»¥ng...");
            // NhÃ¢n báº£n vÃ  sá»­a Ä‘á»•i thuá»™c tÃ­nh cáº§n thiáº¿t
            LoHangNongDuoc loMoi = (LoHangNongDuoc)loGoc.Clone();
            loMoi.MaLo = "L002";
            loMoi.NgayHetHan = new DateTime(2028, 5, 1);

            Console.WriteLine("\nThÃ´ng tin LÃ´ hÃ ng má»›i (nhÃ¢n báº£n tá»« lÃ´ gá»‘c):");
            loMoi.HienThiThongTin();

            Console.ReadLine();
        }
    }
}