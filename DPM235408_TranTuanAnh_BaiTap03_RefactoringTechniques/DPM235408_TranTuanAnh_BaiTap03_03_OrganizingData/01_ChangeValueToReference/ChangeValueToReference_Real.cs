using System.Collections.Generic;
namespace DPM235408_TranTuanAnh_BaiTap03_03_OrganizingData._01_ChangeValueToReference
{
    // REAL: Tham chiếu thực thể Lô Thuốc Nông Dược duy nhất trong kho
    public class LoThuocThucThe_Real
    {
        public string MaLo { get; }
        public int TonKho { get; private set; }
        public LoThuocThucThe_Real(string maLo, int ton) { MaLo = maLo; TonKho = ton; }
        public void TruKho(int sl) => TonKho -= sl;
    }
}
