using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class Clock
    {
        public static int Hours { get; set; }
        public static int Minutes { get; set; }
        public Clock(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;

            CheckingTimeFormat();
        }

        public void CheckingTimeFormat()
        {
            if (Minutes == 60)
            {
                Hours++;
                Minutes = 0;
            }

            if (Hours == 24)
            {
                Hours = 0;
            }
        }

        public void ClockIsTicking()
        {
            Minutes++;

            CheckingTimeFormat();
        }

        public static string TimeDisplay()
        {
            // Convert to string with D2 format, just to get the '00' at the beginning, so that it can represent a digital watch. 
            return Hours.ToString("D2") + ":" + Minutes.ToString("D2");
        }

    }
}
