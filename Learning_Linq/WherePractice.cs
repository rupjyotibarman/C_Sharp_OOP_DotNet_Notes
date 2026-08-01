using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Linq
{
    internal class WherePractice
    {
        public static void WhereQuestion()
        {
            // Question 1
            List<int> numbers1 = new List<int>() { 3, 5, 1, 9, 5, 11, 20, 2 };
            Console.WriteLine("Q1. Print all numbers greater than 5.");
            // Your Answer Here
            IEnumerable<int> numGfive = numbers1.Where(n => n > 5);
            foreach (int num in numGfive)
            {
                Console.Write(num + "\t");
            }

            // Question 2
            List<int> numbers2 = new List<int>() { 10, 15, 18, 21, 24, 31, 42 };
            Console.WriteLine("\n\nQ2. Print all even numbers.");
            // Your Answer Here
            IEnumerable<int> numEven = numbers2.Where(n => n %2==0);
            foreach (int num in numEven)
            {
                Console.Write(num + "\t");
            }

            // Question 3
            List<int> numbers3 = new List<int>() { -5, 2, -8, 9, 0, 12, -1 };
            Console.WriteLine("\n\nQ3. Print only positive numbers.");
            // Your Answer Here
            IEnumerable<int> numPos = numbers3.Where(n => n>=0);
            foreach (int num in numPos)
            {
                Console.Write(num + "\t");
            }

            // Question 4
            List<string> names = new List<string>()
                {
                    "John","Alice","Bob","Jack","David","Jenny"
                };

            Console.WriteLine("\n\nQ4. Print names starting with 'J'.");
            // Your Answer Here
            IEnumerable<string> nameWj = names.Where(n => n.StartsWith("J"));
            foreach (string nm in nameWj)
            {
                Console.Write(nm + "\t");
            }

            // Question 5
            List<string> cities = new List<string>()
                {
                    "Delhi","Mumbai","London","Paris","Dubai","Doha"
                };

            Console.WriteLine("\n\nQ5. Print city names having length greater than 5.");
            // Your Answer Here
            IEnumerable<string> cityNames = cities.Where(n => n.Length > 5);
            foreach (string cnm in cityNames)
            {
                Console.Write(cnm + "\t");
            }

            // Question 6
            List<double> marks = new List<double>()
                {
                    45.5,82,91.5,33,68,74.5,97
                };

            Console.WriteLine("\n\nQ6. Print marks greater than or equal to 75.");
            // Your Answer Here
            IEnumerable<double> numG75 = marks.Where(n => n >= 75.0);
            foreach (int num in numG75)
            {
                Console.Write(num + "\t");
            }

            // Question 7
            Dictionary<int, string> students = new Dictionary<int, string>()
                {
                    {101,"John"},
                    {102,"Alice"},
                    {103,"Bob"},
                    {104,"Jack"}
                };

            Console.WriteLine("\n\nQ7. Print students whose key is greater than 102.");
            // Your Answer Here
            //IEnumerable<KeyValuePair<int,string>> Stu = students.Where(n => n.Key > 102);
            //foreach(var dict in Stu)
            //{
            //    Console.Write($"Key: {dict.Key} and name is {dict.Value}\t");
            //}
            foreach(var (key,value) in students.Where(n => n.Key > 102)){
                Console.Write($"Key: {key} and name is {value}\t");
            }


            // Question 8
            List<char> letters = new List<char>()
                {
                    'A','b','C','d','E','f'
                };

            Console.WriteLine("\n\nQ8. Print only uppercase letters.");
            // Your Answer Here
            foreach(var ch in letters.Where(ch=> char.IsUpper(ch) == true))
            {
                Console.Write(ch + "\t");
            }


            // Question 9
            List<int> ages = new List<int>()
                {
                    12,18,21,15,30,16,45
                };

            Console.WriteLine("\n\nQ9. Print ages eligible for voting (>=18).");
            // Your Answer Here
            foreach (int age in ages.Where(ag => ag>=18))
            {
                Console.Write(age + "\t");
            }


            // Question 10
            List<Employee> employees = new List<Employee>()
                {
                    new Employee{Id=1,Name="John",Age=25,Salary=50000},
                    new Employee{Id=2,Name="Alice",Age=32,Salary=80000},
                    new Employee{Id=3,Name="Bob",Age=28,Salary=45000},
                    new Employee{Id=4,Name="David",Age=35,Salary=90000},
                };

            Console.WriteLine("\n\nQ10. Print employees having salary greater than 60000.");
            // Your Answer Here
            foreach(var emp in employees.Where(e => e.Salary > 60000))
            {
                Console.Write(emp.Name +"get " + emp.Salary + "\t");
            }
        }
    }

    class Employee
    {
        public int Id;
        public string Name;
        public int Age;
        public double Salary;
    }
}
