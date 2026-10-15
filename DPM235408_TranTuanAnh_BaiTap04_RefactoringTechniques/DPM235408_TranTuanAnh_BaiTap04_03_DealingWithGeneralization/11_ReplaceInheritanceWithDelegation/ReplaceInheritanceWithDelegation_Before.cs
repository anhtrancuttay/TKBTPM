using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization._11_ReplaceInheritanceWithDelegation
{
    // BEFORE: Kế thừa lớp List<T> làm lộ ra toàn bộ phương thức Clear, RemoveAt,... phá vỡ tính bao đóng
    public class NganXep_Before : List<string>
    {
        public void DayVao(string item) => Add(item);
        public string LayRa()
        {
            if (Count == 0) return string.Empty;
            string top = this[Count - 1];
            RemoveAt(Count - 1);
            return top;
        }
    }
}
