using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._06_IntroduceParameterObject
{
    // AFTER: Đóng gói cụm dữ liệu thành Parameter Object
    public record BoLocBaoCao_After(DateTime TuNgay, DateTime DenNgay, string MaKho, string MaNhanVien, bool BaoGomHuy);

    public class BaoCao_After
    {
        public void InBaoCao(BoLocBaoCao_After boLoc)
        {
            Console.WriteLine($"Báo cáo từ {boLoc.TuNgay:dd/MM} đến {boLoc.DenNgay:dd/MM} tại kho {boLoc.MaKho} của NV {boLoc.MaNhanVien}");
        }
    }
}
