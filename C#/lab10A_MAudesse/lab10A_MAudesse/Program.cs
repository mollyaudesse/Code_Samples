using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10A_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1- Please enter a grade: ");
            int student1Grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("2- Please enter a grade: ");
            int student2Grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("3- Please enter a grade: ");
            int student3Grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("4- Please enter a grade: ");
            int student4Grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("5- Please enter a grade: ");
            int student5Grade = Convert.ToInt32(Console.ReadLine());

            if (student1Grade >= 90)
            {
                Console.WriteLine("Student 1 got an A");
            }
            else if (student1Grade >= 80)
            {
                Console.WriteLine("Student 1 got a B");
            }
            else if (student1Grade >= 70)
            {
                Console.WriteLine("Student 1 got a C");
            }
            else if (student1Grade >= 60)
            {
                Console.WriteLine("Student 1 got a D");
            }
            else
            {
                Console.WriteLine("Student 1 got an F");

            }

            if (student2Grade >= 90)
            {
                Console.WriteLine("Student 2 got an A");
            }
            else if (student2Grade >= 80)
            {
                Console.WriteLine("Student 2 got a B");
            }
            else if (student2Grade >= 70)
            {
                Console.WriteLine("Student 2 got a C");
            }
            else if (student2Grade >= 60)
            {
                Console.WriteLine("Student 2 got a D");
            }
            else
            {
                Console.WriteLine("Student 3 got an F");
            }
            if (student3Grade >= 90)
            {
                Console.WriteLine("Student 3 got an A");
            }
            else if (student3Grade >= 80)
            {
                Console.WriteLine("Student 3 got a B");
            }
            else if (student3Grade >= 70)
            {
                Console.WriteLine("Student 3 got a C");
            }
            else if (student3Grade >= 60)
            {
                Console.WriteLine("Student 3 got a D");
            }
            else
            {
                Console.WriteLine("Student 3 got an F");
            }

            if (student4Grade >= 90)
            {
                Console.WriteLine("Student 4 got an A");
            }
            else if (student4Grade >= 80)
            {
                Console.WriteLine("Student 4 got a B");
            }
            else if (student4Grade >= 70)
            {
                Console.WriteLine("Student 4 got a C");
            }
            else if (student4Grade >= 60)
            {
                Console.WriteLine("Student 4 got a D");
            }
            else
            {
                Console.WriteLine("Student 4 got an F");
            }

            if (student5Grade >= 90)
            {
                Console.WriteLine("Student 5 got an A");
            }
            else if (student5Grade >= 80)
            {
                Console.WriteLine("Student 5 got a B");
            }
            else if (student5Grade >= 70)
            {
                Console.WriteLine("Student 5 got a C");
            }
            else if (student5Grade >= 60)
            {
                Console.WriteLine("Student 5 got a D");
            }
            else
            {
                Console.WriteLine("Student 5 got an F");
            }
        }

    }
}
