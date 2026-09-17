using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235408_TranTuanAnh_Tuan01_Abstract_Real_BaoCao_DP
{
    // Concrete Product (Dành cho Nhân viên)
    class BaoCaoTonKhoNhanVien : IBaoCaoTonKho
    {
        public string XuatBaoCaoTonKho() => "Báo cáo tồn kho (View Nhân viên): Chỉ hiển thị số lượng tồn để tư vấn khách hàng, ẩn giá vốn.";
    }
}