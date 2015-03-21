using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24_MAudesse
{
    class Game
    {
        private Random rand;

        public Game()
        {
            Guessed = false;
            NumTries = 0;
            UsersGuess = 0;
            rand = new Random();
            SecretNum = rand.Next(1, 1001);

        }

        private bool guessed;
        public bool Guessed
        {
            get
            {
                return guessed;
            }
            set
            {
                guessed = value;
            }
        }

        private int numtries;
        public int NumTries
        {
            get
            {
                return numtries;
            }
            set
            {
                numtries = value;
            }
        }

        private int secretnum;
        public int SecretNum
        {
            get
            {
                return secretnum;
            }
            set
            {
                secretnum = value;
            }
        }
        private int usersguess;
        public int UsersGuess
        {
            get
            {
                return usersguess;
            }
            set
            {
                usersguess = value;
            }
        }

        public void CheckResults()
        {
            if (UsersGuess == SecretNum)
            {
                DisplayResults();
            }
            if (UsersGuess > SecretNum)
            {
                Console.WriteLine("{0}-Too high, guess lower", UsersGuess);
            }
            if (UsersGuess < SecretNum)
            {
                Console.WriteLine("{0}-Too low, guess higher", UsersGuess);
            }
            NumTries++;
        }

        private void DisplayResults()
        {
            switch (NumTries)
            {
                case 1:

                case 2:

                case 3:

                case 4:

                case 5:

                case 6:

                case 7:

                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Aha! You know the secret!");
                    break;
                default:
                    Console.WriteLine("You should be able to do better!");
                    break;

            }
            /* if (NumTries<=10)
             {
                 Console.WriteLine("Aha! You know the secret!");
                
             }
             else
             {
                 Console.WriteLine("You should be able to do better!");
             } */
        }
    }
}
