using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            double principle = 0;
            double interest = 0;
            int years = 0;
            double amtAccumulated = 0;
            int nCompounds = 0;

            Console.Write("Enter principle amount: ");
            principle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter interest rate: ");
            interest = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time in years of investment: ");
            years = Convert.ToInt32(Console.ReadLine());
           


            Console.WriteLine("Interest rate: {0:0.00}% on amount ${1:#,###0}", interest, principle);
            Console.WriteLine("Year     Current value of deposit");

            for (int i = 1; i <= years; i++)
            {
                amtAccumulated = principle * ((double)Math.Pow(1.0 + (interest/100), i));
                Console.WriteLine("{0}      ${1:#,###0.00}", i, amtAccumulated);
            }




        }
    }
}
