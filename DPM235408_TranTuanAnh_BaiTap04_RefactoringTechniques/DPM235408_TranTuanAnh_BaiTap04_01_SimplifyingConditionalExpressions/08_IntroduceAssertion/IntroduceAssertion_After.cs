using System;
using System.Diagnostics;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._08_IntroduceAssertion
{
    // AFTER: Đưa Assertion rõ ràng vào mã để làm rõ điều kiện tiên quyết (Preconditions)
    public class TinhToanKho_After
    {
        private double _gioiHanTonKho = 1000;

        public double TinhDungLuongConLai(double luongXuat)
        {
            Debug.Assert(luongXuat >= 0, "Lượng xuất không thể âm!");
            Debug.Assert(luongXuat <= _gioiHanTonKho, "Lượng xuất không được vượt quá giới hạn kho!");

            if (luongXuat < 0 || luongXuat > _gioiHanTonKho)
                throw new ArgumentOutOfRangeException(nameof(luongXuat), "Số lượng xuất không hợp lệ!");

            return _gioiHanTonKho - luongXuat;
        }
    }
}
