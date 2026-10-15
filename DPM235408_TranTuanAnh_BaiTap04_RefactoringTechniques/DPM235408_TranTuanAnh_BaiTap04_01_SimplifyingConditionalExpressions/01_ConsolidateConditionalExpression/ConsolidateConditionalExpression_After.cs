namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._01_ConsolidateConditionalExpression
{
    // AFTER: Gộp các điều kiện lại thành một biểu thức duy nhất và tách hàm rõ nghĩa
    public class KiemTraThuoc_After
    {
        public double TinhTienTroCap(int hanSuDungThang, bool daBiThuHoi, bool laHangThuNghiem)
        {
            if (KhongDuDieuKienTroCap(hanSuDungThang, daBiThuHoi, laHangThuNghiem))
                return 0;

            return 500000;
        }

        private bool KhongDuDieuKienTroCap(int hsd, bool thuHoi, bool thuNghiem)
        {
            return (hsd <= 0) || thuHoi || thuNghiem;
        }
    }
}
