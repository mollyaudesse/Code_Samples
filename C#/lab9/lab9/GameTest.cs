using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class GameTest
    {
        static void Main(string[] args)
        {
            CrapsGame game1 = new CrapsGame();
            for (int counter = 1; counter <= 10; counter++)
            {
                game1.PlayGame(); 
            }
        }
    }
}
