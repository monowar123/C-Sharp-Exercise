using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Time myTime = new Time();
            Time tt = new Time();
            myTime.SetTime(4, 40, 30);
            tt.SetTime(2, 30, 15);
            myTime.Display();
            tt.Display();
            Console.WriteLine("After adding two times: {0}",myTime.AddTime(tt));
            Console.ReadKey();
        }
    }

    // Extension method goes here..........
    // This is the extension of Time class........
    // Extension of a class must begiens with static keyword and all the methods of static class
    // must be static.
    static class TimeExtensions
    {
        public static void Display(this Time aTime)
        {
            Console.WriteLine(aTime.ToString());
        }
        public static Time AddTime(this Time aTime, Time bTime)
        {
            Time newTime = new Time();
            int temp = aTime.Second + bTime.Second;
            int flag = 0;
            if (temp >= 60)
            {
                newTime.Second = temp - 60;
                flag = 1;
            }
            else
                newTime.Second = temp;
            temp = aTime.Minute + bTime.Minute;
            if (flag == 1)
            {
                temp += 1;
            }
            flag = 0;
            if (temp >= 60)
            {
                newTime.Minute = temp - 60;
                flag = 1;
            }
            else
                newTime.Minute = temp;
            temp = aTime.Hour + bTime.Hour;
            newTime.Hour = (flag == 1 ? temp + 1 : temp);
            return newTime;
        }
    }
}
