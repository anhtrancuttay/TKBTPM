using System;
using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._05_RemoveControlFlag
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Rà soát hóa chất cấm trong kho thuốc BVTV
    // Ngay khi phát hiện hoạt chất cấm (ví dụ: Paraquat, Chlorpyrifos), dừng duyệt ngay và trả về cảnh báo
    public class KiemSoatHoatChatCam_Real
    {
        public record ThuocLuuKho(string TenThuoc, string HoatChat, string SoDangKy);

        public bool CoThuocCamLuuHanh(List<ThuocLuuKho> danhSachKho, out string? thuocViPham)
        {
            var hoatChatCam = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Paraquat",
                "Chlorpyrifos Ethyl",
                "2,4-D",
                "Endosulfan"
            };

            foreach (var thuoc in danhSachKho)
            {
                if (hoatChatCam.Contains(thuoc.HoatChat))
                {
                    thuocViPham = thuoc.TenThuoc;
                    Console.WriteLine($"   [CẢNH BÁO KHẨN] Phát hiện hoạt chất cấm '{thuoc.HoatChat}' trong sản phẩm '{thuoc.TenThuoc}'! Ngừng xuất kho ngay!");
                    return true; // Thoát ngay lập tức (Remove Control Flag)
                }
            }

            thuocViPham = null;
            Console.WriteLine("   [AN TOÀN] Toàn bộ danh mục kho không có hoạt chất cấm.");
            return false;
        }
    }
}
