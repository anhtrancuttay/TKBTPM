namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._06_ReplaceNestedConditionalWithGuardClauses
{
    // BEFORE: Lồng ghép if-else nhiều tầng (Pyramid of Doom / Arrow Anti-pattern)
    public class TinhLuong_Before
    {
        public decimal TinhLuongNhanVien(bool laNghiViec, bool laTamHoan, bool laThucTap, decimal luongCoBan)
        {
            decimal ketQua;
            if (laNghiViec)
            {
                ketQua = 0;
            }
            else
            {
                if (laTamHoan)
                {
                    ketQua = luongCoBan * 0.5m;
                }
                else
                {
                    if (laThucTap)
                    {
                        ketQua = luongCoBan * 0.7m;
                    }
                    else
                    {
                        ketQua = luongCoBan * 1.1m; // Nhân viên chính thức
                    }
                }
            }
            return ketQua;
        }
    }
}
