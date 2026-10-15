using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._04_SeparateQueryFromModifier
{
    // AFTER: Tách rời Command (Modifier - thay đổi trạng thái) và Query (đọc dữ liệu thuần túy)
    public class BaoMat_After
    {
        private List<string> _danhSachNguoiDung = new() { "NongDan1", "KiemKho", "Admin" };

        // 1. Query: Thuần đọc, không gây tác dụng phụ
        public string TimNguoiDung(string ten)
        {
            foreach (var user in _danhSachNguoiDung)
            {
                if (user == ten) return user;
            }
            return string.Empty;
        }

        // 2. Modifier (Command): Thực hiện hành động thay đổi trạng thái
        public void KichHoatChuongBaoDong()
        {
            System.Console.WriteLine("Hú còi cảnh báo!");
        }
    }
}
