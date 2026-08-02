//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MultiThreading1
//{
//    // Passing Data Safely to Thread Function - using Async/await
//    internal class MThread5
//    {
//        public static void Main(String[] args)
//        {
//            int number = 10;
//            Thread t1 = new Thread(() => MThread5.PrintSquareNumber(number));
//            //Thread t = new Thread(objDH.PrintSquareNumber);
//            t1.Start();

//        }

//        public static void PrintSquareNumber(int num)
//        {
//            Console.WriteLine($"Square of {num} is : {num * num}");
//        }
//    }
//}
