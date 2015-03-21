using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {

            CrapsGame game = new CrapsGame();// create a new instance of the game
            Console.WriteLine("Your current balance is {0:C} ", game.Balance);

            Console.Write("Enter Wager or -1 to Quit:");
            game.Wager = Convert.ToInt32(Console.ReadLine());

            // Propmt user to enter wager, -1 to quit.
            //Read wager.

            //Using a while loop, keep checking to see if user has entered a valid wager.
            while (!(game.WagerIsValid()))
            {
                Console.Write("Wager cannot exceed balance ({0:C}): ", game.Balance);
                game.Wager = Convert.ToDecimal(Console.ReadLine());
            }

            while ((game.Wager != -1) && (game.Balance > 0))
            {
                game.Play();
                if (game.Balance <= 0)
                {
                    Console.WriteLine("Sorry, You Busted!");
                    break;
                }
                Console.WriteLine("\nYou current balance is {0:C} ", game.Balance);
                Console.Write("Enter Wager or -1 to Quit: ");
                game.Wager = Convert.ToInt32(Console.ReadLine());
                while (!(game.WagerIsValid()))
                {
                    Console.Write("Wager cannot exceed balance ({0:C}): ", game.Balance);
                    game.Wager = Convert.ToDecimal(Console.ReadLine());
                }

            } 
        }
    }
}
