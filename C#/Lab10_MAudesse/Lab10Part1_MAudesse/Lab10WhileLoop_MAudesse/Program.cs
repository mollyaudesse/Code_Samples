using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10WhileLoop_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;          // for line numbers
            int count = 0;      // for counting number of times

            while (count < 10)
            {
                Console.WriteLine("Line {0}", m++);
                count++;
            }
        }
    }
}
