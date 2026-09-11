using System;

namespace BenhVienYTe.DesignPatterns.Decorator
{
    public interface IInvoice
    {
        string GetDescription();
        decimal CalculateTotal();
    }
}