using System;
using System.Text;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("================================================================================");
            Console.WriteLine("   BÀI TẬP 04 - NHÓM 3: DEALING WITH GENERALIZATION (12 KỸ THUẬT)");
            Console.WriteLine("   Học viên: Nguyễn Tuấn Anh - MSSV: DPM235407 - Lớp: Cao học K24");
            Console.WriteLine("   Hệ thống Quản lý Bán hàng Nông Dược An Giang");
            Console.WriteLine("================================================================================\n");

            // 1. Pull Up Field
            Console.WriteLine(">>> 1. PULL UP FIELD <<<");
            var thuoc = new _01_PullUpField.ThuocTruSauSinhHoc_Real
            {
                MaSanPham = "TS-BIO-01",
                TenSanPham = "Thuốc trừ sâu sinh học Emamectin",
                DonViTinh = "Chai 250ml",
                DonGiaNiemYet = 185000m
            };
            thuoc.InThongTin();

            // 2. Pull Up Method
            Console.WriteLine("\n>>> 2. PULL UP METHOD <<<");
            var phieuBanLe = new _02_PullUpMethod.PhieuXuatKhoBanLe_Real
            {
                SoChungTu = "XK-BL-991",
                NgayPhatSinh = DateTime.Today,
                TongGiaTri = 4500000m
            };
            phieuBanLe.InFooterXacNhanKyTen();

            // 3. Pull Up Constructor Body
            Console.WriteLine("\n>>> 3. PULL UP CONSTRUCTOR BODY <<<");
            var phieuXuat = new _03_PullUpConstructorBody.PhieuXuatKhoNongSan_Real(
                maPhieu: "PX-AG-2026",
                ngayLap: DateTime.Today,
                nhanVienLap: "Nguyễn Tuấn Anh",
                ghiChu: "Xuất theo hợp đồng mùa vụ HTX",
                maKhachHang: "HTX-THOAI-SON",
                tongTien: 85000000m
            );
            phieuXuat.InThongTin();

            // 4. Push Down Field
            Console.WriteLine("\n>>> 4. PUSH DOWN FIELD <<<");
            var thuocDoc = new _04_PushDownField.ThuocBaoVeThucVatDocHai_Real
            {
                MaHang = "DOC-NHOM2",
                TenHang = "Thuốc trừ rầy hoạt chất Chlorpyrifos dự trữ",
                GiaBan = 220000m,
                ChiSoDocCapTinhLD50 = 350,
                VachMauCanhBao = "Màu vàng (Độc trung bình)"
            };
            thuocDoc.InThongTinAnToan();

            // 5. Push Down Method
            Console.WriteLine("\n>>> 5. PUSH DOWN METHOD <<<");
            var thuocDocCao = new _05_PushDownMethod.ThuocTruSauNhomDocCao_Real { TenSanPham = "Thuốc trừ mọt nông sản đặc trị" };
            thuocDocCao.KiemTraTemNhan();
            thuocDocCao.YeuCauTrangBiBaoHoDacBiet();

            // 6. Extract Subclass
            Console.WriteLine("\n>>> 6. EXTRACT SUBCLASS <<<");
            var dlVIP = new _06_ExtractSubclass.DaiLyCap1VIP_Real
            {
                MaDaiLy = "DL-KIMCUONG-01",
                TenDaiLy = "Đại lý Nông Dược Bảy Lúa",
                DiaChi = "Thị trấn Chợ Mới, An Giang",
                DoanhSoNam = 6200000000m
            };
            dlVIP.InChinhSachVIP();

            // 7. Extract Superclass
            Console.WriteLine("\n>>> 7. EXTRACT SUPERCLASS <<<");
            var nd = new _07_ExtractSuperclass.KhachHangNongDan_Real
            {
                MaDoiTac = "ND-TRITON-05",
                TenDoiTac = "Anh Ba Ruộng",
                SoDienThoai = "0978999888"
            };
            nd.GhiNhanPhatSinhNo(12000000m);
            nd.GhiNhanThanhToan(5000000m);
            nd.InThongTinDoiTac();

            // 8. Extract Interface
            Console.WriteLine("\n>>> 8. EXTRACT INTERFACE <<<");
            var kcs = new _08_ExtractInterface.ChuyenVienKCS_Real();
            kcs.ThamDinhLo(new _08_ExtractInterface.LoThuocTruSau_Real());
            kcs.ThamDinhLo(new _08_ExtractInterface.LoPhanBonNhapKhau_Real());

            // 9. Collapse Hierarchy
            Console.WriteLine("\n>>> 9. COLLAPSE HIERARCHY <<<");
            var thuocGop = new _09_CollapseHierarchy.ThuocBaoVeThucVat_Real
            {
                MaThuoc = "TS-RIDOMIL",
                TenThuoc = "Ridomil Gold 68WG",
                DonGia = 195000m,
                DangBaoChe = "Cốm tán trong nước (WG)"
            };
            thuocGop.InThongTinChiTiet();

            // 10. Form Template Method
            Console.WriteLine("\n>>> 10. FORM TEMPLATE METHOD <<<");
            var qtrThuoc = new _10_FormTemplateMethod.NhapKhoThuocBVTV_Real();
            qtrThuoc.ThucHienNhapKho("LO-2026-AMISTAR", "Amistar Top 325SC", 500);

            var qtrPhan = new _10_FormTemplateMethod.NhapKhoPhanBon_Real();
            qtrPhan.ThucHienNhapKho("LO-2026-URE", "Phân Đạm Hạt Đục Cà Mau", 200);

            // 11. Replace Inheritance with Delegation
            Console.WriteLine("\n>>> 11. REPLACE INHERITANCE WITH DELEGATION <<<");
            var khoFEFO = new _11_ReplaceInheritanceWithDelegation.KhoThuocBaoVeThucVatFEFO_Real();
            khoFEFO.NhapLoMoi("LO-01", "Tilt Super", DateTime.Today.AddDays(40), 100);
            khoFEFO.NhapLoMoi("LO-02", "Tilt Super", DateTime.Today.AddDays(15), 50); // Cận hạn hơn
            khoFEFO.NhapLoMoi("LO-03", "Tilt Super", DateTime.Today.AddDays(120), 200);
            khoFEFO.XuatLoUuTienTheoFEFO("Tilt Super");

            // 12. Replace Delegation with Inheritance
            Console.WriteLine("\n>>> 12. REPLACE DELEGATION WITH INHERITANCE <<<");
            var phieuBanLeNongDan = new _12_ReplaceDelegationWithInheritance.PhieuBanLeNongDuoc_Real
            {
                MaChungTu = "BL-AN-GIANG-007",
                NgayGiaoDich = DateTime.Today,
                TongTienThanhToan = 2450000m,
                TenNongDanMua = "Chú Năm Lúa",
                DiaChiNhanThuoc = "Kênh 10, Vĩnh An, Châu Thành"
            };
            phieuBanLeNongDan.InBanInChungTu();

            Console.WriteLine("\n================================================================================");
            Console.WriteLine("        HOÀN THÀNH 12/12 KỸ THUẬT DEALING WITH GENERALIZATION!");
            Console.WriteLine("================================================================================");
        }
    }
}
