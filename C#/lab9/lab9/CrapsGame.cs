using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class CrapsGame
    {
        GAME_STATUS gStatus = GAME_STATUS.LOST;
        int roll;
        int myPoint;
        Random rand = new Random();
        public CrapsGame()
        {
            roll = -1;
            myPoint = -1;
            Console.WriteLine("Game has started.");
        }// end CrapsGame

        public void PlayGame() {
            roll = RollDice();

            switch (roll)
            {
                case 2:    
                case 3:
                case 12:
                    gStatus = GAME_STATUS.LOST;
                    break;
                case 7:
                case 11:
                    gStatus = GAME_STATUS.WON;
                    break;
                default: gStatus = GAME_STATUS.CONTINUE;
                    myPoint = roll;
                    Console.WriteLine("Players Point: {0}", myPoint);
                    break;
            }// end switch


            while (gStatus == GAME_STATUS.CONTINUE)
            {
                roll = RollDice();
                if (roll == myPoint)
                    gStatus= GAME_STATUS.WON;
                else if(roll == 7)
                    gStatus= GAME_STATUS.LOST;
            }// end while

            if(gStatus == GAME_STATUS.WON)
                Console.WriteLine("Player Wins\n\n"); 
            else
                Console.WriteLine("Player Loses\n\n");
        }// end PlayGame


        public int RollDice(){
            int roll1 = rand.Next(1, 7);
            int roll2 = rand.Next(1, 7);
            int total = roll1 + roll2;
            Console.WriteLine("Player rolled: {0}: {1}, {2}", total, roll1, roll2);
            return total;
            
        }// end RollDice

    }
}
