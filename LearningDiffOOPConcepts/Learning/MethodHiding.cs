using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{

    internal class MethodHiding
    {
        public void Show()
        {
            Console.WriteLine("Showing Base Class!!");
        }
    }

    internal class SubClass : MethodHiding
    {
        public new void Show()
        {
            Console.WriteLine("Showing Sub Class!!");
        }
    }
}
