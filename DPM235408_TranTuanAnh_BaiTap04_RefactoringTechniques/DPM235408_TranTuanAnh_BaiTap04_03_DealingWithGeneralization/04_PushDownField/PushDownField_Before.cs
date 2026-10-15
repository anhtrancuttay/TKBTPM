namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._04_PushDownField
{
    // BEFORE: Lớp cha khai báo trường MauSacDocHai nhưng chỉ một lớp con dùng đến
    public class VatTu_Before
    {
        public string Ten { get; set; } = string.Empty;
        public string MauSacDocHai { get; set; } = string.Empty; // Phân bón không có độ độc hại này
    }

    public class PhanBon_Before : VatTu_Before { }
    public class ThuocTruSau_Before : VatTu_Before { }
}
