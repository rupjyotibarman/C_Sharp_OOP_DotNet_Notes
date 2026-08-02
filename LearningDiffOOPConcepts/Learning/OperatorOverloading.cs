using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class OperatorOverloading
    {
        int _total;
        int _interest;
        public int Total { get { return _total; } set { _total = value; } }
        public int Interest { get { return _interest; } set { _interest = value; } }

        public OperatorOverloading(int total, int inter)
        {
            Total = total;
            Interest = inter;
        }

        public static OperatorOverloading operator +(OperatorOverloading ob1, OperatorOverloading ob2)
        {
            return new OperatorOverloading(ob1.Total+ ob2.Total, ob1.Interest + ob2.Interest);
        }
    }
}
