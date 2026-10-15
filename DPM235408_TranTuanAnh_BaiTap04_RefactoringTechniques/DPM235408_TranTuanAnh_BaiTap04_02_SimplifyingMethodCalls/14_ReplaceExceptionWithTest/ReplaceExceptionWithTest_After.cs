using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._14_ReplaceExceptionWithTest
{
    // AFTER: Sử dụng TryGetValue hoặc ContainsKey để kiểm tra trước, không ném và bắt ngoại lệ
    public class TraCuu_After
    {
        private Dictionary<string, double> _bangGia = new();

        public double LayGia(string maHang)
        {
            if (_bangGia.TryGetValue(maHang, out double gia))
            {
                return gia;
            }
            return 0; // Giá mặc định nếu không tìm thấy
        }
    }
}
