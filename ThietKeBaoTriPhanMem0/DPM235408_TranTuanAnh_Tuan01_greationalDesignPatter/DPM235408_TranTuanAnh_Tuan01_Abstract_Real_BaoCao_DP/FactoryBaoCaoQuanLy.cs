using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235408_TranTuanAnh_Tuan01_Abstract_Real_BaoCao_DP
{
    // Concrete Factory
    public class FactoryBaoCaoQuanLy : IBaoCaoFactory
    {
        public IBaoCaoTonKho TaoBaoCaoTonKho() => new BaoCaoTonKhoQuanLy();
        public IBaoCaoBanHang TaoBaoCaoBanHang() => new BaoCaoBanHangQuanLy();
    }
}