using System;
using System.Text;

namespace DPM235408_TranTuanAnh_Tuan01_Factory_Real_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Há»— trá»£ hiá»ƒn thá»‹ tiáº¿ng Viá»‡t cÃ³ dáº¥u trÃªn Console
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("==================================================");
            Console.WriteLine("Äá»“ Ã¡n: Quáº£n lÃ½ bÃ¡n hÃ ng CÃ´ng ty NÃ´ng dÆ°á»£c An Giang");
            Console.WriteLine("Máº«u thiáº¿t káº¿: Factory Method (PhÃ¢n quyá»n nhÃ¢n viÃªn)");
            Console.WriteLine("Thá»±c hiá»‡n: Nguyá»…n Tuáº¥n Anh - DPM235407");
            Console.WriteLine("==================================================\n");

            new Client().Main();

            Console.ReadLine();
        }
    }
}