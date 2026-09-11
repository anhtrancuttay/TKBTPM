using System;

namespace BenhVienYTe.DesignPatterns.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG THỐNG KÊ TỒN KHO VẬT TƯ Y TẾ ===");

            // 1. Khởi tạo Factory với một vài sản phẩm gốc có sẵn trong kho
            var factory = new FlyweightFactory(
                new ProductSharedState("Máy monitor bệnh nhân A1", "Thiết bị chẩn đoán", "Cái"),
                new ProductSharedState("Bộ dụng cụ phẫu thuật tiêu hao", "Dụng cụ y tế", "Hộp")
            );

            factory.ListFlyweights();

            // 2. Client ghi nhận các giao dịch xuất/nhập lô (Hàng ngàn giao dịch nhưng không tốn thêm RAM cho thông tin sản phẩm)
            AddTransactionToDatabase(factory,
                new ProductSharedState("Máy monitor bệnh nhân A1", "Thiết bị chẩn đoán", "Cái"),
                new TransactionUniqueState("LO-T10-001", new DateTime(2026, 10, 05), 500, "Nhập")
            );

            AddTransactionToDatabase(factory,
                new ProductSharedState("Máy monitor bệnh nhân A1", "Thiết bị chẩn đoán", "Cái"),
                new TransactionUniqueState("LO-T10-001", new DateTime(2026, 10, 15), 100, "Xuất")
            );

            // Ghi nhận một sản phẩm mới chưa có trong hệ thống, Factory sẽ tự cấp phát
            AddTransactionToDatabase(factory,
                new ProductSharedState("Vật tư tiêu hao X", "Dụng cụ y tế", "Hộp"),
                new TransactionUniqueState("LO-T11-099", new DateTime(2026, 11, 01), 250, "Nhập")
            );

            factory.ListFlyweights();

            Console.ReadLine();
        }

        // Helper method mô phỏng việc thêm giao dịch vào thống kê
        static void AddTransactionToDatabase(FlyweightFactory factory, ProductSharedState shared, TransactionUniqueState unique)
        {
            // Lấy Flyweight từ pool
            var flyweight = factory.GetFlyweight(shared);

            // Chuyển dữ liệu context riêng biệt vào để xử lý
            flyweight.ProcessTransaction(unique);
        }
    }
}