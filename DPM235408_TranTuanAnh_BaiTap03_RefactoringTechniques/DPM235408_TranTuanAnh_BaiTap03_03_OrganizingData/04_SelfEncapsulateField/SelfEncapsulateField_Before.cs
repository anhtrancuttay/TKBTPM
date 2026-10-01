namespace DPM235408_TranTuanAnh_BaiTap03_03_OrganizingData._04_SelfEncapsulateField
{
    // BEFORE: Truy cập trực tiếp trường _donGia bên trong lớp
    public class SanPham_Before
    {
        private decimal _donGia = 100000;
        public decimal TinhTien(int sl) => _donGia * sl;
    }
}
