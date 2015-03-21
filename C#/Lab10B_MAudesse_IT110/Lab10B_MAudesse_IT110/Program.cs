using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10B_MAudesse_IT110
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

           
          
            
                if (student1Grade >= 50)
                {
                    switch (student1Grade / 10)
                    {
                        case 10:
                            Console.WriteLine("Student 1 got an A");
                            break;
                        case 9:
                            Console.WriteLine("Student 1 got an A");
                            break;
                        case 8:
                            Console.WriteLine("Student 1 got a B");
                            break;
                        case 7:
                            Console.WriteLine("Student 1 got a C");
                            break;
                        case 6:
                            Console.WriteLine("Student 1 got a D");
                            break;
                        case 5:
                            Console.WriteLine("Student 1 got a F");
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("Student 1 got a F");
                }

                if (student2Grade >= 50)
                {
                    switch (student2Grade / 10)
                    {
                        case 10:
                            Console.WriteLine("Student 2 got an A");
                            break;
                        case 9:
                            Console.WriteLine("Student 2 got an A");
                            break;
                        case 8:
                            Console.WriteLine("Student 2 got a B");
                            break;
                        case 7:
                            Console.WriteLine("Student 2 got a C");
                            break;
                        case 6:
                            Console.WriteLine("Student 2 got a D");
                            break;
                        case 5:
                            Console.WriteLine("Student 2 got a F");
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("Student 2 got a F");
                }

                if (student3Grade >= 50)
                {
                    switch (student3Grade / 10)
                    {
                        case 10:
                            Console.WriteLine("Student 3 got an A");
                            break;
                        case 9:
                            Console.WriteLine("Student 3 got an A");
                            break;
                        case 8:
                            Console.WriteLine("Student 3 got a B");
                            break;
                        case 7:
                            Console.WriteLine("Student 3 got a C");
                            break;
                        case 6:
                            Console.WriteLine("Student 3 got a D");
                            break;
                        case 5:
                            Console.WriteLine("Student 3 got a F");
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("Student 3 got a F");
                }

                if (student4Grade >= 50)
                {
                    switch (student4Grade / 10)
                    {
                        case 10:
                            Console.WriteLine("Student 4 got an A");
                            break;
                        case 9:
                            Console.WriteLine("Student 4 got an A");
                            break;
                        case 8:
                            Console.WriteLine("Student 4 got a B");
                            break;
                        case 7:
                            Console.WriteLine("Student 4 got a C");
                            break;
                        case 6:
                            Console.WriteLine("Student 4 got a D");
                            break;
                        case 5:
                            Console.WriteLine("Student 4 got a F");
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("Student 4 got a F");
                }

                if (student5Grade >= 50)
                {
                    switch (student5Grade / 10)
                    {
                        case 10:
                            Console.WriteLine("Student 5 got an A");
                            break;
                        case 9:
                            Console.WriteLine("Student 5 got an A");
                            break;
                        case 8:
                            Console.WriteLine("Student 5 got a B");
                            break;
                        case 7:
                            Console.WriteLine("Student 5 got a C");
                            break;
                        case 6:
                            Console.WriteLine("Student 5 got a D");
                            break;
                        case 5:
                            Console.WriteLine("Student 5 got a F");
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("Student 5 got a F");
                }

                Console.ReadLine();
        }
    }
}
