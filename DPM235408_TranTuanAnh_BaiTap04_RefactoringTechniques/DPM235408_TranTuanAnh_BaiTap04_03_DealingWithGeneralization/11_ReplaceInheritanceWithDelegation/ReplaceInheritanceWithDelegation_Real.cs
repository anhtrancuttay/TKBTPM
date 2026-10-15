using System;
using System.Collections.Generic;
using System.Linq;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._11_ReplaceInheritanceWithDelegation
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Quản lý xuất kho chuẩn FEFO (frmSoLuongTon.cs)
    // Thay vì kế thừa List<LoThuoc> (dễ bị gọi Clear/Remove làm sai dữ liệu), chuyển sang ủy quyền (Delegation)
    public record LoThuocFEFO(string MaLo, string TenThuoc, DateTime HanSuDung, int SoLuong);

    public class KhoThuocBaoVeThucVatFEFO_Real
    {
        // Delegation: Chứa danh sách nội bộ, không cho bên ngoài can thiệp tự do
        private readonly List<LoThuocFEFO> _danhSachLo = new();

        public void NhapLoMoi(string maLo, string tenThuoc, DateTime hsd, int soLuong)
        {
            _danhSachLo.Add(new LoThuocFEFO(maLo, tenThuoc, hsd, soLuong));
            Console.WriteLine($"   [NHẬP KHO] Lô: {maLo} ({tenThuoc}) | HSD: {hsd:dd/MM/yyyy} | SL: {soLuong}");
        }

        // Tự động phân bổ xuất lô cận hạn nhất trước (FEFO)
        public LoThuocFEFO? XuatLoUuTienTheoFEFO(string tenThuoc)
        {
            var loCanDung = _danhSachLo
                .Where(x => x.TenThuoc == tenThuoc && x.SoLuong > 0)
                .OrderBy(x => x.HanSuDung)
                .FirstOrDefault();

            if (loCanDung != null)
            {
                Console.WriteLine($"   -> [FEFO ĐÃ CHỌN] Lô cận hạn nhất: {loCanDung.MaLo} (HSD: {loCanDung.HanSuDung:dd/MM/yyyy})");
            }
            return loCanDung;
        }

        public int TongSoLuongTon(string tenThuoc) => _danhSachLo.Where(x => x.TenThuoc == tenThuoc).Sum(x => x.SoLuong);
    }
}
