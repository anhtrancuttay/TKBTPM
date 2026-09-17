using System.Collections;

namespace DPM235408_TranTuanAnh_Tuan02_Iterator_DP
{
    public abstract class IteratorAggregate : IEnumerable
    {
        // Returns an Iterator or another IteratorAggregate for the
        // implementing object.
        public abstract IEnumerator GetEnumerator();
    }
}
