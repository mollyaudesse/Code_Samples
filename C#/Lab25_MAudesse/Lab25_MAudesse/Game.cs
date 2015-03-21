using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25_MAudesse
{

        // enumeration with constants that represent the game status
        enum Status { CONTINUE, WON, LOST }

        // enumeration with constants that represent common rolls of the dice
        enum DiceNames
        {
            SNAKE_EYES = 2,
            TREY = 3,
            SEVEN = 7,
            YO_LEVEN = 11,
            BOX_CARS = 12
        }

        //
        // Start of the me Class
        //
        class CrapsGame
        {
            // Field random number generator for use in method RollDice
            private Random randomNumbers = new Random();
            public Status gameStatus { get; set; }  // Property to keep track of game's status
            public int MyPoint { get; set; }    // Property MyPoint
            public decimal Wager { get; set; }  // Property Wager

            private decimal balance;    // Field balance
            public decimal Balance      // Property Balance
            {
                get { return balance; }
                set { if (value > 0) balance = value; }
            }

            // Used by the Main method to make sure that
            // user has entered a valid wager.
            public bool WagerIsValid()
            {
                bool returnValue = false;
                if (Wager <= Balance)
                {
                    returnValue = true;
                }
                return returnValue;
            }


            //Constructor. Initializes all fields and properties before game starts.
            public CrapsGame()
            {
                // randomNumbers = new Random();
                Balance = 1000; // every game starts with $1000.00 balance
                MyPoint = -1;
                gameStatus = Status.CONTINUE;
            }

            // Plays the game by rolling dice. 
            //Depending on the roll, game is decided. Won or loss
            // See example in the book.
            public void Play()
            {
                gameStatus = Status.CONTINUE;

                int sumOfDice = RollDice();

                switch ((DiceNames)sumOfDice)
                {
                    case DiceNames.SEVEN:
                    case DiceNames.YO_LEVEN:
                        gameStatus = Status.WON;
                        break;
                    case DiceNames.SNAKE_EYES:
                    case DiceNames.TREY:
                    case DiceNames.BOX_CARS:
                        gameStatus = Status.LOST;
                        break;
                    default:
                        gameStatus = Status.CONTINUE;
                        MyPoint = sumOfDice;
                        Console.WriteLine("Point is {0}", MyPoint);
                        break;
                }
                while (gameStatus == Status.CONTINUE)
                {
                    sumOfDice = RollDice();

                    if (sumOfDice == MyPoint)
                        gameStatus = Status.WON;
                    else if (sumOfDice == (int)DiceNames.SEVEN)
                        gameStatus = Status.LOST;

                }
                if (gameStatus == Status.WON)
                {
                    Console.WriteLine("Player wins!");
                    balance += Wager;
                }
                else
                {
                    Console.WriteLine("Player loses!");
                    balance -= Wager;

                }


            }

            // Method RollDice simulates rolling two dice.
            // returns a number between 2 and 12. See example in the book.
            public int RollDice()
            {
                int die1 = randomNumbers.Next(1, 7);
                int die2 = randomNumbers.Next(1, 7);
                int sum = die1 + die2;

                Console.WriteLine("Player rolled {0} + {1} = {2}", die1, die2, sum);
                return sum;

            }
        }
    }
