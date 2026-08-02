//using System;
//using System.Threading;

//class Program
//{
//    public static void Main(string[] args)
//    {
//        //Creating a new Thread
//        Thread myThread = new Thread(PrintNumbers);
//        myThread.Start();

//        //Main Thread Print as well
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine($"Main thread: {i}");
//            Thread.Sleep(2000);   // sleep for 2000ms
//        }
//    }

//    public static void PrintNumbers()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine($"Worker Thread : {i}");
//            Thread.Sleep(2000);
//        }
//    }
//}