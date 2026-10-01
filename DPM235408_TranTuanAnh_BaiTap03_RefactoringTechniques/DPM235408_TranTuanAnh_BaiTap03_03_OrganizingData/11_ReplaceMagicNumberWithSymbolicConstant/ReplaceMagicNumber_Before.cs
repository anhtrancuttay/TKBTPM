namespace DPM235408_TranTuanAnh_BaiTap03_03_OrganizingData._11_ReplaceMagicNumberWithSymbolicConstant
{
    // BEFORE: Số ma thuật 0.05, 15 rải rác
    public class DinhMuc_Before
    {
        public bool IsCanhBao(int ton) => ton <= 15;
        public decimal TinhVAT(decimal tien) => tien * 0.05m;
    }
}
