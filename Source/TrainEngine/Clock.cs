using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class Clock
    {
        public static int Hours { get; set; }
        public int Minutes { get; set; }
        public Clock(int hours, int minutes)
        {
            Hours = hours;
            this.Minutes = minutes;

            this.CheckingTimeFormat();
        }

        public void CheckingTimeFormat()
        {
            if (this.Minutes == 60)
            {
                Hours++;
                this.Minutes = 0;
            }

            if (Hours == 24)
            {
                Hours = 0;
            }
        }

        public void ClockIsTicking()
        {
            this.Minutes++;

            CheckingTimeFormat();
        }

        public string TimeDisplay()
        {
            // Convert to string with D2 format, just to get the '00' at the beginning, so that it can represent a digital watch. 
            return Hours.ToString("D2")  + ":" + this.Minutes.ToString("D2");
        }

        public static int GetHour() => Hours;

    }
}
