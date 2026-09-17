using System;

namespace DPM235408_TranTuanAnh_Tuan01_Builder_DP
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
