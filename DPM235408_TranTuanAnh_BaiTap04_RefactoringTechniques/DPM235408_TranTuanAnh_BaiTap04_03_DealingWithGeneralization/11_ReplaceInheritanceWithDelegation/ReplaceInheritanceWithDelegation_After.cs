using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._11_ReplaceInheritanceWithDelegation
{
    // AFTER: Thay kế thừa bằng ủy quyền (Delegation) - chứa List<string> bên trong và chỉ phơi bày API cần thiết
    public class NganXep_After
    {
        private readonly List<string> _danhSach = new();

        public void DayVao(string item) => _danhSach.Add(item);

        public string LayRa()
        {
            if (_danhSach.Count == 0) return string.Empty;
            string top = _danhSach[_danhSach.Count - 1];
            _danhSach.RemoveAt(_danhSach.Count - 1);
            return top;
        }

        public int SoLuong => _danhSach.Count;
    }
}
