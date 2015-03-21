using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight;
            int height;
            
            Console.WriteLine("Welcome to the body mass index (BMI) calculator");
            
            Console.Write("Enter your weight in pounds: ");
            weight = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter your height in inches: ");
            height = Convert.ToInt32(Console.ReadLine());
            int BMI = Convert.ToInt32(weight * 703 / Math.Pow(height, 2));
            
            Console.WriteLine("Your BMI is:{0}", BMI);

            Console.WriteLine("\nBMI VALUES");
            Console.WriteLine("Underweight: less than 18.5");
            Console.WriteLine("Normal:      between 18.5 and 24.9");
            Console.WriteLine("Overweight:  between 25 and 29.9");
            Console.WriteLine("Obese:       30 or greater");




        }
    }
}
