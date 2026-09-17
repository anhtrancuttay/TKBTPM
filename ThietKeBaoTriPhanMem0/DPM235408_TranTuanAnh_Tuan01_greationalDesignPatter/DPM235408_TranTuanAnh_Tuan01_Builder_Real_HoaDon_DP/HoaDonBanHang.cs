using System;
using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_Tuan01_Builder_Real_HoaDon_DP
{
    // Product: HÃ³a Ä‘Æ¡n
    public class HoaDonBanHang
    {
        private List<string> _thanhPhan = new List<string>();

        public void Add(string phan)
        {
            _thanhPhan.Add(phan);
        }

        public string HienThiHoaDon()
        {
            string str = "Chi tiáº¿t hÃ³a Ä‘Æ¡n:\n";
            foreach (var item in _thanhPhan)
            {
                str += " - " + item + "\n";
            }
            return str;
        }
    }
}
