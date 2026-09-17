using System;
using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_Tuan02_Strategy_DP
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list?.Sort();

            return list!;
        }
    }
}
