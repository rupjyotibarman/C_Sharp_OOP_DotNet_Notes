//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace MultiThreading1
//{
//    // Learning ThreadStart & ParameterizedThreadStart in Multithreading 
//    internal class MThread1
//    {
//        static void Main(String[] args)
//        {
//            Console.WriteLine("Wlcome to Multithreading Tutorial");

//            Thread thrd1 = new Thread(method1);
//            thrd1.Start(10);  // Passing parameters 

//            Thread thrd2 = new Thread(method2);
//            thrd2.Start("Everything is well");


//            // Main thread is doing some work 
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Running Main Thread");
//                Thread.Sleep(600);
//            }

//            //wait for thread one(thrd1) to complete before exit

//            thrd1.Join();
//            thrd2.Join();
//            Console.WriteLine("Thrd1, Thrd2 and Main Thread have finished");
//        }

//        static void method1(object? ob1)        // ### when we put "?" then the obj can be null also. it can accept null value, if null passed it won't give error.
//        {
//            int? count = ob1 as int?;    // ## this means if count is an "int" then it will store it or if ob1 is not compatible with int, count will be assigned null.
//                                         // ## Attempt to cast `ob1` to `int?`, resulting in `null` if the cast fails
//            Console.WriteLine("value of count: ",count.ToString());
//            if (count != null)
//            {
//                for (int i = 0; i < count; i++)
//                {
//                    Console.WriteLine("Method 1 is writing");
//                    Thread.Sleep(1000);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Null value or incompatible value passed.");
//            }
//        }
//        //static void method1(object ob1)
//        //{
//        //    int count=(int)ob1;
//        //    for (int i = 0; i < count; i++)
//        //    {
//        //        Console.WriteLine("Method 1 is writing");
//        //        Thread.Sleep(1000);
//        //    }
//        //}

//        static void method2(object ob2)
//        {
//            string msg=(string)ob2;

//            for(int i=0; i < 10; i++)
//            {
//                Console.WriteLine($"message is : {msg}");
//                Thread.Sleep(2000);
//            }
//        }
//    }
//}
