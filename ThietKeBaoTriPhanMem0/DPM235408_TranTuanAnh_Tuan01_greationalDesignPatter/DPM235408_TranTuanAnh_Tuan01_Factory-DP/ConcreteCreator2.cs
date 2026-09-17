using System;

namespace DPM235408_TranTuanAnh_Tuan01_Factory_DP
{
    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
