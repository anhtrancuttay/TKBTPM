using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._13_ReplaceErrorCodeWithException
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Xử lý nghiệp vụ xuất kho thuốc BVTV
    // Ném ngoại lệ nghiệp vụ cụ thể thay cho việc trả về mã lỗi nguyên thủy (-1, -2, -3)

    public class KhongDuTonKhoThuocException : Exception
    {
        public KhongDuTonKhoThuocException(string tenThuoc, int yeuCau, int conLai)
            : base($"Thuốc '{tenThuoc}' không đủ tồn kho! (Yêu cầu: {yeuCau}, Tồn kho thực tế: {conLai})") { }
    }

    public class ThuocQuaHanSuDungException : Exception
    {
        public ThuocQuaHanSuDungException(string tenThuoc, DateTime hanDung)
            : base($"Lô thuốc '{tenThuoc}' đã hết hạn từ ngày {hanDung:dd/MM/yyyy}, nghiêm cấm xuất bán!") { }
    }

    public class XuatKhoNongDuoc_Real
    {
        public void XuatKhoThuoc(string tenThuoc, int soLuongXuat, int tonKhoHienTai, DateTime hanDung)
        {
            if (hanDung < DateTime.Today)
                throw new ThuocQuaHanSuDungException(tenThuoc, hanDung);

            if (soLuongXuat > tonKhoHienTai)
                throw new KhongDuTonKhoThuocException(tenThuoc, soLuongXuat, tonKhoHienTai);

            Console.WriteLine($"   [XUẤT KHO THÀNH CÔNG] Đã trừ kho {soLuongXuat} chai '{tenThuoc}'. Tồn còn: {tonKhoHienTai - soLuongXuat}");
        }
    }
}
