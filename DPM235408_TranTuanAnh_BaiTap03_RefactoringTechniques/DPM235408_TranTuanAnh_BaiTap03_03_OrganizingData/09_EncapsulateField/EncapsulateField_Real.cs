using System;
namespace DPM235408_TranTuanAnh_BaiTap03_03_OrganizingData._09_EncapsulateField
{
    // REAL: Đóng gói trường số lượng tồn trong SoLuongTon.cs
    public class TonKho_Real
    {
        private int _soLuongTon;
        public int SoLuongTon
        {
            get => _soLuongTon;
            set => _soLuongTon = value >= 0 ? value : throw new InvalidOperationException("Tồn kho không thể âm!");
        }
    }
}
