using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainEngine;
using System.Threading;

namespace TrainConsole
{

    class Program
    {

        static List<TimeTable> timeTable = new List<TimeTable>();
        public static Clock clock = new Clock(24, 05);
        static void Main(string[] args)
        {
            Time();

            Console.WriteLine(clock.TimeDisplay());

            Thread.Sleep(6000);

            Console.WriteLine(clock.TimeDisplay());


            Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)
            //var test = new TrainPlanner().FollowSchedule("").LevelCrossing().CloseAt("").OpenAt("").SetSwitch().ToPlan();

            //Kio:
            //var test = new TrainPlaner().FollowSchedule("").LevelCrossing().CloseAt("").OpenAt("").SetSwitch().ToPlan();
            //var test = new TrainPlanner("");

            //test.GetTrainInfo();

            // Step 2:
            // Make the trains run in treads
        }

        static async void Time()
        {
            while (true)
            {
                clock.ClockIsTicking();
                await Task.Delay(1000);
            }
        }
    }
}
