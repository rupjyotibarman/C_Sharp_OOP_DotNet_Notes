using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Linq
{
    internal class GroupBy
    {
        public static void GrpBy()
        {

        List<Employee5> employee5 = new()
            {
                new Employee5{Id=1,Name="John",Department="IT",Salary=50000},
                new Employee5{Id=2,Name="Bob",Department="IT",Salary=45000},
                new Employee5{Id=3,Name="Alice",Department="HR",Salary=80000},
                new Employee5{Id=4,Name="Emma",Department="HR",Salary=75000},
                new Employee5{Id=5,Name="David",Department="Finance",Salary=90000},
            };
            //Grouping
            foreach(var group in employee5.GroupBy(x => x.Department))
            {
                Console.WriteLine("Department is :"+ group.Key);
                foreach(var egrp in group)
                {
                    Console.WriteLine("Value : " + egrp.Name);
                }
                Console.WriteLine();
            }

            //Lookup
            var departments1 = employee5.ToLookup(x => x.Department);
            Console.WriteLine("\n\nDepartment IT Employess : ");
            foreach(var department in departments1)
            {
                if(department.Key == "IT")
                {
                    foreach(var name in department)
                    {
                        Console.Write($" {name.Name}");
                    }
                }
            }
            Console.WriteLine();


            //Count Number of employes in deperment wise
            var departments = employee5.GroupBy(x=>x.Department);
            foreach (var dept in departments) {
                Console.WriteLine(dept.Key + "has " + dept.Count() +" Employess");
            }
        }
    }
    class Employee5
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public double Salary { get; set; }
    }
}
