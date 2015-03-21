using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            int score = 0;
            Console.WriteLine("By how much have average temperatures risen since 1880?");
            Console.WriteLine("1: 0.4 degrees F");
            Console.WriteLine("2: 1.4 degrees F");
            Console.WriteLine("3: 2.4 degrees F");
            Console.WriteLine("4: 3.4 degrees F");
            Console.Write(">");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 2)
            {
                ++score;
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is 2\n");
            }
            Console.WriteLine("Montana's Glacier National Park had 150 glaciers in 1910.");
            Console.WriteLine("How many does it have now?");
            Console.WriteLine("1: 0");
            Console.WriteLine("2: 7");
            Console.WriteLine("3: 17");
            Console.WriteLine("4: 27");
            Console.Write(">");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 4)
            {
                ++score;
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is 4\n");
            }

            Console.WriteLine("What is the most abundant greenhouse gas?");
            Console.WriteLine("1: water vapor");
            Console.WriteLine("2: carbon dioxide");
            Console.WriteLine("3: methane");
            Console.WriteLine("4: carbon monoxide");
            Console.Write(">");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                ++score;
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is 1\n");
            }
            Console.WriteLine("Which of these should you NOT do to help stop global warming?");
            Console.WriteLine("1: Use less hot water");
            Console.WriteLine("2: Reuse your shopping bag");
            Console.WriteLine("3: Plant a tree");
            Console.WriteLine("4: Take a bath instead of a shower");
            Console.Write(">");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 4)
            {
                ++score;
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is 4\n");
            }

            Console.WriteLine("Which of these should you NOT do to help stop global warming?");
            Console.WriteLine("1: Buy more frozen foods");
            Console.WriteLine("2: Fly less");
            Console.WriteLine("3: Use a clothesline instead of a dryer");
            Console.WriteLine("4: Cover pots while cooking");
            Console.Write(">");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                ++score;
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is 1\n");
            }

            if (score == 5)
            {
                Console.WriteLine("Excellent!");
            }

            if (score == 4)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Time to brush up on your knowledge of global warming:");
                Console.WriteLine("http://news.nationalgeographic.com/news/20044/12/" + "1206_041206_global_warming.html");
                Console.WriteLine("http://lwf.ncdc.noaa.gov/oa/climate/gases.html");
                Console.WriteLine("http://globalwarming-facts.info/50-tips.html");
            }
        }

    }
}
