using System;

namespace DPM235408_TranTuanAnh_Tuan01_Factory_Real_NhanVien_DP
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Khá»Ÿi cháº¡y quy trÃ¬nh táº¡o NhÃ¢n viÃªn BÃ¡n hÃ ng...");
            ClientCode(new PhongNhanSuBanHang());

            Console.WriteLine("\n--------------------------------------------------\n");

            Console.WriteLine("App: Khá»Ÿi cháº¡y quy trÃ¬nh táº¡o NhÃ¢n viÃªn Quáº£n lÃ½...");
            ClientCode(new PhongNhanSuQuanLy());
        }

        public void ClientCode(PhongNhanSu phongNhanSu)
        {
            // Client code hoáº¡t Ä‘á»™ng thÃ´ng qua abstract class, khÃ´ng bá»‹ phá»¥ thuá»™c vÃ o class cá»¥ thá»ƒ
            Console.WriteLine("Client: Chá»©c nÄƒng phÃ¢n quyá»n khÃ´ng cáº§n biáº¿t class cá»¥ thá»ƒ cá»§a nhÃ¢n viÃªn, nhÆ°ng váº«n hoáº¡t Ä‘á»™ng chÃ­nh xÃ¡c.\n> "
                + phongNhanSu.PhanCongCongViec());
        }
    }
}
