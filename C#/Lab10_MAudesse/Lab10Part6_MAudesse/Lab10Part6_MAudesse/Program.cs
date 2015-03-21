using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Part6_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            const int Max_Rows = 11;
            const int Max_Columns = 11;
            for (row = 0; row < Max_Rows; row++)
            {

                for (int column = 0; column < Max_Columns; column++)
                {
                    if (column == row || (column + row) == Max_Rows - 1)
                        Console.Write("*");
                    else
                        Console.Write(' ');

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
