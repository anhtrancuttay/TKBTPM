using System;
namespace DPM235408_TranTuanAnh_BaiTap03_03_OrganizingData._05_ReplaceDataValueWithObject
{
    // AFTER: Thay bằng Value Object SoDienThoai
    public readonly record struct SoDienThoai(string Value)
    {
        public override string ToString() => Value;
    }
    public class KhachHang_After { public SoDienThoai DienThoai { get; set; } = new("0918123456"); }
}
