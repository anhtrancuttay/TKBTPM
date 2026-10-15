using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._03_RenameMethod
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Chuẩn hóa tên hàm trong DataService / ThamSo (Cuahang_Nongduoc)
    // Đổi tên các hàm viết tắt cổ điển: Lay_DL() -> LayThongTinDonGiaThuocHienHanh()
    public class BangGiaNongDuoc_Real
    {
        // Tên phương thức chuẩn Clean Code, thể hiện trọn vẹn nghiệp vụ
        public decimal LayThongTinDonGiaThuocHienHanh(string maThuoc, bool laGiaBanSi)
        {
            decimal giaCoSo = maThuoc.StartsWith("TS") ? 250000m : 180000m;
            decimal giaApDung = laGiaBanSi ? (giaCoSo * 0.90m) : giaCoSo;

            Console.WriteLine($"   [BÁO GIÁ] Mã thuốc: {maThuoc} | Loại giá: {(laGiaBanSi ? "Bán sỉ" : "Bán lẻ")} | Đơn giá: {giaApDung:N0} đ");
            return giaApDung;
        }
    }
}
