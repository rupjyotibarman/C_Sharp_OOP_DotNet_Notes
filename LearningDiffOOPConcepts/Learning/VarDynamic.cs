using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal static class VarDynamic
    {
        public static dynamic Name { get; set; }
        public static void PracticeVarDynamic()
        {
            var a = 10;
            dynamic b;
            b = "Rup";
            b = 3;
            bool c = (a == b);
            Console.WriteLine("output : " + Add("rup"));
        }

        public static  int Add(dynamic a)
        {
            return (a + 10);
        }
    }
}
