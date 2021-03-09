using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrainEngine;

namespace TrainConsole
{

    class Program
    {

        static List<TimeTable> timeTable = new List<TimeTable>();

        static void Main(string[] args)
        {

            var clock = new Clock(24, 01);

            for (int i = 0; i < 100; i++)
            {
                clock.ClockIsTicking();
                Console.WriteLine(clock.TimeDisplay());
            }


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
    }
}
