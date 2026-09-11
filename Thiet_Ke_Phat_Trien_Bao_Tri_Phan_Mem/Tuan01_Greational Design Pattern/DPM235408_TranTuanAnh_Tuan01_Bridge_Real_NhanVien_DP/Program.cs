using System;

namespace BenhVienYTe.DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ VẬT TƯ Y TẾ ===");

            string maVatTuYTe = "VT-BENHVIEN-01";
            int soLuong = 100;

            // --- TRƯỜNG HỢP 1: Cấp phát bệnh viện + Phương pháp Nhập trước Xuất trước ---
            IPriceCalculationStrategy fifoStrategy = new FifoPriceCalculator();
            SalesOrder wholesaleOrder = new WholesaleOrder(fifoStrategy);
            wholesaleOrder.ProcessOrder(maVatTuYTe, soLuong);

            // --- TRƯỜNG HỢP 2: Cấp phát bệnh viện + Phương pháp Bình quân gia quyền ---
            IPriceCalculationStrategy averageStrategy = new WeightedAveragePriceCalculator();
            // Đổi phương pháp tính giá (thay cầu nối) ngay lúc runtime mà không cần tạo class mới
            wholesaleOrder.SetPriceCalculator(averageStrategy);
            wholesaleOrder.ProcessOrder(maVatTuYTe, soLuong);

            // --- TRƯỜNG HỢP 3: Cấp phát trực tiếp + Phương pháp Bình quân gia quyền ---
            SalesOrder retailOrder = new RetailOrder(averageStrategy);
            retailOrder.ProcessOrder(maVatTuYTe, 5); // Cấp phát trực tiếp số lượng ít

            Console.ReadLine();
        }
    }
}