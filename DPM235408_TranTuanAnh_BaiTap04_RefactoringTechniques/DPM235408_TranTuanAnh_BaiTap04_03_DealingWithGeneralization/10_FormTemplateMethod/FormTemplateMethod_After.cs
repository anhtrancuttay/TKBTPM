using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._10_FormTemplateMethod
{
    // AFTER: Tạo Template Method ở lớp cha, các lớp con chỉ ghi đè các bước cụ thể
    public abstract class BaoCao_After
    {
        // Template Method: Khung thuật toán cố định
        public void TaoBaoCao()
        {
            MoTaiLieu();
            XuatNoiDung();
            DongTaiLieu();
        }

        protected virtual void MoTaiLieu() => Console.WriteLine("Mở file tài liệu");
        protected abstract void XuatNoiDung();
        protected virtual void DongTaiLieu() => Console.WriteLine("Đóng file tài liệu");
    }

    public class BaoCaoPDF_After : BaoCao_After
    {
        protected override void XuatNoiDung() => Console.WriteLine("Xuất nội dung định dạng PDF");
    }

    public class BaoCaoExcel_After : BaoCao_After
    {
        protected override void XuatNoiDung() => Console.WriteLine("Xuất nội dung bảng tính Excel");
    }
}
