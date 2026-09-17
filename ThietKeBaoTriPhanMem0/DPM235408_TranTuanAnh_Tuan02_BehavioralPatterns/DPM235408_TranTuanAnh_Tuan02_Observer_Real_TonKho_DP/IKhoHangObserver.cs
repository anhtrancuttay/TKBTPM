namespace DPM235408_TranTuanAnh_Tuan02_Observer_Real_TonKho_DP
{
    public interface IKhoHangObserver
    {
        void CapNhat(ThongTinCanhBaoKho canhBao);
        string TenBoPhan { get; }
    }
}
