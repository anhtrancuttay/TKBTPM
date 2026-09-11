using System;

namespace BenhVienYTe.DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG LẬP HÓA ĐƠN VẬT TƯ Y TẾ ===");

            // Bước 1: Khởi tạo hóa đơn vật tư cơ bản với giá trị 5,000,000 VND
            IInvoice invoice = new BaseInvoice(5000000m);
            Console.WriteLine("\n[1] Khởi tạo hóa đơn vật tư cơ bản:");
            Console.WriteLine($"Nội dung:\n{invoice.GetDescription()}");
            Console.WriteLine($"Tổng tiền: {invoice.CalculateTotal():N0} VND");

            // Bước 2: Khoa yêu cầu giao hàng đến phòng khám (Thêm phí vận chuyển 150,000 VND)
            invoice = new ShippingFeeDecorator(invoice, 150000m);

            // Bước 3: Khoa thuê thêm dịch vụ lắp đặt và kiểm định (Thêm phí 50,000 VND)
            invoice = new AdditionalServiceDecorator(invoice, "Lắp đặt và kiểm định thiết bị", 50000m);

            // Bước 4: Bệnh viện áp dụng chiết khấu cho thiết bị ưu tiên 200,000 VND
            invoice = new DiscountDecorator(invoice, 200000m);

            Console.WriteLine("\n[2] Hóa đơn sau khi tính toán các chi phí phát sinh và chiết khấu:");
            Console.WriteLine($"Nội dung chi tiết:\n{invoice.GetDescription()}");
            Console.WriteLine($"\n=> TỔNG THANH TOÁN CUỐI CÙNG: {invoice.CalculateTotal():N0} VND");

            Console.ReadLine();
        }
    }
}