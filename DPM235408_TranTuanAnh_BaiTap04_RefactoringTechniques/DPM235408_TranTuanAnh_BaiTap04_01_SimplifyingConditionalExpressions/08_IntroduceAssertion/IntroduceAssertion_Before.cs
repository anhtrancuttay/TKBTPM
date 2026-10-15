namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._08_IntroduceAssertion
{
    // BEFORE: Dựa vào giả định ngầm định hoặc comment mà không có kiểm tra hợp lệ
    public class TinhToanKho_Before
    {
        private double _gioiHanTonKho = 1000;

        // Giả định: luongXuat luôn nhỏ hơn gioiHanTonKho và lớn hơn 0
        public double TinhDungLuongConLai(double luongXuat)
        {
            // Chỉ hy vọng luongXuat <= _gioiHanTonKho
            return _gioiHanTonKho - luongXuat;
        }
    }
}
