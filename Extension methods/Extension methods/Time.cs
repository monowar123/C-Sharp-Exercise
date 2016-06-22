using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_methods
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;
        public void SetTime(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public string ToUniversalString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
        }
        public override string ToString()
        {
            return string.Format("{0}:{1:D2}:{2:D2} {3}", ((hour == 0 || hour == 12) ? 12 : hour % 12), minute, second, (hour < 12 ? "AM" : "PM"));
        }
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = ((value >= 0 && value < 24) ? value : 0);
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = ((value >= 0 && value < 60) ? value : 0);
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                second = ((value >= 0 && value < 60) ? value : 0);
            }
        }
    }
}
