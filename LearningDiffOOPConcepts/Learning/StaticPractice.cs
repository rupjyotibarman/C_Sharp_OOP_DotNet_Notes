using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class StaticPracticeCreateAcc
    {
        public static int TotalUser = -1;
        public string Name { get; set; }
        public int UserId { get; set; }

        static StaticPracticeCreateAcc()
        {
            Console.WriteLine("Static CTOR Executed, \t Total User is : " + TotalUser);
            TotalUser = 0;
            Console.WriteLine("Setting Total User to : " + TotalUser);

        }

        //public StaticPracticeCreateAcc()
        //{
            
        //}
        public StaticPracticeCreateAcc(string name)
        {
            Console.Write($"Acc Created for {name}\n");
            Name = name;
            TotalUser++;
            UserId = TotalUser;
        }

        public StaticPracticeCreateAcc GetUser()
        {
            return this;
        }
    }

    internal class Test : StaticPracticeCreateAcc
    {
        int Id { get; set; }
        public Test(int id, string name): base(name)
        {
            Id = id;
        }
    }
}
