using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter numbers1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter numbers2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter numbers3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter numbers4: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3 && num1 >= num4)
            {
                Console.WriteLine("First number has the highest value, {0}", num1);


            }

            if(num2 >= num1 && num2 >= num3 && num2 >= num4)
            {
                Console.WriteLine("Second number has the highest value, {0}", num2);
            }

            if (num3 >= num1 && num3 >= num2 && num3 >= num4)
            {
                Console.WriteLine("Third number has the highest value, {0}", num3);
            }

            if (num4 >= num1 && num4 >= num2 && num4 >= num3)
            {
                Console.WriteLine("Fourth number has the highest value, {0}", num4);
            }
            
        }   
    }
}
