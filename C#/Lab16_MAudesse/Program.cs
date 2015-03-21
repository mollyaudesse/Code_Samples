using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            int prevNum = 1;
            Console.WriteLine("n        n!");
            Console.WriteLine("- - - - - - \n");

            for (int i = 1; i <= 5; i++)
            {
                prevNum = prevNum * i;
                Console.WriteLine("{0}        {1}", i, prevNum);
                
            }


        }
    }
}
