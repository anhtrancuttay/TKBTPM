using System;
using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._05_RemoveControlFlag
{
    // BEFORE: Sử dụng cờ hiệu boolean (found) để kiểm soát việc thoát vòng lặp
    public class TimKiem_Before
    {
        public void KiemTraNguoiDung(List<string> danhSach)
        {
            bool found = false;
            for (int i = 0; i < danhSach.Count; i++)
            {
                if (!found)
                {
                    if (danhSach[i] == "Admin")
                    {
                        Console.WriteLine("Tìm thấy quản trị viên!");
                        found = true;
                    }
                }
            }
        }
    }
}
