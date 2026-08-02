//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MultiThreading1
//{
//    // Efficient Data Passing to Thread Function in C# - Type-Safe Approach
//    internal class MThread3
//    {
//        static void Main(String[] args)
//        {
//            Thread t = new Thread(new ParameterizedThreadStart(PrintSquareNumber));
//            t.Start("hi");
//        }

//        static void PrintSquareNumber(object? obj)
//        {
//            int i =Convert.ToInt32(obj);    // ** This will give error coz the passing value in t.Start() is not fixed. to solve this issue we need to use type sage approach
//            int result = i * i;
//            Console.WriteLine($"Square root of {i} : {result}");
//        }
//    }
//}
