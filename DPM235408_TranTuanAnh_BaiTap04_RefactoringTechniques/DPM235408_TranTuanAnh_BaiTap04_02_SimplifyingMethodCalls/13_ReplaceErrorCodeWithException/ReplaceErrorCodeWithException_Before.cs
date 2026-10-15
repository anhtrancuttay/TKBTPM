namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._13_ReplaceErrorCodeWithException
{
    // BEFORE: Trả về mã lỗi (-1, -2) khi gặp sự cố, buộc caller phải tự nhớ và kiểm tra
    public class TaiKhoan_Before
    {
        private decimal _soDu = 1000000;

        public int RutTien(decimal soTien)
        {
            if (soTien <= 0) return -1; // Lỗi: tiền không hợp lệ
            if (soTien > _soDu) return -2; // Lỗi: không đủ số dư

            _soDu -= soTien;
            return 0; // Thành công
        }
    }
}
