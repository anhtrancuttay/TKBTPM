using System;

namespace BenhVienYTe.DesignPatterns.Facade
{
    public class FinancialSubsystem
    {
        public string CalculateTotalRevenue(DateTime fromDate, DateTime toDate)
        {
            return $"[Tài chính] Tổng giá trị vật tư và thiết bị: 150,000,000 VND";
        }

        public string SummarizeDiscountsAndShipping()
        {
            return "[Tài chính] Chi phí vận chuyển thiết bị: 2,500,000 VND | Tổng giảm giá vật tư: 1,200,000 VND";
        }
    }
}