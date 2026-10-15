using System;
using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._05_RemoveControlFlag
{
    // AFTER: Sử dụng break hoặc return thay cho cờ hiệu
    public class TimKiem_After
    {
        public void KiemTraNguoiDung(List<string> danhSach)
        {
            foreach (var item in danhSach)
            {
                if (item == "Admin")
                {
                    Console.WriteLine("Tìm thấy quản trị viên!");
                    return; // Hoặc break để thoát vòng lặp ngay lập tức
                }
            }
        }
    }
}
