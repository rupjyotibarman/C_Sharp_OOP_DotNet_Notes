using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Linq
{
    internal class SelectPractice
    {
        public static void SelectQues() {
            // Question 11
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Q11. Multiply every number by 10.");
            // Your Answer Here
            foreach(int num in numbers.Select(n => n * 10))
            {
                Console.Write(num + "\t");
            }

            // Question 12
            List<int> numbers2 = new List<int>() { 5, 10, 15, 20 };

            Console.WriteLine("\n\nQ12. Convert every number into its square.");
            // Your Answer Here
            foreach (int num in numbers2.Select(n => n * n))
            {
                Console.Write(num + "\t");
            }

            // Question 13
            List<string> names = new List<string>()
                {
                    "john","alice","bob"
                };

            Console.WriteLine("\n\nQ13. Convert all names to uppercase.");
            // Your Answer Here
            foreach (string nm in names.Select(n => n.ToUpper()))
            {
                Console.Write(nm + "\t");
            }

            // Question 14
            List<string> names2 = new List<string>()
                {
                    "John","Alice","Bob"
                };

            Console.WriteLine("\n\nQ14. Convert every name into its length.");
            // Your Answer Here
            foreach (int nmL in names2.Select(n => n.Length))
            {
                Console.Write(nmL + "\t");
            }



            List<Employee2> employee2 = new List<Employee2>()
            {
                new Employee2{Id=1,Name="John",Age=25,Salary=50000},
                new Employee2{Id=2,Name="Alice",Age=32,Salary=80000},
                new Employee2{Id=3,Name="Bob",Age=28,Salary=45000},
                new Employee2{Id=4,Name="David",Age=35,Salary=90000},
            };

            // Question 15
            Console.WriteLine("\n\nQ15. Select only Employee names.");
            // Use Employee list above.
            // Your Answer Here
            foreach(string nam in employee2.Select(e => e.Name))
            {
                Console.Write(nam + "\t");
            }

            // Question 16
            Console.WriteLine("\n\nQ16. Select only Employee salaries.");
            // Your Answer Here
            foreach (int sal in employee2.Select(e => e.Salary))
            {
                Console.Write(sal + "\t");
            }

            // Question 17
            Console.WriteLine("\n\nQ17. Create anonymous objects containing only Name and Salary.");
            // Your Answer Here
            var newEmp = employee2.Select(e => new { e.Name, e.Salary });
            foreach(var emp in newEmp)
            {
                Console.Write(emp.Name + "get" + emp.Salary + "\t");
            }

            // Question 19
            List<DateTime> dates = new List<DateTime>()
                {
                    new DateTime(2024,1,1),
                    new DateTime(2025,6,15),
                    new DateTime(2026,12,25)
                };

            Console.WriteLine("\n\nQ19. Select only the Year.");
            // Your Answer Here
            foreach(int yr in dates.Select(da=> da.Year))
            {
                Console.Write(yr + "\t");
            }

            // Question 20
            Dictionary<int, string> students = new Dictionary<int, string>()
                {
                    {1,"John"},
                    {2,"Alice"},
                    {3,"Bob"}
                };

            Console.WriteLine("\n\nQ20. Convert dictionary into strings like '1 - John'.");
            // Your Answer Here
            foreach(string st in students.Select(st=> (st.Key+" - " + st.Value).ToString()))
            {
                Console.Write(st  + "\t");
            }
        }
    }
    class Employee2
    {
        public int Id;
        public string Name;
        public int Age;
        public double Salary;
    }
}
