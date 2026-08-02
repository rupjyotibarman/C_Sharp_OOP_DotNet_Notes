//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MultiThreading1
//{
//    // Passing Data Safely to Thread Function - using OOP
//    class DataHolder
//    {
//        private int num;
//        public DataHolder(int number) {
//            this.num = number;
//        }

//        public void PrintSquareNumber()
//        {
//            int result = num * num;
//            Console.WriteLine($"square root of {num} is : {result}");
//        }
//    }
//    internal class MThread4
//    {
//        public static void Main(String[] args)
//        {
//            int number = 10;
//            DataHolder objDH=new DataHolder(number);
//            Thread t = new Thread(new ThreadStart(objDH.PrintSquareNumber));
//            //Thread t = new Thread(objDH.PrintSquareNumber);
//            t.Start();

//        }
//    }
//}
