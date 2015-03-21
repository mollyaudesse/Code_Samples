using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; // first number
            int number2; // second number
            int number3; // third number
            int largest; // largest value
            int smallest; // smallest value
            int sum; // sum of numbers
            int product; // product of numbers
            int average; // average of numbers

            // prompt for input and read first integer
            Console.Write("Enter first integer: ");
            number1 = Convert.ToInt32(Console.Readline());

            // prompt for input and read second integer
            Console.Write("Enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            // prompt for input and read third integer
            Console.Write("Enter third integer: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            // determine largest value
            largest = number1; // assume number1 is the largest

            if (number2 > largest) // determine whether number2 is larger
                largest = number2

            if (number3 > largest) // determine whether number3 is larger
                largest = number3

            // determine smallest value
            smallest = number1; // assume number1 is the smallest

            if (number2 < smallest) // determine whether number2 is smallest
                smallest = number2;

            if (number3 < smallest) // determine whether number3 is smallest
                smallest = number3;

            //perform calculations to find average

            sum = number1 + number2 + number3;

            product = number1 * number2 * number3;
 
            average = sum / 3;

            // display results

            Console.WriteLine("\nFor the numbers {0}, {1} and {2}", number1, number2, number3);
            Console.WriteLine("Largest is {0}", largest);
            Console.WriteLine("Smallest is {0}", smallest);
            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("Product is {0}", product);
            Console.WriteLine("Average is {0}", average);

         
        }
    }
}
