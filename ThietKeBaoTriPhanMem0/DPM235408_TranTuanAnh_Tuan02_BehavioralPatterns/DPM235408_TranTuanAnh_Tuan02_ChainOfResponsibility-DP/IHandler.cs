namespace DPM235408_TranTuanAnh_Tuan02_ChainOfResponsibility_DP
{
    // The Handler interface declares a method for building the chain of
    // handlers. It also declares a method for executing a request.
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object? Handle(object request);
    }
}
