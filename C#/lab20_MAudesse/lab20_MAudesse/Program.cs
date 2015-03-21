using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Bob Jones", 34500.00M);
            Console.WriteLine("Employee 1: {0};Yearly salary: {1:C2}", e.Name, e.Salary);
            Employee e2 = new Employee("Susan Baker", 37809.00M);
            Console.WriteLine("Employee 2: {0}; salary: {1:C2}", e2.Name, e2.Salary);

            e.Salary = e.Salary * (decimal)1.10;
            e2.Salary = e2.Salary * (decimal)1.10;
            Console.WriteLine("\nIncreasing employee salaries by 10%");
            Console.WriteLine("Employee 1: {0};Yearly salary: {1:C2}", e.Name, e.Salary);
            Console.WriteLine("Employee 2: {0};Yearly salary: {1:C2}", e2.Name, e2.Salary);
        }
    }
}
