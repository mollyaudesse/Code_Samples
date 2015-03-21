using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Would you like to play the guessing game [Y/N]? ");
            char cResponse = Console.ReadLine().ToUpper()[0];

            while (cResponse.Equals('Y'))
            {
                Game g = new Game();
                Console.WriteLine("Guess a number between 1 and 1000, -1 to Exit");
                Console.Write("Enter your guess: ");
                g.UsersGuess = Convert.ToInt32(Console.ReadLine());
                if (g.UsersGuess == -1)
                {
                    Console.WriteLine("Good bye...");
                    break;
                }

                while (!g.Guessed)
                {
                    if (g.UsersGuess == -1)
                    {
                        Console.WriteLine("Good bye...");
                        return;
                    }
                    g.CheckResults();
                    if (!g.Guessed)
                    {
                        if (g.UsersGuess == g.SecretNum)
                        {
                            break;
                        }
                        Console.Write("Enter your guess: ");
                        g.UsersGuess = Convert.ToInt32(Console.ReadLine());

                    }

                }
                Console.Write("Would you like to play again [Y or N]? ");
                cResponse = Console.ReadLine().ToUpper()[0];
            }

        }
    }
}
