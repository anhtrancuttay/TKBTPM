using System;

namespace DPM235408_TranTuanAnh_Tuan02_State_DP
{
    public class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateB handles request1.");
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateB handles request2.");
            Console.WriteLine("ConcreteStateB wants to change the state of the context.");
            this._context.TransitionTo(new ConcreteStateA());
        }
    }
}
