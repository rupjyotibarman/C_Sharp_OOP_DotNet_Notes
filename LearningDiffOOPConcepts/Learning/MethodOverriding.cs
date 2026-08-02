using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class MethodOverriding
    {
        public virtual void Show() {
            Console.WriteLine("Showing Base Method!!");
        }

        public virtual void BaseOnly() { Console.WriteLine("Base Only Methods!!"); }
    }

    internal class DerivedClass : MethodOverriding
    {
        public override void Show()
        {
            Console.WriteLine("Showing Derived Method!!");
        }

        public void Working()
        {
            Console.WriteLine("Derived is working!!");
        }
    }

    internal class SecDerivedClass : DerivedClass
    {
        public override void Show()
        {

            Console.WriteLine("SubDerived Class!!");
        }
    }
}
