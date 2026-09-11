using System;

namespace BenhVienYTe.DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ VẬT TƯ VÀ THIẾT BỊ Y TẾ BỆNH VIỆN ===");
            Console.WriteLine("Chức năng: Lập phiếu cấp phát và tính chi phí vận chuyển thiết bị y tế\n");

            // 1. Hệ thống cấp phát khởi tạo dịch vụ của bên thứ 3 (Adaptee)
            ExternalLogisticsService thirdPartyService = new ExternalLogisticsService();

            // 2. Bọc Adaptee vào bên trong Adapter để tương thích với hệ thống
            IShippingFeeCalculator shippingCalculator = new ShippingFeeAdapter(thirdPartyService);

            // 3. Quá trình lập phiếu cấp phát
            string maHoaDon = "CPYTE-001";
            double khoangCachGiaoHang = 45.5; // km

            Console.WriteLine($"Đang lập phiếu cấp phát: {maHoaDon}");
            Console.WriteLine($"Khoảng cách vận chuyển: {khoangCachGiaoHang} km");

            // Client gọi tính phí một cách dễ dàng thông qua interface chuẩn
            decimal shippingCost = shippingCalculator.CalculateShipping(maHoaDon, khoangCachGiaoHang);

            Console.WriteLine($"\n=> Chi phí vận chuyển phát sinh cần cộng vào phiếu cấp phát: {shippingCost:N0} VND");
            Console.WriteLine("Hoàn tất lập phiếu cấp phát!");
            Console.ReadLine();
        }
    }
}