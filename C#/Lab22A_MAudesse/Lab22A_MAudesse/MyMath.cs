using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22A_MAudesse
{
    class MyMath
    {
       public static double Add(double i, double j)
        {
            return i + j;


        }
        public static double Subtract(double i, double j)
        {
            return i - j;


        }
        public static double Multiply(double i, double j)
        {
            return i * j;


        }
        public static double Divide(double i, double j)
        {
            if (j == 0)
            {
                Console.WriteLine("Cannot divide by zero. Please try again with valid values.");
                return -1;
            }
            return i / j;



        }

        public static double Modulus(double i, double j)
        {
            if (j == 0)
            {
                Console.WriteLine("Cannot divide by zero. Please try again with valid values.");
                return -1;
            }
            return i % j;


        }
    }
}
