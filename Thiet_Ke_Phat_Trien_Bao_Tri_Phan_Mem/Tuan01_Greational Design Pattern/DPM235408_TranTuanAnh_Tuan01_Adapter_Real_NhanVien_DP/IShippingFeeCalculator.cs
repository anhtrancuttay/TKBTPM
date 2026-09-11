using System;

namespace BenhVienYTe.DesignPatterns.Adapter
{
    public interface IShippingFeeCalculator
    {
        decimal CalculateShipping(string invoiceId, double distanceInKm);
    }
}