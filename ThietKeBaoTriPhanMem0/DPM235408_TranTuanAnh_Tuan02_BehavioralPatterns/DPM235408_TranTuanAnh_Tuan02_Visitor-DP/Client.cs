using System.Collections.Generic;

namespace DPM235408_TranTuanAnh_Tuan02_Visitor_DP
{
    public class Client
    {
        // The client code can run visitor operations over any set of elements
        // without figuring out their concrete classes.
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var element in components)
            {
                element.Accept(visitor);
            }
        }
    }
}
