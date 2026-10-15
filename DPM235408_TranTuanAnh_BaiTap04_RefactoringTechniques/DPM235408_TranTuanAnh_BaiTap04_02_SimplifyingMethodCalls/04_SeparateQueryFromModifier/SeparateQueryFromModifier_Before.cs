using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._04_SeparateQueryFromModifier
{
    // BEFORE: Hàm vừa đọc dữ liệu (Query) vừa thực hiện thay đổi trạng thái (Modifier)
    public class BaoMat_Before
    {
        private List<string> _danhSachNguoiDung = new() { "NongDan1", "KiemKho", "Admin" };

        // Hàm vừa tìm kiếm xem có Admin không vừa kích hoạt chuông cảnh báo
        public string TimVaKichHoatBaoDong(string ten)
        {
            foreach (var user in _danhSachNguoiDung)
            {
                if (user == ten)
                {
                    KichHoatChuongBaoDong(); // Side effect!
                    return user;
                }
            }
            return string.Empty;
        }

        private void KichHoatChuongBaoDong() => System.Console.WriteLine("Hú còi cảnh báo!");
    }
}
