using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._10_FormTemplateMethod
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Quy chuẩn nhập kho vật tư (frmNhapHang.cs)
    // Áp dụng Form Template Method định nghĩa khung 4 bước nghiêm ngặt khi nhập kho nông dược
    public abstract class QuyTrinhNhapKhoTemplate_Real
    {
        // Template Method: Cố định thứ tự thực thi
        public void ThucHienNhapKho(string maLo, string tenHang, int soLuong)
        {
            Console.WriteLine($"\n   === BẮT ĐẦU QUY TRÌNH NHẬP KHO: {tenHang} (Lô: {maLo}) ===");
            TiepNhanVaDoiChieuHoaDon(maLo, soLuong);
            XetNghiemMauChatLuongDacThu();
            KiemTraKhuVucLuuTruKho();
            DanTemQRDongBoTheKho(maLo);
            Console.WriteLine($"   === HOÀN TẤT NHẬP KHO THÀNH CÔNG ===");
        }

        private void TiepNhanVaDoiChieuHoaDon(string maLo, int soLuong)
        {
            Console.WriteLine($"   Bước 1: Đối chiếu số lượng {soLuong} với phiếu xuất xưởng nhà máy.");
        }

        // Bước đặc thù do từng lớp con ghi đè
        protected abstract void XetNghiemMauChatLuongDacThu();
        protected abstract void KiemTraKhuVucLuuTruKho();

        private void DanTemQRDongBoTheKho(string maLo)
        {
            Console.WriteLine($"   Bước 4: In mã QR quản lý FEFO và kích hoạt định vị vị trí kệ kho.");
        }
    }

    public class NhapKhoThuocBVTV_Real : QuyTrinhNhapKhoTemplate_Real
    {
        protected override void XetNghiemMauChatLuongDacThu()
        {
            Console.WriteLine("   Bước 2: [KCS THUỐC BVTV] Đo phổ sắc ký HPLC kiểm tra nồng độ hoạt chất.");
        }

        protected override void KiemTraKhuVucLuuTruKho()
        {
            Console.WriteLine("   Bước 3: Xếp vào kho kín chuyên dụng có hệ thống quạt thông gió chống cháy nổ.");
        }
    }

    public class NhapKhoPhanBon_Real : QuyTrinhNhapKhoTemplate_Real
    {
        protected override void XetNghiemMauChatLuongDacThu()
        {
            Console.WriteLine("   Bước 2: [KCS PHÂN BÓN] Đo độ ẩm và hàm lượng hạt đạm NPK tổng hợp.");
        }

        protected override void KiemTraKhuVucLuuTruKho()
        {
            Console.WriteLine("   Bước 3: Đặt lên pallet gỗ cách mặt sàn 20cm chống ẩm mốc.");
        }
    }
}
