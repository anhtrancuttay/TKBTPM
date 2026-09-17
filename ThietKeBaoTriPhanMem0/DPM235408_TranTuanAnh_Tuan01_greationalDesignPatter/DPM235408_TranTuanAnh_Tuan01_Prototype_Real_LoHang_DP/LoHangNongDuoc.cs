using System;

namespace DPM235408_TranTuanAnh_Tuan01_Prototype_Real_LoHang_DP
{
    // Concrete Prototype
    public class LoHangNongDuoc : ILoHangPrototype
    {
        public string MaLo { get; set; }
        public string TenSanPham { get; set; }
        public string NhaCungCap { get; set; }
        public DateTime NgayHetHan { get; set; }

        public LoHangNongDuoc(string maLo, string tenSanPham, string nhaCungCap, DateTime ngayHetHan)
        {
            MaLo = maLo;
            TenSanPham = tenSanPham;
            NhaCungCap = nhaCungCap;
            NgayHetHan = ngayHetHan;
        }

        // Táº¡o báº£n sao nÃ´ng (Shallow copy)
        public ILoHangPrototype Clone()
        {
            Console.WriteLine($"[Há»‡ thá»‘ng] Äang nhÃ¢n báº£n LÃ´ hÃ ng {MaLo}...");
            return (ILoHangPrototype)this.MemberwiseClone();
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"- LÃ´: {MaLo} | SP: {TenSanPham} | NCC: {NhaCungCap} | HSD: {NgayHetHan.ToShortDateString()}");
        }
    }
}
