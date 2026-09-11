using System;

namespace BenhVienYTe.DesignPatterns.Adapter
{
    class ExternalLogisticsService
    {
        public float FetchFreightCharge(int trackingNumber, float distance)
        {
            Console.WriteLine("  [ExternalLogisticsService] Đang kết nối API đối tác vận chuyển...");
            // Giả lập logic tính phí cước: 5500 VND / 1 km
            return distance * 5500.0f;
        }
    }
}