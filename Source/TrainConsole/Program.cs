using System;
using System.Collections.Generic;
using TrainEngine;

namespace TrainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)
            var test = new TrainPlaner().FollowSchedule("").LevelCrossing().CloseAt("").OpenAt("").SetSwitch().ToPlan();

            // Step 2:
            // Make the trains run in treads

        }
    }
}
