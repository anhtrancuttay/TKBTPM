namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._09_ReplaceParameterWithExplicitMethods
{
    // BEFORE: Sử dụng tham số cờ (flag parameter) để rẽ nhánh thực thi
    public class MayIn_Before
    {
        public const int IN_DEN_TRANG = 0;
        public const int IN_MAU = 1;

        public void InAn(int cheDo)
        {
            if (cheDo == IN_DEN_TRANG)
            {
                System.Console.WriteLine("Đang in bản đen trắng...");
            }
            else if (cheDo == IN_MAU)
            {
                System.Console.WriteLine("Đang in bản màu chất lượng cao...");
            }
        }
    }
}
