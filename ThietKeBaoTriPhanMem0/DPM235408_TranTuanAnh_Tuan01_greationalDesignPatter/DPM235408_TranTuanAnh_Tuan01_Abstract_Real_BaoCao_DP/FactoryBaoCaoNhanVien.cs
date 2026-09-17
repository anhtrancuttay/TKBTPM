using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235408_TranTuanAnh_Tuan01_Abstract_Real_BaoCao_DP
{
    // Concrete Factory
    public class FactoryBaoCaoNhanVien : IBaoCaoFactory
    {
        public IBaoCaoTonKho TaoBaoCaoTonKho() => new BaoCaoTonKhoNhanVien();
        public IBaoCaoBanHang TaoBaoCaoBanHang() => new BaoCaoBanHangNhanVien();
    }
}
