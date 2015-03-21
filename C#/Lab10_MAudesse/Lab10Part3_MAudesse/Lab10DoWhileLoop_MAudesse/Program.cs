using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10DoWhileLoop_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;          // for line numbers
            int count = 0;      // for counting number of times

            do
            {
                Console.WriteLine("Line {0}", i++);
                count++;
            } while (count < 10);
        }
    }
}
