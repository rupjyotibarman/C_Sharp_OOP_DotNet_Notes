using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal static class RefOut
    {
        public static void PracticeRefOut()
        {
            int a = 90 ;
            Console.WriteLine("value of a before passing :" + a);
            Increment(a);
            Console.WriteLine("value of a after passing & increment :" + a + "\nBoth output will be same No Change!!");
            Console.WriteLine("\nNow lets pass using Reference");
            IncrementRef(ref a);
            Console.WriteLine("value of a after passing & increment as Ref:" + a);

            //out 
            Console.WriteLine("\nNow lets Try \"out\" : ");
            bool isIncreSuccess = true ;
            Console.WriteLine("Passing Value is : " + a);
            IncrementOut(ref a, out isIncreSuccess);
            if (isIncreSuccess) Console.WriteLine("Increment Success"); else Console.WriteLine("Increment Failed");
            Console.WriteLine("Increment Value is : " + a);


        }
        public static void Increment(int a)
        {
            a++;
        }

        public static void IncrementRef(ref int a)
        {
            a++;
        }

        public static void IncrementOut(ref int a, out bool isSuccess)
        {
            isSuccess = false;
            int temp = a;
            a++;
            if(a == temp+1) isSuccess = true;
        }
    }
}
