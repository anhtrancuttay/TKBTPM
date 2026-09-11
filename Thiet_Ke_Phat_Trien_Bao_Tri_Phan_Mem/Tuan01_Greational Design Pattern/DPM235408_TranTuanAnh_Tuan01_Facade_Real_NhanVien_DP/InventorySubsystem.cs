using System;

namespace BenhVienYTe.DesignPatterns.Facade
{
    public class InventorySubsystem
    {
        public string GetInventoryData(DateTime fromDate, DateTime toDate)
        {
            return $"[Kho] Dữ liệu tồn kho vật tư y tế từ {fromDate:dd/MM/yyyy} đến {toDate:dd/MM/yyyy}";
        }

        public string CheckLowStockItems()
        {
            return "[Kho] Cảnh báo: Máy monitor bệnh nhân A1 sắp hết hạn/hết hàng";
        }
    }
}