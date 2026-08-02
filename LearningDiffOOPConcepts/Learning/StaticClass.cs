using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal static class StaticClass
    {
        public static string Name { get; set; }
        public static string Address { get; set; }

        static StaticClass()
        {
            Console.WriteLine("Static CTOR executed Property is being Assigned\n");
            Name = "NERIST";
            Address = "Arunachal Pradesh";
        }
    }
    //internal class Testing : StaticClass   // Can't be inheritable
    //{ 

    //}
}
