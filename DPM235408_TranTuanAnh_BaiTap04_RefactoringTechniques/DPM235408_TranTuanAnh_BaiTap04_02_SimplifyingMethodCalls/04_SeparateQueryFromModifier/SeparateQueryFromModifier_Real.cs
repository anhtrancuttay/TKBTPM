using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._04_SeparateQueryFromModifier
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Quản lý tồn kho FEFO (frmSoLuongTon.cs)
    // Tách phương thức kiểm tra số lượng tồn (Query) khỏi thao tác trừ tồn kho thực tế (Modifier)
    public class QuanLyTonKhoThuoc_Real
    {
        public string MaLo { get; set; } = "LO-TILTSUPER-2026";
        public int SoLuongTon { get; private set; } = 150;

        // 1. QUERY: Kiểm tra khả năng cung ứng (không làm thay đổi số lượng tồn)
        public bool KiemTraDuTonKho(int soLuongYeuCau)
        {
            return SoLuongTon >= soLuongYeuCau;
        }

        // 2. MODIFIER: Trừ tồn kho khi đơn hàng đã được kế toán thanh toán thành công
        public void TruSoLuongTonKho(int soLuongXuat)
        {
            if (soLuongXuat > SoLuongTon)
                throw new InvalidOperationException("Không thể trừ quá số lượng tồn kho thực tế!");

            SoLuongTon -= soLuongXuat;
            Console.WriteLine($"   -> [KHO HÀNG] Đã xuất {soLuongXuat} chai của lô {MaLo}. Tồn kho khả dụng hiện tại: {SoLuongTon}");
        }
    }
}
