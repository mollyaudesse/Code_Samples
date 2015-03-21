using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22A_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu(); //1 display the menu
                int res = Convert.ToInt32(Console.ReadLine()); //read choice from user
                ValidateSelection(ref res);
                if (res == 6)
                {
                    Console.WriteLine("Goodbye...");

                    return;
                }



                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                 DoMath(res, num1, num2);


                Console.WriteLine();
            }
        }

        // num has type of operation
        // num1 and num2 are parameters
        static void DoMath(int num, double num1, double num2)
        {
            
            switch (num)
            {
                case 1:


                    Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, MyMath.Add(num1, num2));
                    break;
                case 2:

                    Console.WriteLine("The difference of {0} and {1} is: {2}", num1, num2, MyMath.Subtract(num1, num2));
                    break;
                case 3:

                    Console.WriteLine("The product of {0} and {1} is: {2}", num1, num2, MyMath.Multiply(num1, num2));
                    break;
                case 4:
                    if(MyMath.Divide(num1, num2)!= -1)
                    {

                        Console.WriteLine("The dividend of {0} and {1} is: {2}", num1, num2, MyMath.Divide(num1, num2));
                    }
                    
                    break;
                case 5: if (MyMath.Modulus(num1, num2) != -1) 
                {
                    Console.WriteLine("The modulus of {0} and {1} is: {2}", num1, num2, MyMath.Modulus(num1, num2));
                }
                    
                    break;
                default:
                    Console.WriteLine("{0} is an invalid selection", num);
                  
                    break;

            }
            
        }

        static void ValidateSelection(ref int res)
        {
            while (res < 1 || res > 6)
            {
                Console.WriteLine("{0} is not a valid case. \n Enter values between [1-6]", res);
                DisplayMenu();
                res = Convert.ToInt32(Console.ReadLine()); 

            }

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
            Console.WriteLine("----------");
            Console.Write("Enter your selection[1-6]: ");


            return;
        }
    }
}
