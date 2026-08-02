//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace MultiThreading1
//{
//    // Learnign Normal Multithreading without any parameter to pass 
//    internal class MThread1
//    {
//        static void Main(String[] args)
//        {
//            Console.WriteLine("Wlcome to Multithreading Tutorial");

//            Thread thrd1 = new Thread(method1);
//            thrd1.Start();

//            // Main thread is doing some work 
//            for(int i = 0; i < 10; i++) {
//                Console.WriteLine("Running Main Thread");
//                Thread.Sleep(800);
//            }

//            //wait for thread one(thrd1) to complete before exit

//            thrd1.Join();
//            Console.WriteLine("Thrd1 and Main Thread have finished");
//        }

//        static void method1()
//        {
//            for(int i = 0; i < 10; i++) {
//                Console.WriteLine("Method 1 is writing");
//                Thread.Sleep(1000);
//            }
//        }
//    }
//}
