namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._04_PushDownField
{
    // AFTER: Đẩy trường dữ liệu đặc thù xuống đúng lớp con thực sự sử dụng nó
    public class VatTu_After
    {
        public string Ten { get; set; } = string.Empty;
    }

    public class PhanBon_After : VatTu_After { }

    public class ThuocTruSau_After : VatTu_After
    {
        public string MauSacDocHai { get; set; } = string.Empty; // Vạch vàng (nguy hiểm), đỏ (rất độc)
    }
}
