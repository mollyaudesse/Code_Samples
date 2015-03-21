using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter Grade [0-100]: ");
            int score = Convert.ToInt32(Console.ReadLine());

            ValidateSelection(ref score);

            if (score == -1)
            {
                Console.WriteLine("Goodbye... ");

            }

            else if (score >= 0 && score <= 100)
            {
                char prefix = '\0'; //initialize it to null.
                char grade = '\0';


                switch (score % 10)
                {
                    case 0:
                    case 1:
                    case 2:
                        prefix = '-';
                        break;
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        prefix = ' ';
                        break;
                    case 7:
                    case 8:
                    case 9:

                        prefix = '+';
                        break;

                    default:
                        prefix = ' ';
                        break;
                }

                switch (score / 10)
                {
                    case 6:
                        grade = 'D';
                        break;
                    case 7:
                        grade = 'C';
                        break;
                    case 8:
                        grade = 'B';
                        break;
                    case 9:
                        grade = 'A';
                        break;
                    case 10:
                        grade = 'A';
                        break;
                    default:
                        grade = 'F';
                        break;
                }
                Console.WriteLine("The grade is : {0}{1}", grade, prefix);
            }


        }

        static void ValidateSelection(ref int score)
        {
            if (score <= -1 || score > 100)
            {
                Console.Write("{0} is not a valid score. Enter a test score [0-100], -1 to quit: ", score);

                score = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
