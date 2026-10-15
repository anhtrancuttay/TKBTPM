namespace DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls._05_ParameterizeMethod
{
    // AFTER: Gộp thành một phương thức duy nhất với tham số tỷ lệ phần trăm
    public class TangGia_After
    {
        public decimal DieuChinhGia(decimal giaHienTai, double phanTramThayDoi)
        {
            return giaHienTai * (1 + (decimal)phanTramThayDoi);
        }
    }
}
