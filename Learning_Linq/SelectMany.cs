using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Linq
{
    internal class SelectMany
    {
        public static void SelectManyQ()
        {
          
            List<Department> departments = new List<Department>()
            {
                new Department
                {
                    Name="IT",
                    Employees = new List<string>{"John","Bob"}
                },
                new Department
                {
                    Name="HR",
                    Employees = new List<string>{"Alice","David"}
                },
                new Department
                {
                    Name="Finance",
                    Employees = new List<string>{"Tom","Jerry"}
                }
            };
            // Question 29
            Console.WriteLine("Q29. Print all employees from all departments.");
                // Your Answer Here
                foreach (string empName in departments.SelectMany(x => x.Employees)) {
                    Console.Write(empName + "\t");
                }


            // Question 30
            Console.WriteLine("\n\nQ30. Convert all employee names to uppercase using SelectMany.");
            // Your Answer Here
            foreach (string empName in departments.SelectMany(x => x.Employees).Select(name=>name.ToUpper()))
            {
                Console.Write(empName + "\t");
            }

            // Question 31
            Console.WriteLine("\n\nQ31. Print only employee names starting with J from all departments.");
            // Your Answer Here
            foreach (string empNameJ in departments.SelectMany(x => x.Employees).Where(name=> name.StartsWith("J")))
            {
                Console.Write(empNameJ + "\t");
            }

            // Question 32
            Console.WriteLine("\n\nQ32. Print employee names having length greater than 3 from all departments.");
            // Your Answer Here
            foreach (string empNameLG3 in departments.SelectMany(x => x.Employees).Where(name => name.Length>3))
            {
                Console.Write(empNameLG3 + "\t");
            }

            // Question 32.1
            Console.WriteLine("\n\nQ32.1. Print employee names having length greater than 3 from IT Department");
            // Your Answer Here
            foreach (string empNameLG3IT in departments.Where(emp=>emp.Name=="IT").SelectMany(x => x.Employees).Where(name => name.Length > 3 ))
            {
                Console.Write(empNameLG3IT + "\t");
            }
            // Question 33
            List<Company> companies = new List<Company>()
            {
                new Company
                {
                    Name="ABC",
                    Departments = departments
                }
            };

            Console.WriteLine("\n\nQ33. Print all employees from all companies using SelectMany.");
            // Your Answer Here

            foreach(string empName in companies.SelectMany(com => com.Departments).SelectMany(dep=>dep.Employees))
            {
                Console.Write(empName + "\t");
            }
        }
    }
    class Department
    {
        public string Name;
        public List<string> Employees;
    }
    class Company
    {
        public string Name;
        public List<Department> Departments;
    }
}
