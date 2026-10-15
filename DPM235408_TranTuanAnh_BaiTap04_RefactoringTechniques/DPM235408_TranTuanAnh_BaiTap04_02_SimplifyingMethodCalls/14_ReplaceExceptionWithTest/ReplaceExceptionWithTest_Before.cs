using System;
using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._14_ReplaceExceptionWithTest
{
    // BEFORE: Lạm dụng try-catch để kiểm soát luồng bình thường thay vì kiểm tra điều kiện
    public class TraCuu_Before
    {
        private Dictionary<string, double> _bangGia = new();

        public double LayGia(string maHang)
        {
            try
            {
                // Nếu không có, Dictionary sẽ ném KeyNotFoundException
                return _bangGia[maHang];
            }
            catch (KeyNotFoundException)
            {
                return 0; // Giá mặc định nếu không tìm thấy
            }
        }
    }
}
