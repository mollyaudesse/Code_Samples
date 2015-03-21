using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Part4_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
             int i = 0;          // for line numbers
            int count = 1;      // for counting number of times

            while (count <= 100)
            {
                Console.Write("*");
                if (count % 10 == 0)
                { Console.WriteLine(); }
                count++;
            }
        }
    }
}
