namespace DPM235408_TranTuanAnh_Tuan02_Visitor_DP
{
    // The Component interface declares an `accept` method that should take the
    // base visitor interface as an argument.
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
