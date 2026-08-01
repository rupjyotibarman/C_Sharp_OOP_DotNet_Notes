using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Linq
{
    internal class Sort
    {
        public static void SortQ()
        {
            List<Employee4> employees = new List<Employee4>()
            {
                new Employee4{Id=1, Name="John",  Age=30, Salary=50000, Department="IT"},
                new Employee4{Id=2, Name="Alice", Age=25, Salary=80000, Department="HR"},
                new Employee4{Id=3, Name="Bob",   Age=30, Salary=45000, Department="IT"},
                new Employee4{Id=4, Name="David", Age=35, Salary=90000, Department="Finance"},
                new Employee4{Id=5, Name="Emma",  Age=25, Salary=75000, Department="HR"},
                new Employee4{Id=6, Name="Chris", Age=35, Salary=60000, Department="IT"}
            };

            //Question 1
            List<int> numbers = new List<int>()
                {
                    8, 3, 10, 1, 6, 2
                };
            Console.WriteLine("Q1. Print numbers in ascending order.");
            foreach(int n in numbers.OrderByDescending(x => x))
            {
                Console.Write(n + "\t");
            }

            //Question 2 
            List<string> names = new List<string>()
                {
                    "John",
                    "Alice",
                    "David",
                    "Bob",
                    "Emma"
                };
            Console.WriteLine("\n\nQ2. Print names in alphabetical order.");
            foreach (string n in names.OrderBy(x => x))
            {
                Console.Write(n + "\t");
            }

            //Ques: 3
            Console.WriteLine("\n\nQ3. Sort employees by Age in ascending order.");
            foreach (var emp in employees.OrderBy(x => x.Age))
            {
                Console.Write(emp.Age + "\t");
            }


            //Ques : 4
            Console.WriteLine("\n\nQ4. Sort employees by Salary in descending order.");
            foreach (var emp in employees.OrderByDescending(x => x.Salary))
            {
                Console.Write(emp.Salary + "\t");
            }

            //Ques : 5
            Console.WriteLine("\n\nQ5. Sort employees by Department (A-Z). If Department is the same, sort by Name (A-Z).");
            foreach (var emp in employees.OrderBy(x => x.Department).ThenBy(x=>x.Name))
            {
                Console.WriteLine(emp.Name +" is from Department "+ emp.Department);
            }

            //Ques : 6
            Console.WriteLine("\n\nQ6. Sort employees by Age (ascending). If Age is the same, sort by Salary (descending).");
            foreach (var emp in employees.OrderBy(x => x.Age).ThenByDescending(x => x.Salary))
            {
                Console.WriteLine(emp.Name + " is from Department " + emp.Department + " age is " + emp.Age + " and Salary : " + emp.Salary);
            }


            //Ques : 7
            Console.WriteLine("\n\nQ7. Sort employees by Salary (highest first). If Salary is the same, sort by Name in descending order.");
            foreach (var emp in employees.OrderByDescending(x => x.Salary).ThenByDescending(x => x.Name))
            {
                Console.WriteLine(emp.Name + " is from Department " + emp.Department + " age is " + emp.Age + " and Salary : " + emp.Salary);
            }

            //Ques : 8
            Console.WriteLine("\n\nQ8. Sort employees by Department (A-Z), then Age (descending), then Name (A-Z).");
            foreach (var emp in employees.OrderBy(x => x.Department).ThenByDescending(x => x.Age).ThenBy(x=>x.Name))
            {
                Console.WriteLine(emp.Name + " is from Department " + emp.Department + " age is " + emp.Age + " and Salary : " + emp.Salary);
            }

            //Ques : 9
            Console.WriteLine("\n\nQ9. Find out 2nd Highest salary");
            //var SecSalary = employees.OrderByDescending(x => x.Salary).Select(x => x.Salary).ElementAt(1);
            var SecSalary = employees.OrderByDescending(x => x.Salary).Select(x => x.Salary).Skip(1).First();
            Console.WriteLine("Second Highest Salary is : " + SecSalary);
        }
    }

    class Employee4
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
