using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._05_PushDownMethod
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Quy chuẩn an toàn lao động kho hóa chất (DataLayer/)
    // Đẩy phương thức kích hoạt quy trình bảo hộ đặc biệt cấp cao xuống lớp con ThuocBVTVDocCao_Real
    public abstract class QuyTrinhXuatKhoVatTu_Real
    {
        public string TenSanPham { get; set; } = string.Empty;

        public void KiemTraTemNhan()
        {
            Console.WriteLine($"   -> Kiểm tra tem nhãn hợp quy của '{TenSanPham}'.");
        }
    }

    public class ChePhamSinhHoc_Real : QuyTrinhXuatKhoVatTu_Real
    {
        // Sử dụng đồ bảo hộ lao động thông thường
    }

    public class ThuocTruSauNhomDocCao_Real : QuyTrinhXuatKhoVatTu_Real
    {
        // Push Down Method: Chỉ thuốc nhóm độc cao mới kích hoạt cảnh báo này
        public void YeuCauTrangBiBaoHoDacBiet()
        {
            Console.WriteLine($"   [CẢNH BÁO NGUY HIỂM: {TenSanPham}] Bắt buộc thủ kho trang bị mặt nạ chống độc than hoạt tính, găng tay Nitril và ủng cao su trước khi bốc dỡ!");
        }
    }
}
