using System;

namespace BenhVienYTe.DesignPatterns.Proxy
{
    public interface IReportService
    {
        void GenerateDiscountReport(string targetEmployeeId);
    }
}