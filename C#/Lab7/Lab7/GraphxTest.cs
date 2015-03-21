using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class GraphxTest
    {
        static void Main(string[] args)
        {
            Graphs application = new Graphs();
            // above statement is the default constructor
            //application is an object created of type Graphs. Graphs is your class that you are calling so application techincally = Graphs... so application.drawHistogram(); is calling that method from Graphs
            application.drawHistograms();
            //above statement calls the method 
        }
    }
}
