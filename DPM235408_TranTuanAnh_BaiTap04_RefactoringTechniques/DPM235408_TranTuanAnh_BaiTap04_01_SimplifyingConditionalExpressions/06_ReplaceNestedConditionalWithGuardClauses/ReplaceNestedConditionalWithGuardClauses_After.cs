namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._06_ReplaceNestedConditionalWithGuardClauses
{
    // AFTER: Sử dụng các mệnh đề bảo vệ (Guard Clauses) để trả về sớm, giữ luồng chính tuyến tính
    public class TinhLuong_After
    {
        public decimal TinhLuongNhanVien(bool laNghiViec, bool laTamHoan, bool laThucTap, decimal luongCoBan)
        {
            if (laNghiViec) return 0;
            if (laTamHoan) return luongCoBan * 0.5m;
            if (laThucTap) return luongCoBan * 0.7m;

            return luongCoBan * 1.1m;
        }
    }
}
