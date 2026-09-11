using System;

namespace BenhVienYTe.DesignPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ VẬT TƯ Y TẾ ===");
            Console.WriteLine("Chức năng: Phân quyền truy cập báo cáo vật tư và thiết bị\n");

            string nhanVienCanKiemTra = "NV_KHO_01";

            // Kịch bản 1: Một nhân viên kho y tế bình thường cố gắng truy cập báo cáo
            Console.WriteLine("--- KỊCH BẢN 1: Nhân viên kho đăng nhập ---");
            IReportService salesProxy = new ReportAccessProxy("nguyenvana", "Staff");
            ClientCode(salesProxy, nhanVienCanKiemTra);

            // Kịch bản 2: Quản lý kho bệnh viện đăng nhập và truy cập báo cáo
            Console.WriteLine("\n--- KỊCH BẢN 2: Quản lý kho bệnh viện đăng nhập ---");
            IReportService managerProxy = new ReportAccessProxy("lethib", "Manager");
            ClientCode(managerProxy, nhanVienCanKiemTra);

            Console.ReadLine();
        }

        // Client code chỉ làm việc với Interface, không cần biết bên dưới là RealSubject hay Proxy
        static void ClientCode(IReportService reportService, string targetEmployeeId)
        {
            reportService.GenerateDiscountReport(targetEmployeeId);
        }
    }
}