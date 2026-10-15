using System;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._10_FormTemplateMethod
{
    // BEFORE: Hai lớp con thực hiện cùng một thuật toán gồm các bước giống nhau nhưng tự viết riêng
    public class BaoCaoPDF_Before
    {
        public void TaoBaoCao()
        {
            Console.WriteLine("Mở file tài liệu");
            Console.WriteLine("Xuất nội dung định dạng PDF");
            Console.WriteLine("Đóng file tài liệu");
        }
    }

    public class BaoCaoExcel_Before
    {
        public void TaoBaoCao()
        {
            Console.WriteLine("Mở file tài liệu");
            Console.WriteLine("Xuất nội dung bảng tính Excel");
            Console.WriteLine("Đóng file tài liệu");
        }
    }
}
