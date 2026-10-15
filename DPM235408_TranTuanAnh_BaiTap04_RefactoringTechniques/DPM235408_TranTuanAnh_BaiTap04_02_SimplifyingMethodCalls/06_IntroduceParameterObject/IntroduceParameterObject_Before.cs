using System;

namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._06_IntroduceParameterObject
{
    // BEFORE: Danh sách tham số quá dài (Data Clump) gồm các thông tin dải ngày và tiêu chí lọc
    public class BaoCao_Before
    {
        public void InBaoCao(DateTime tuNgay, DateTime denNgay, string maKho, string maNhanVien, bool baoGomHuy)
        {
            Console.WriteLine($"Báo cáo từ {tuNgay:dd/MM} đến {denNgay:dd/MM} tại kho {maKho} của NV {maNhanVien}");
        }
    }
}
