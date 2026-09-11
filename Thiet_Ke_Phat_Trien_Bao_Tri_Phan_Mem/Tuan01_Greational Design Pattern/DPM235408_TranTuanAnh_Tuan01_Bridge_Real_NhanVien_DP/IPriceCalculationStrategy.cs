using System;

namespace BenhVienYTe.DesignPatterns.Bridge
{
    // Giao diện (Implementor) cho các phương pháp tính giá xuất kho
    public interface IPriceCalculationStrategy
    {
        decimal CalculateBaseExportPrice(string productCode, int quantity);
    }
}