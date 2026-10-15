namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._03_RenameMethod
{
    // BEFORE: Tên phương thức tối nghĩa, viết tắt khó hiểu (Proc_Calc, DoIt)
    public class TinhToan_Before
    {
        public decimal Proc_Calc(decimal a, double b)
        {
            return a - (a * (decimal)b);
        }
    }
}
