using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(7, 4, 2004);
            Console.Write("The initial date is: "); d.DisplayDate();
            d.Month = 11;
            d.Day = 1;
            d.Year = 2003;
            Console.Write("\nDate with new value: "); d.DisplayDate();
            Console.WriteLine();
        }
    }
}
