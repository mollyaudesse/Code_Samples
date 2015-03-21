using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22B_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            while (true)
            {
                m.DisplayMenu();
                int res = Convert.ToInt32(Console.ReadLine());
                m.ValidateSelection(ref res);
                if (res == 6)
                {
                    Console.WriteLine("Goodbye...");
                    return;
                }

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                m.DoMath(res, num1, num2);
                Console.WriteLine();
            }
        }

    }
}













