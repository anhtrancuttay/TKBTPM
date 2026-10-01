namespace DPM235408_TranTuanAnh_BaiTap03_03_OrganizingData._13_ReplaceTypeCodeWithSubclasses
{
    // AFTER: Kế thừa đa hình Subclasses
    public abstract class NhanVien_After { public abstract decimal TinhLuong(); }
    public class NhanVienBanHang : NhanVien_After { public override decimal TinhLuong() => 7000000; }
    public class NhanVienQuanLy : NhanVien_After { public override decimal TinhLuong() => 15000000; }
}
