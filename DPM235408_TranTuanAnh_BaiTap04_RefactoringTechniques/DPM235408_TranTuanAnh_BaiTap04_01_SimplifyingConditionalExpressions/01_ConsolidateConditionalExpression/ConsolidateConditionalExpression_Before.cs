namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._01_ConsolidateConditionalExpression
{
    // BEFORE: Nhiều điều kiện rẽ nhánh rời rạc nhưng đều trả về cùng một kết quả
    public class KiemTraThuoc_Before
    {
        public double TinhTienTroCap(int hanSuDungThang, bool daBiThuHoi, bool laHangThuNghiem)
        {
            if (hanSuDungThang <= 0) return 0;
            if (daBiThuHoi) return 0;
            if (laHangThuNghiem) return 0;

            return 500000; // Mức trợ cấp thông thường
        }
    }
}
