using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu(); //1 display the menu
                int num = Convert.ToInt32(Console.ReadLine()); //read choice from user
                if (num == 6)
                {
                    Console.WriteLine("Goodbye...");

                    return;
                }



                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = DoMath(num, num1, num2);


                Console.WriteLine();
            }
        }

        // num has type of operation
        // num1 and num2 are parameters
        static double DoMath(int num, double num1, double num2)
        {
            double result;
            switch (num)
            {
                case 1:

                    result = Add(num1, num2);
                    Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, result);
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    Console.WriteLine("The difference of {0} and {1} is: {2}", num1, num2, result);
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    Console.WriteLine("The product of {0} and {1} is: {2}", num1, num2, result);
                    break;
                case 4:
                    result = Divide(num1, num2);
                    Console.WriteLine("The dividend of {0} and {1} is: {2}", num1, num2, result);
                    break;
                case 5:
                    result = Modulus(num1, num2);
                    Console.WriteLine("The modulus of {0} and {1} is: {2}", num1, num2, result);
                    break;
                default:
                    Console.WriteLine("{0} is an invalid selection", num);
                    result = -1;
                    break;

            }
            return result;
        }


        static double Add(double i, double j)
        {
            return i + j;


        }
        static double Subtract(double i, double j)
        {
            return i - j;


        }
        static double Multiply(double i, double j)

        {
            return i * j;


        }
        static double Divide(double i, double j)
        {
            return i / j;


        }

        static double Modulus(double i, double j)
        {
            return i % j;


        }
        static void DisplayMenu()
        {
            Console.WriteLine("Calculator Menu\n");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            Console.WriteLine("5) Modulus");
            Console.WriteLine("6) Quit");
            Console.Write("Enter your selection[1-6]: ");


            return;
        }
    }
}
