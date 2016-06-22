using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    public class Date
    {
        private int month;
        private int day;
        public int Year { get; set; }
        public Date(int theMonth, int theDay, int theYear)
        {
            month = theMonth;
            day = theDay;
            Year = theYear;
        }
        public int Month
        {
            get
            {
                return month;
            }
            private set
            {
                if (value > 0 && value <= 12)
                    month = value;
                else
                {
                    Console.WriteLine("Invalid month set ({0}) set to 1.", value);
                    month = 1;
                }
            }
        }
        public int Day
        {
            get
            {
                return day;
            }
            private set
            {
                int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (value > 0 && value <= daysPerMonth[Month])
                    day = value;
                else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                    day = value;
                else
                {
                    Console.WriteLine("Invalid day ({0}) set to 1.", value);
                    day = 1;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Month, Day, Year);
        }
    }
}
