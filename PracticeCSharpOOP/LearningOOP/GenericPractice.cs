using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    internal class GenericPractice : ISalary<double>
    {
        public static bool IsEqual<T,R>(T a, R b)
        {
            return a.Equals(b);
        }

        public double CalculateSalary(double baseAmount)
        {
            return 3.22;
        }
    }

    interface ISalary<T>
    {
        T CalculateSalary (T a);
    }
}
