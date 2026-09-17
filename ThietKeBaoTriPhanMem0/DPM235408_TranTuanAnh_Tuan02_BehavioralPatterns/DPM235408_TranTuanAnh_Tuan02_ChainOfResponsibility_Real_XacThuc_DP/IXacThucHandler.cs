namespace DPM235408_TranTuanAnh_Tuan02_ChainOfResponsibility_Real_XacThuc_DP
{
    // Interface khai báo bước xử lý xác thực
    public interface IXacThucHandler
    {
        IXacThucHandler SetNext(IXacThucHandler handler);
        bool XuLy(YeuCauTruyCap yeuCau);
    }
}
