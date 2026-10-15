using System;
using System.Collections.Generic;
using System.Text;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("================================================================================");
            Console.WriteLine("   BÀI TẬP 04 - NHÓM 1: SIMPLIFYING CONDITIONAL EXPRESSIONS (8 KỸ THUẬT)");
            Console.WriteLine("   Học viên: Nguyễn Tuấn Anh - MSSV: DPM235407 - Lớp: Cao học K24");
            Console.WriteLine("   Hệ thống Quản lý Bán hàng Nông Dược An Giang");
            Console.WriteLine("================================================================================\n");

            // 1. Consolidate Conditional Expression
            Console.WriteLine(">>> 1. CONSOLIDATE CONDITIONAL EXPRESSION <<<");
            var ktThuoc = new _01_ConsolidateConditionalExpression.KiemTraLuuHanhThuocBVTV_Real();
            ktThuoc.DuocPhepXuatBan("Tilt Super 300EC", DateTime.Today.AddMonths(12), false, true);
            ktThuoc.DuocPhepXuatBan("Thuốc trừ cỏ đã bị cấm", DateTime.Today.AddMonths(-1), true, false);

            // 2. Consolidate Duplicate Conditional Fragments
            Console.WriteLine("\n>>> 2. CONSOLIDATE DUPLICATE CONDITIONAL FRAGMENTS <<<");
            var lapPhieu = new _02_ConsolidateDuplicateConditionalFragments.LapPhieuXuatKhoNongDuoc_Real();
            lapPhieu.LapPhieuXuat("XK-SI-01", true, 50000000m, 1200000m);
            lapPhieu.LapPhieuXuat("XK-LE-02", false, 3500000m, 50000m);

            // 3. Decompose Conditional
            Console.WriteLine("\n>>> 3. DECOMPOSE CONDITIONAL <<<");
            var dinhGia = new _03_DecomposeConditional.DinhGiaMuaVuNongDuoc_Real();
            DateTime ngayDongXuan = new DateTime(2026, 12, 15);
            DateTime ngayThuong = new DateTime(2026, 7, 20);
            Console.WriteLine($"   [REAL] Giá 50 bao NPK vụ Đông Xuân (15/12): {dinhGia.TinhTienPhanBon(ngayDongXuan, 50, 480000):N0} VNĐ (Có trợ giá)");
            Console.WriteLine($"   [REAL] Giá 50 bao NPK vụ Hè Thu (20/07): {dinhGia.TinhTienPhanBon(ngayThuong, 50, 480000):N0} VNĐ (Giá gốc)");

            // 4. Replace Conditional with Polymorphism
            Console.WriteLine("\n>>> 4. REPLACE CONDITIONAL WITH POLYMORPHISM <<<");
            _04_ReplaceConditionalWithPolymorphism.KhachHangNongDuoc_Real dl1 = new _04_ReplaceConditionalWithPolymorphism.DaiLyCap1_Real { MaKhachHang = "DL1-THOTNOT", TenKhachHang = "Đại lý Thốt Nốt" };
            _04_ReplaceConditionalWithPolymorphism.KhachHangNongDuoc_Real htx = new _04_ReplaceConditionalWithPolymorphism.NongDanHopTacXa_Real { MaKhachHang = "HTX-TRITON", TenKhachHang = "HTX Nông Nghiệp Tri Tôn" };
            decimal tongHang = 100000000m;
            Console.WriteLine($"   [REAL] {dl1.TenKhachHang} (Cấp 1): Chiết khấu {dl1.TinhTienChietKhau(tongHang):N0} đ | Hạn tín dụng: {dl1.HanMucTinDungNgay} ngày");
            Console.WriteLine($"   [REAL] {htx.TenKhachHang} (HTX): Chiết khấu {htx.TinhTienChietKhau(tongHang):N0} đ | Hạn tín dụng: {htx.HanMucTinDungNgay} ngày");

            // 5. Remove Control Flag
            Console.WriteLine("\n>>> 5. REMOVE CONTROL FLAG <<<");
            var kiemSoat = new _05_RemoveControlFlag.KiemSoatHoatChatCam_Real();
            var danhSachThuoc = new List<_05_RemoveControlFlag.KiemSoatHoatChatCam_Real.ThuocLuuKho>
            {
                new("Tilt Super 300EC", "Difenoconazole", "SDK-01"),
                new("Cỏ Cháy Cũ", "Paraquat", "SDK-CAM-99"),
                new("Amistar Top", "Azoxystrobin", "SDK-02")
            };
            kiemSoat.CoThuocCamLuuHanh(danhSachThuoc, out string? thuocCam);

            // 6. Replace Nested Conditional with Guard Clauses
            Console.WriteLine("\n>>> 6. REPLACE NESTED CONDITIONAL WITH GUARD CLAUSES <<<");
            var thamDinh = new _06_ReplaceNestedConditionalWithGuardClauses.ThamDinhNhapKhoNongDuoc_Real();
            thamDinh.KiemTraHopLeNhapKho("NCC-SYNGENTA", 500, 18, 1000, out string lyDo1);
            thamDinh.KiemTraHopLeNhapKho("NCC-BAYER", 1500, 12, 800, out string lyDo2);
            Console.WriteLine($"   [KIỂM TRA TỪ CHỐI] {lyDo2}");

            // 7. Introduce Null Object
            Console.WriteLine("\n>>> 7. INTRODUCE NULL OBJECT <<<");
            _07_IntroduceNullObject.IKhachHangBanLe_Real khThanhVien = new _07_IntroduceNullObject.KhachHangThanhVien_Real();
            _07_IntroduceNullObject.IKhachHangBanLe_Real khVangLai = new _07_IntroduceNullObject.KhachHangVangLai_Real();
            Console.WriteLine($"   [REAL] Khách thành viên: {khThanhVien.HoTen} | Nợ tối đa: {khThanhVien.HanMucCongNo:N0} đ");
            khThanhVien.TichDiemThuong(1500000);
            Console.WriteLine($"   [REAL] Khách vãng lai: {khVangLai.HoTen} | Nợ tối đa: {khVangLai.HanMucCongNo:N0} đ");
            khVangLai.TichDiemThuong(300000);

            // 8. Introduce Assertion
            Console.WriteLine("\n>>> 8. INTRODUCE ASSERTION <<<");
            var rbKho = new _08_IntroduceAssertion.RangBuocXuatKhoNongDuoc_Real();
            rbKho.TinhGiaSauChietKhau(soLuongTon: 200, soLuongXuat: 50, donGia: 320000m, tiLeChietKhau: 0.08);

            Console.WriteLine("\n================================================================================");
            Console.WriteLine("    HOÀN THÀNH 8/8 KỸ THUẬT SIMPLIFYING CONDITIONAL EXPRESSIONS!");
            Console.WriteLine("================================================================================");
        }
    }
}
