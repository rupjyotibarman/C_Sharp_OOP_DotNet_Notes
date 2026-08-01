using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Linq
{
    internal class WhereSelect
    {
        public static void WhSel()
        {
            List<Employee3> empls = new List<Employee3>()
                {
                    new Employee3{Id=1,Name="John",Age=25,Salary=50000},
                    new Employee3{Id=2,Name="Alice",Age=32,Salary=80000},
                    new Employee3{Id=3,Name="Bob",Age=28,Salary=45000},
                    new Employee3{Id=4,Name="David",Age=35,Salary=90000},
                };

            // Question 21
            Console.WriteLine("Q21. Print names of employees whose Age > 30.");
            // Your Answer Here
            foreach (var nm in empls.Where(e => e.Age > 30).Select(e => e.Name))
            {
                Console.Write(nm + "\t");
            }

            // Question 22
            Console.WriteLine("\n\nQ22. Print salaries of employees earning more than 50000.");
            // Your Answer Here
            foreach (var sal in empls.Where(e => e.Salary > 50000).Select(e => e.Salary))
            {
                Console.Write(sal + "\t");
            }

            // Question 23
            Console.WriteLine("\n\nQ23. Print uppercase names of employees whose salary > 50000.");
            // Your Answer Here
            // Question 24
            Console.WriteLine("\n\nQ24. Print lengths of names starting with J.");
            // Use the names list above.
            // Your Answer Here
            // Question 25
            Console.WriteLine("\n\nQ25. Print square of numbers greater than 5.");
            // Use numbers1 list.
            // Your Answer Here
            // Question 26
            Console.WriteLine("\n\nQ26. Print employee names whose salary is between 50000 and 85000.");
            // Your Answer Here
            // Question 27
            List<string> cities = new List<string>()
                {
                    "Delhi","Mumbai","London","Paris","Dubai","Doha"
                };

            Console.WriteLine("\n\nQ27. Print first letter of city names having length greater than equal to 6.");
            // Use cities list.
            // Your Answer Here
            foreach (string s in cities.Where(c=> c.Length>=6).Select(c=>c.Substring(0,1).ToLower())) { 
                Console.Write(s + "\t");
            }

            // Question 28
            Console.WriteLine("\n\nQ28. Print Name and Age (anonymous object) for employees older than 28.");
            // Your Answer Here
            foreach (var emp in empls.Where(e=>e.Age>28).Select(e=> new {e.Name, e.Age })) { 
                Console.Write(emp.Name + "is " + emp.Age + "years old \t");
            }
        }
    }

    class Employee3
    {
        public int Id;
        public string Name;
        public int Age;
        public double Salary;
    }
}
