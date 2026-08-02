using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultiThreading1

{
    internal class AsyncAwait
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Practicing Async and Await");
            Console.WriteLine("-------------------------------------------------------------");

            var stopW = new Stopwatch();
            stopW.Start();

            Task.WaitAll(Method1(), Method2(), Method3()); 

            stopW.Stop();

            Console.WriteLine($"Total Execution Time: {stopW.ElapsedMilliseconds} miliseconds");   // *** Total Time taken 6021 miliseconds
        }

        static async Task Method1()
        {
            Console.WriteLine("Executing Method 1");
            await Task.Delay(5000);
        }

        static async Task Method2()
        {
            Console.WriteLine("Executing Method 2");
            await Task.Delay(3000);
        }

        static async Task Method3()
        {
            Console.WriteLine("Executing Method 3");
            await Task.Delay(6000);
        }

    }
}

//-------------------------------------------------------------****------------------------------------------------------------------------------


//{
//    internal class AsyncAwait
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Practicing Async and Await");
//            Console.WriteLine("------------------------------------");

//            var stopW = new Stopwatch();
//            stopW.Start();

//            Thread t1 = new Thread(Method1);
//            t1.Start();
//            Thread t2 = new Thread(Method2);
//            t2.Start();
//            Thread t3 = new Thread(Method3);
//            t3.Start();

//            t1.Join();
//            t2.Join();
//            t3.Join();

//            stopW.Stop();

//            Console.WriteLine($"Total Execution Time: {stopW.ElapsedMilliseconds} miliseconds");   // *** Total Time taken 6017 miliseconds
//        }

//        static void Method1()
//        {
//            Console.WriteLine("Executing Method 1");
//            Thread.Sleep(5000);
//        }

//        static void Method2()
//        {
//            Console.WriteLine("Executing Method 2");
//            Thread.Sleep(3000);
//        }

//        static void Method3()
//        {
//            Console.WriteLine("Executing Method 3");
//            Thread.Sleep(6000);
//        }

//    }
//}

//-------------------------------------------------------------****------------------------------------------------------------------------------

//{
//    internal class AsyncAwait
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Practicing Async and Await");
//            Console.WriteLine("-----------------------------------");

//            var stopW = new Stopwatch();
//            stopW.Start();

//            Method1();
//            Method2();
//            Method3();

//            stopW.Stop();

//            Console.WriteLine($"Total Execution Time: {stopW.ElapsedMilliseconds} miliseconds");   // *** Total time taken 14024 miliseconds
//        }

//        static void Method1()
//        {
//            Console.WriteLine("Executing Method 1");
//            Thread.Sleep(5000);
//        }

//        static void Method2()
//        {
//            Console.WriteLine("Executing Method 2");
//            Thread.Sleep(3000);
//        }

//        static void Method3()
//        {
//            Console.WriteLine("Executing Method 3");
//            Thread.Sleep(6000);
//        }

//    }
//}
