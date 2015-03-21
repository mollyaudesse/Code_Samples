using System;


namespace Lab7_MAudesse
{
    class Program
    {
        //const double PI = 3.14159; //Instance Var or field
        static void Main(string[] args)
        {
            int radius;  //Local variables
            double area, circumference;  //Local variables
            Console.Write("Enter radius of the circle : ");
            radius = Convert.ToInt32(Console.ReadLine());
            area = System.Math.PI * radius * radius;
            circumference = 2 * System.Math.PI * radius;
            Console.WriteLine("Diameter = {0}", 2 * radius);
            
            Console.WriteLine("Area = {0}\nCircumference = {1:f2}\n",
                area, circumference);
        }
    }

}

