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
        static List<TimeTable> timeTable = new List<TimeTable>();
        public static Clock clock = new Clock(9, 55);
        static void Main(string[] args)
        {
            Time(); // Start clock

            Console.WriteLine("Train track!");
            //GetPropertyValues(clock);

            var train1 = new TrainPlanner(new Train(2, "Liams tåg", 9000, true)).FollowSchedule().ToPlan();
            var train2 = new TrainPlanner(new Train(3, "Kios tåg", 3, true)).FollowSchedule().ToPlan();

            var thread = new Thread(() => train1.Start());
            var thread2 = new Thread(() => train2.Start());

            thread.Start();
            thread2.Start();

            //foreach (var item in train2.TrainInfos)
            //{
            //    Console.WriteLine(item.Name + " " + item.DepartureTime);
            //}

            //var train1 = new Train
            //{
            //    Id = trainList[0].Id,
            //    Name = trainList[0].Name,
            //    MaxSpeed = trainList[0].MaxSpeed,
            //    Operated = trainList[0].Operated,
            //};

            //var travelplan1 = new TrainPlanner(train1);

            // Step 2:
            // Make the trains run in treads
        }

        static async void Time()
        {
            while (true)
            {
                clock.ClockIsTicking();
                Console.WriteLine(Clock.TimeDisplay());
                await Task.Delay(1000);
            }
        }
    }
}
