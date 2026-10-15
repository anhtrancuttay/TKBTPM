using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._09_ReplaceParameterWithExplicitMethods
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Điều phối phương tiện vận chuyển vật tư nông nghiệp
    // Thay thế tham số cờ mã phương tiện (1, 2, 3) bằng các phương thức nghiệp vụ tường minh
    public class DieuPhoiVanChuyenNongDuoc_Real
    {
        public void DieuXeTaiGiaoPhanBonDaiLy(string tenDaiLy, int soTanPhanBon)
        {
            Console.WriteLine($"   [ĐIỀU XE TẢI 5 TẤN] Giao {soTanPhanBon} tấn phân bón DAP/NPK đến kho đại lý '{tenDaiLy}'. Có tài xế và 2 phụ xe bốc vác.");
        }

        public void DieuShipperXeMayGiaoTanBoRuong(string tenNongDan, string viTriRuong, string tenThuoc)
        {
            Console.WriteLine($"   [ĐIỀU SHIPPER XE MÁY] Giao khẩn cấp thuốc đặc trị '{tenThuoc}' tận bờ ruộng ({viTriRuong}) cho anh '{tenNongDan}'.");
        }

        public void DieuGheGiaoTuyenSongCuuLong(string tenHopTacXa, string benSong, int soTanHang)
        {
            Console.WriteLine($"   [ĐIỀU GHE TẢI THỦY] Vận chuyển {soTanHang} tấn vật tư theo tuyến kênh Vĩnh Tế đến bến ghe '{benSong}' của '{tenHopTacXa}'.");
        }
    }
}
