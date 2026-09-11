using System;

namespace BenhVienYTe.DesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ KHO VẬT TƯ VÀ THIẾT BỊ Y TẾ ===");
            Console.WriteLine("Chức năng: Quản lý vật tư y tế theo lô và thùng\n");

            // 1. Tạo các sản phẩm đơn lẻ (Leaf)
            InventoryComponent mayMonitor1 = new Product("Máy monitor bệnh nhân A1", 150000m);
            InventoryComponent mayMonitor2 = new Product("Máy monitor bệnh nhân A1", 150000m);
            InventoryComponent dungCuYTe1 = new Product("Dụng cụ y tế tiêu hao", 350000m);
            InventoryComponent dungCuYTe2 = new Product("Dụng cụ y tế tiêu hao", 350000m);

            // 2. Nhóm các sản phẩm vào các thùng vật tư nhỏ (Composite)
            InventoryComponent thungMayMonitor = new ProductBatch("Thùng máy monitor bệnh nhân (2 thiết bị)");
            thungMayMonitor.Add(mayMonitor1);
            thungMayMonitor.Add(mayMonitor2);

            InventoryComponent thungDutCuYTe = new ProductBatch("Thùng dụng cụ y tế (2 bộ)");
            thungDutCuYTe.Add(dungCuYTe1);
            thungDutCuYTe.Add(dungCuYTe2);

            // 3. Đóng gói tất cả vào một lô vật tư xuất kho (Composite cấp cao nhất)
            InventoryComponent loVatTuXuatKho = new ProductBatch("LÔ VẬT TƯ XUẤT KHO NGÀY 08/09");
            loVatTuXuatKho.Add(thungMayMonitor);
            loVatTuXuatKho.Add(thungDutCuYTe);

            // Thêm một sản phẩm lẻ phụ trợ trực tiếp vào lô mà không cần đóng thùng
            InventoryComponent vatTuTieuHao = new Product("Vật tư tiêu hao X (Lô lẻ)", 95000m);
            loVatTuXuatKho.Add(vatTuTieuHao);

            // 4. Hiển thị cấu trúc lô vật tư và tính tổng tiền
            Console.WriteLine("--- CHI TIẾT CẤU TRÚC LÔ VẬT TƯ ---");
            Console.WriteLine(loVatTuXuatKho.DisplayInfo());

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"TỔNG GIÁ TRỊ LÔ VẬT TƯ: {loVatTuXuatKho.CalculateTotalPrice():N0} VND");

            // Client cũng có thể thao tác với một thùng vật tư nhỏ một cách độc lập
            Console.WriteLine($"Tổng giá trị Thùng máy monitor: {thungMayMonitor.CalculateTotalPrice():N0} VND");

            Console.ReadLine();
        }
    }
}