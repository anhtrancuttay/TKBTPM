using System;

namespace DPM235408_TranTuanAnh_Tuan02_Visitor_DP
{
    // Concrete Visitors implement several versions of the same algorithm, which
    // can work with all concrete component classes.
    class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
        }
    }
}
