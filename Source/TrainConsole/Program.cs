using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using TrainEngine;
using System.Threading;
using System.Reflection;

namespace TrainConsole
{

    class Program
    {
        public static Clock Clock = new(9, 55);
        static void Main(string[] args)
        {
            Time(); // Start clock

            Console.WriteLine("Train track!");

            var train1 = new TrainPlanner(new Train(2, "Liams tåg", 9000, true)).FollowSchedule().ToPlan();
            var train2 = new TrainPlanner(new Train(3, "Kios tåg", 3, true)).FollowSchedule().ToPlan();

            var thread = new Thread(() => train1.Start());
            var thread2 = new Thread(() => train2.Start());

            thread.Start();
            thread2.Start();
        }

        private static async void Time()
        {
            while (true)
            {
                Clock.ClockIsTicking();
                Console.WriteLine(Clock.TimeDisplay());
                await Task.Delay(1000);
            }
        }
    }
}
