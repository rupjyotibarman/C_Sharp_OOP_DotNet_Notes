using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

namespace Learning_Linq.Questions
{
    internal class LinqPractice
    {
        public static void LinqQ()
        {
            List<Department> departments = new()
            {
                new Department{ Id=1, Name="HR"},
                new Department{ Id=2, Name="IT"},
                new Department{ Id=3, Name="Finance"},
                new Department{ Id=4, Name="Sales"}
            };

            List<Employee> employees = new()
            {
                new Employee{ Id=1, Name="John", Age=25, Salary=40000, DepartmentId=1, City="Delhi", IsActive=true},
                new Employee{ Id=2, Name="Alice", Age=30, Salary=70000, DepartmentId=2, City="Mumbai", IsActive=true},
                new Employee{ Id=3, Name="Bob", Age=28, Salary=55000, DepartmentId=2, City="Delhi", IsActive=false},
                new Employee{ Id=4, Name="David", Age=35, Salary=90000, DepartmentId=3, City="Pune", IsActive=true},
                new Employee{ Id=5, Name="Eva", Age=24, Salary=35000, DepartmentId=1, City="Delhi", IsActive=true},
                new Employee{ Id=6, Name="Mike", Age=32, Salary=80000, DepartmentId=4, City="Bangalore", IsActive=false},
                new Employee{ Id=7, Name="Tom", Age=27, Salary=60000, DepartmentId=2, City="Mumbai", IsActive=true},
                new Employee{ Id=8, Name="Sara", Age=29, Salary=65000, DepartmentId=4, City="Pune", IsActive=true}
            };

            //Questions:
            //Find all employees older than 30.
            employees.Where(e => e.Age > 30);
            //Find employees from Delhi.
            employees.Where(e => e.City == "Delhi");
            //Find top 3 highest - paid employees.
            employees.OrderByDescending(e => e.Salary).Distinct().Take(3);
            //Find second highest salary.
            employees.OrderByDescending(e => e.Salary).Select(e=>e.Salary).Distinct().ElementAt(1);
            //Find average salary department-wise.
            employees.GroupBy(e => e.DepartmentId).Select(dep=> new {Department = dep.Key, AverageSalary = dep.Average(e=>e.Salary)});
            //Find highest salary department-wise.
            employees.GroupBy(e => e.DepartmentId).Select(dept => new { Department = dept.Key, HighestSalary = dept.Max(e => e.Salary) });
            //Find employee count department-wise.
            employees.GroupBy(emp => emp.DepartmentId).Select(dept => new { Department = dept.Key, EmployeeCount = dept.Count() });
            //Find duplicate cities.
            employees.GroupBy(e => e.City).Where(c => c.Count() > 1).Select(c=>c.Key);
            //Find employees whose name starts with "A".
            employees.Where(e => e.Name.StartsWith("A"));
            //Find inactive employees.
            employees.Where(e => !e.IsActive);

            //Find employees without a department(Left Join scenario).

            //Join Employee and Department.

            //Group employees by city.
            employees.GroupBy(e => e.City);
            //Find departments having more than two employees.
            employees.GroupBy(e => e.DepartmentId).Where(e => e.Count() > 2).Select(e => e.Key);
            //Find total salary department-wise.
            employees.GroupBy(e=>e.DepartmentId).Select(dept=> new {Department = dept.Key, TotalSalary = dept.Sum(e=>e.Salary) });
            //Find youngest employee in every department.
            employees.GroupBy(e => e.DepartmentId).Select(dept => new { Department = dept.Key, YoungestEmp = dept.OrderBy(e => e.Age).FirstOrDefault() });
            employees.GroupBy(e => e.DepartmentId).Select(dept => new { Department = dept.Key, YoungestEmp = dept.MinBy(e=>e.Age) });

            //Find employees earning above department average.
            //Convert employee list to dictionary.
            //Convert employee list to lookup.
            //Write the same query in Query Syntax and Method Syntax.
        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
}


    }
