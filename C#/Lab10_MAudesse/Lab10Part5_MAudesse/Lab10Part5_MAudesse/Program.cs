using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Part5_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            while (i <=10)
            {
                j = 1;
                while (j <= 10)
                {
                    Console.Write("+");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
