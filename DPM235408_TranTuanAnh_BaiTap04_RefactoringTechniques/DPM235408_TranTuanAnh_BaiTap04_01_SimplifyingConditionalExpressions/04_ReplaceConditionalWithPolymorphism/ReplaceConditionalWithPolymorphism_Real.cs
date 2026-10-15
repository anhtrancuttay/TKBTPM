using System;

namespace DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions._04_ReplaceConditionalWithPolymorphism
{
    // REAL: Nghiệp vụ Nông Dược An Giang - Phân loại đối tác khách hàng và tính chiết khấu
    public abstract class KhachHangNongDuoc_Real
    {
        public string MaKhachHang { get; set; } = string.Empty;
        public string TenKhachHang { get; set; } = string.Empty;

        // Phương thức đa hình thay thế cho switch(loaiKhach)
        public abstract decimal TinhTienChietKhau(decimal tongTienHang);
        public abstract int HanMucTinDungNgay { get; }
    }

    // 1. Đại lý cấp 1: Nhập số lượng container, chiết khấu 12%, công nợ 60 ngày
    public class DaiLyCap1_Real : KhachHangNongDuoc_Real
    {
        public override decimal TinhTienChietKhau(decimal tongTienHang) => tongTienHang * 0.12m;
        public override int HanMucTinDungNgay => 60;
    }

    // 2. Đại lý cấp 2: Phân phối xã/huyện, chiết khấu 7%, công nợ 30 ngày
    public class DaiLyCap2_Real : KhachHangNongDuoc_Real
    {
        public override decimal TinhTienChietKhau(decimal tongTienHang) => tongTienHang * 0.07m;
        public override int HanMucTinDungNgay => 30;
    }

    // 3. Nông dân liên kết / Hợp tác xã: Chiết khấu hỗ trợ mùa vụ 4%, thanh toán cuối vụ (90 ngày)
    public class NongDanHopTacXa_Real : KhachHangNongDuoc_Real
    {
        public override decimal TinhTienChietKhau(decimal tongTienHang) => tongTienHang * 0.04m;
        public override int HanMucTinDungNgay => 90;
    }
}
