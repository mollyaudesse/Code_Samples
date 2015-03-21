using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            Console.WriteLine("The int is: {0}", myInt);

            short myShort;
            myShort = 5;
            Console.WriteLine("The short is: {0}", myShort);

            long myLong = 20;
            byte myByte = 127;
            float myFloat = 44.44F;
            double myDouble = 3.333;
            decimal myDecimal = 555.55M;
            char myChar = 'y';
            bool myBool = true;
            string myString = "Good Morning";

            Console.WriteLine("The long is: {0}", myLong);
            Console.WriteLine("The byte is: {0}", myByte);
            Console.WriteLine("The short is: {0}", myShort);
            Console.WriteLine("The float is: {0}", myFloat);
            Console.WriteLine("The double is: {0}", myDouble);
            Console.WriteLine("The decimal is: {0}", myDecimal);
            Console.WriteLine("The char is: {0}", myChar);
            Console.WriteLine("The bool is: {0}", myBool);
            Console.WriteLine("The string is: {0}", myString);
            Console.WriteLine();

            string input;
            Console.Write("Please enter an int: ");
            input = Console.ReadLine();  //read string from user input
            myInt = Convert.ToInt32(input);
            Console.WriteLine("The int is: {0}", myInt);

            
            Console.Write("Please enter a short: ");
            input = Console.ReadLine();  //read string from user input
            myShort= Convert.ToInt16(input);
            Console.WriteLine("The short is: {0}", myShort);

            
            Console.Write("Please enter a long: ");
            input = Console.ReadLine();  //read string from user input
            myLong = Convert.ToInt64(input);
            Console.WriteLine("The long is: {0}", myLong);

            
            Console.Write("Please enter a byte: ");
            input = Console.ReadLine();  //read string from user input
            myByte = Convert.ToByte(input);
            Console.WriteLine("The byte is: {0}", myByte);

            
            Console.Write("Please enter a float: ");
            input = Console.ReadLine();  //read string from user input
            myFloat = Convert.ToSingle(input);
            Console.WriteLine("The float is: {0}", myFloat);

            
            Console.Write("Please enter a double: ");
            input = Console.ReadLine();  //read string from user input
            myDouble = Convert.ToDouble(input);
            Console.WriteLine("The double is: {0}", myDouble);

            
            Console.Write("Please enter a decimal: ");
            input = Console.ReadLine();  //read string from user input
            myDecimal = Convert.ToDecimal(input);
            Console.WriteLine("The decimal is: {0}", myDecimal);

            
            Console.Write("Please enter a char: ");
            input = Console.ReadLine();  //read string from user input
            myChar = Convert.ToChar(input);
            Console.WriteLine("The char is: {0}", myChar);

            
            Console.Write("Please enter a bool: ");
            input = Console.ReadLine();  //read string from user input
            myBool = Convert.ToBoolean(input);
            Console.WriteLine("The bool is: {0}", myBool);

            
            Console.Write("Please enter a string: ");
            input = Console.ReadLine();  //read string from user input
            myString = Convert.ToString(input);
            Console.WriteLine("The string is: {0}", myString);


            
         
        }
    }
}