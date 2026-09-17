namespace DPM235408_TranTuanAnh_Tuan02_Iterator_Real_KhoHang_DP
{
    // Interface Iterator duyệt lô hàng
    public interface IKhoHangIterator
    {
        bool HasNext();
        LoHangNongDuoc? Next();
        LoHangNongDuoc? CurrentItem();
        void Reset();
    }
}
