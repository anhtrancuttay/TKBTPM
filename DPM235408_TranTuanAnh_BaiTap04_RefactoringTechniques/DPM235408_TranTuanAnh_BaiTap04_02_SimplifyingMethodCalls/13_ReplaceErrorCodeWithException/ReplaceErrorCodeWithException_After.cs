using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._13_ReplaceErrorCodeWithException
{
    // AFTER: Ném ngoại lệ mang tính ngữ nghĩa rõ ràng thay vì trả về mã lỗi nguyên thủy
    public class KhongDuSoDuException : Exception
    {
        public KhongDuSoDuException(string message) : base(message) { }
    }

    public class TaiKhoan_After
    {
        private decimal _soDu = 1000000;

        public void RutTien(decimal soTien)
        {
            if (soTien <= 0)
                throw new ArgumentException("Số tiền rút phải lớn hơn 0");

            if (soTien > _soDu)
                throw new KhongDuSoDuException($"Số dư hiện tại ({_soDu:N0} đ) không đủ để rút {soTien:N0} đ!");

            _soDu -= soTien;
        }
    }
}
