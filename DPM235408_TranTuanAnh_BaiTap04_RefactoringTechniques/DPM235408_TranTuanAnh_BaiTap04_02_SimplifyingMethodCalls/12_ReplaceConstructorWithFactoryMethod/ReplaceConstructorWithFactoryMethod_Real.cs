using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._12_ReplaceConstructorWithFactoryMethod
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Dịch vụ kỹ thuật phun thuốc BVTV
    // Thay thế constructor bằng Static Factory Methods cho từng gói dịch vụ: Drone vs Truyền thống
    public class GoiDichVuPhunThuoc_Real
    {
        public string TenDichVu { get; }
        public string DiaDiemTrienKhai { get; }
        public double DienTichHecta { get; }
        public decimal DonGiaTrenHecta { get; }
        public bool SuDungMayBayDrone { get; }

        private GoiDichVuPhunThuoc_Real(string tenDichVu, string diaDiem, double dienTich, decimal donGia, bool suDungDrone)
        {
            TenDichVu = tenDichVu;
            DiaDiemTrienKhai = diaDiem;
            DienTichHecta = dienTich;
            DonGiaTrenHecta = donGia;
            SuDungMayBayDrone = suDungDrone;
        }

        // Factory Method 1: Dịch vụ bay Drone cánh đồng mẫu lớn (Tri Tôn, Thoại Sơn)
        public static GoiDichVuPhunThuoc_Real TaoGoiDroneCanhDongMauLon(string diaDiem, double soHecta)
        {
            return new GoiDichVuPhunThuoc_Real(
                tenDichVu: "Dịch vụ Drone bay phun thuốc dập dịch rầy nâu",
                diaDiem: diaDiem,
                dienTich: soHecta,
                donGia: 180000m, // 180.000 đ/ha
                suDungDrone: true
            );
        }

        // Factory Method 2: Dịch vụ phun bình xịt truyền thống cho ruộng vườn nhỏ lẻ
        public static GoiDichVuPhunThuoc_Real TaoGoiPhunBinhTruyenThong(string diaDiem, double soCongDat)
        {
            double quyDoiHecta = soCongDat / 10.0; // 10 công = 1 ha
            return new GoiDichVuPhunThuoc_Real(
                tenDichVu: "Dịch vụ phun bình xịt động cơ xăng hộ cá thể",
                diaDiem: diaDiem,
                dienTich: quyDoiHecta,
                donGia: 300000m,
                suDungDrone: false
            );
        }

        public decimal TinhTongChiPhi() => (decimal)DienTichHecta * DonGiaTrenHecta;
    }
}
