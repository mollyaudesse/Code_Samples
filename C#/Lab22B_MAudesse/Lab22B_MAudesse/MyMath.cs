using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22B_MAudesse
{
    class MyMath
    {
         public void DoMath(int num, double num1, double num2)
        {

            switch (num)
            {
                case 1:


                    Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, Add(num1, num2));
                    break;
                case 2:

                    Console.WriteLine("The difference of {0} and {1} is: {2}", num1, num2, Subtract(num1, num2));
                    break;
                case 3:

                    Console.WriteLine("The product of {0} and {1} is: {2}", num1, num2, Multiply(num1, num2));
                    break;
                case 4:
                    if(Divide(num1, num2) != -1)
                    {

                        Console.WriteLine("The dividend of {0} and {1} is: {2}", num1, num2, Divide(num1, num2));
                    }

                    break;
                case 5: if (Modulus(num1, num2) != -1)
                    {
                        Console.WriteLine("The modulus of {0} and {1} is: {2}", num1, num2, Modulus(num1, num2));
                    }

                    break;
                default:
                    Console.WriteLine("{0} is an invalid selection", num);

                    break;


            }
        }

         public double Add(double i, double j)
        {
            return i + j;


        }
         public double Subtract(double i, double j)
        {
            return i - j;


        }
         public double Multiply(double i, double j)
        {
            return i * j;


        }
         public double Divide(double i, double j)
        {
            if (j == 0)
            {
                Console.WriteLine("Cannot divide by zero. Please try again with valid values.");
                return -1;
            }
            return i / j;



        }

         public double Modulus(double i, double j)
        {
            if (j == 0)
            {
                Console.WriteLine("Cannot divide by zero. Please try again with valid values.");
                return -1;
            }
            return i % j;

        }

        public void DisplayMenu()
        {
            Console.WriteLine("Calculator Menu\n");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            Console.WriteLine("5) Modulus");
            Console.WriteLine("6) Quit");
            Console.WriteLine("----------");
            Console.Write("Enter your selection[1-6]: ");


            return;
        }
         public void ValidateSelection(ref int res)
        {
            while (res < 1 || res > 6)
            {
                Console.WriteLine("{0} is not a valid case. \n Enter values between [1-6]", res);
                DisplayMenu();
                res = Convert.ToInt32(Console.ReadLine());
            }
        }

    }
}
