using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; // declare first number to add
            int number2; // declare second number to add
            int sum; // declare the sum of number 1 and number 2
            int product; // declare the product of number 1 and number 2
            int difference; // declare the difference of number 1 and number 2
            int quotient; // declare the quotient of number 1 and number 2
            int remainder; // declare the remainder of number 1 and number 2

            Console.Write("enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            sum = number1 + number2;
            Console.WriteLine("sum is: {0}", sum);

            product = number1 * number2;
            Console.WriteLine("product is: {0}", product);

            difference = number1 - number2;
            Console.WriteLine("difference is: {0}", difference);

            quotient = number1 / number2;
            Console.WriteLine("quotient is {0}", quotient);

            remainder = number1 % number2;
            Console.WriteLine("remainder is {0}", remainder);




        }
    }
}
