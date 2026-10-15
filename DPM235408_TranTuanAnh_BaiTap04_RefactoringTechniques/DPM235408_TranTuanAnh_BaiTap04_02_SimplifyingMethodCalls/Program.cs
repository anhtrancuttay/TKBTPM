using System;
using System.Text;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("================================================================================");
            Console.WriteLine("   BÀI TẬP 04 - NHÓM 2: SIMPLIFYING METHOD CALLS (14 KỸ THUẬT)");
            Console.WriteLine("   Học viên: Nguyễn Tuấn Anh - MSSV: DPM235407 - Lớp: Cao học K24");
            Console.WriteLine("   Hệ thống Quản lý Bán hàng Nông Dược An Giang");
            Console.WriteLine("================================================================================\n");

            // 1. Add Parameter
            Console.WriteLine(">>> 1. ADD PARAMETER <<<");
            new _01_AddParameter.TinhHoaDonBanSiNongDuoc_Real()
                .TinhTongHoaDonBanSi(100000000m, 0.10, 0.05, 1500000m);

            // 2. Remove Parameter
            Console.WriteLine("\n>>> 2. REMOVE PARAMETER <<<");
            new _02_RemoveParameter.TieuHuyThuocHetHan_Real()
                .LapBienBanTieuHuy("LO-2023-PAR", "Thuốc cỏ đã cấm", 20, "Quá hạn sử dụng theo quy định BVTV");

            // 3. Rename Method
            Console.WriteLine("\n>>> 3. RENAME METHOD <<<");
            new _03_RenameMethod.BangGiaNongDuoc_Real()
                .LayThongTinDonGiaThuocHienHanh("TS-FILIA-525SE", laGiaBanSi: true);

            // 4. Separate Query from Modifier
            Console.WriteLine("\n>>> 4. SEPARATE QUERY FROM MODIFIER <<<");
            var kho = new _04_SeparateQueryFromModifier.QuanLyTonKhoThuoc_Real();
            bool duTon = kho.KiemTraDuTonKho(50); // Query
            Console.WriteLine($"   [QUERY] Tồn kho có đủ 50 chai? {duTon}");
            if (duTon) kho.TruSoLuongTonKho(50); // Modifier

            // 5. Parameterize Method
            Console.WriteLine("\n>>> 5. PARAMETERIZE METHOD <<<");
            var binhOn = new _05_ParameterizeMethod.BinhOnGiaNongDuoc_Real();
            binhOn.ApDungChinhSachHoTro("Phân bón Urê Cà Mau", 650000m, 0.12, "Hỗ trợ bà con ảnh hưởng lũ đầu nguồn");

            // 6. Introduce Parameter Object
            Console.WriteLine("\n>>> 6. INTRODUCE PARAMETER OBJECT <<<");
            var thongKe = new _06_IntroduceParameterObject.ThongKeDoanhThuNongDuoc_Real();
            var boLoc = new _06_IntroduceParameterObject.BoLocThongKeDoanhThu_Real
            {
                TuNgay = new DateTime(2026, 9, 1),
                DenNgay = new DateTime(2026, 9, 30),
                HuyenThi = "Tri Tôn",
                NhomHang = "Thuốc Diệt Rầy Nâu",
                ChiLayDonDaThuTien = true
            };
            thongKe.XuatBaoCaoDoanhThu(boLoc);

            // 7. Preserve Whole Object
            Console.WriteLine("\n>>> 7. PRESERVE WHOLE OBJECT <<<");
            var loThuoc = new _07_PreserveWholeObject.LoThuocBaoVeThucVat_Real();
            new _07_PreserveWholeObject.KiemDinhXuatKho_Real().KiemTraLoDatChuanXuatKho(loThuoc, 100);

            // 8. Remove Setting Method
            Console.WriteLine("\n>>> 8. REMOVE SETTING METHOD <<<");
            var phieu = new _08_RemoveSettingMethod.ChungTuBanHangNongDuoc_Real("PB-2026-009", DateTime.Today, "NV-TUANANH", 12500000m);
            phieu.XacNhanThanhToan();

            // 9. Replace Parameter with Explicit Methods
            Console.WriteLine("\n>>> 9. REPLACE PARAMETER WITH EXPLICIT METHODS <<<");
            var dieuPhoi = new _09_ReplaceParameterWithExplicitMethods.DieuPhoiVanChuyenNongDuoc_Real();
            dieuPhoi.DieuXeTaiGiaoPhanBonDaiLy("Đại lý Bảy Lúa (Chợ Mới)", 10);
            dieuPhoi.DieuShipperXeMayGiaoTanBoRuong("Chú Chín", "Cột mốc Kênh 7, Thoại Sơn", "Tilt Super");

            // 10. Replace Parameter with Method Call
            Console.WriteLine("\n>>> 10. REPLACE PARAMETER WITH METHOD CALL <<<");
            var donHangSi = new _10_ReplaceParameterWithMethodCall.DonHangBanSiNongDuoc_Real();
            donHangSi.ChiTietHangHoa.Add(("Tilt Super 300EC", 100, 240000m));
            donHangSi.ChiTietHangHoa.Add(("Anvil 5SC", 50, 145000m));
            donHangSi.TinhTienThanhToanSauChietKhau();

            // 11. Hide Method
            Console.WriteLine("\n>>> 11. HIDE METHOD <<<");
            var congNo = new _11_HideMethod.QuanLyCongNoNongDuoc_Real();
            congNo.ThuTienCongNo("KH-CHAU-PHU-01", 15000000m, "Nguyễn Tuấn Anh");

            // 12. Replace Constructor with Factory Method
            Console.WriteLine("\n>>> 12. REPLACE CONSTRUCTOR WITH FACTORY METHOD <<<");
            var dichVuDrone = _12_ReplaceConstructorWithFactoryMethod.GoiDichVuPhunThuoc_Real.TaoGoiDroneCanhDongMauLon("Cánh đồng Tri Tôn", 45.0);
            Console.WriteLine($"   [REAL] {dichVuDrone.TenDichVu} | Tổng phí: {dichVuDrone.TinhTongChiPhi():N0} đ");

            // 13. Replace Error Code with Exception
            Console.WriteLine("\n>>> 13. REPLACE ERROR CODE WITH EXCEPTION <<<");
            var xuatKho = new _13_ReplaceErrorCodeWithException.XuatKhoNongDuoc_Real();
            try
            {
                xuatKho.XuatKhoThuoc("Beam 75WP", 100, 20, DateTime.Today.AddMonths(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   [BẮT NGOẠI LỆ NGHIỆP VỤ] {ex.GetType().Name}: {ex.Message}");
            }

            // 14. Replace Exception with Test
            Console.WriteLine("\n>>> 14. REPLACE EXCEPTION WITH TEST <<<");
            var traCuu = new _14_ReplaceExceptionWithTest.TraCuuGiaNongDuoc_Real();
            traCuu.TraCuuDonGia("8935001", out string ten1);
            traCuu.TraCuuDonGia("9999999", out string ten2);

            Console.WriteLine("\n================================================================================");
            Console.WriteLine("          HOÀN THÀNH 14/14 KỸ THUẬT SIMPLIFYING METHOD CALLS!");
            Console.WriteLine("================================================================================");
        }
    }
}
