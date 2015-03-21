using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_MAudesse
{
    class Date
    {
        private int month;
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        private int day;
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public Date(int m, int d, int y)
        {
            Month = m; Day = d; Year = y;
            // TODO: Complete member initialization

        }
        public void DisplayDate()
        {
            Console.Write("{0}/{1}/{2}", month, day, year);
        }
    }
}
