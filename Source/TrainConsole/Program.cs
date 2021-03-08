using System;
using System.Collections.Generic;
using TrainEngine;

namespace TrainConsole
{
    public class TimeTable
    {

    }

    public class Passenger
    {

    }

    public class Station
    {

    }

    class Program
    {

        static List<TimeTable> timeTable = new List<TimeTable>();

        static void Main(string[] args)
        {
            Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)
            var test = new TrainPlaner().FollowSchedule("").LevelCrossing().CloseAt("").OpenAt("").SetSwitch().ToPlan();

            //Kio:
            //var test = new TrainPlaner().FollowSchedule("").LevelCrossing().CloseAt("").OpenAt("").SetSwitch().ToPlan();


            // Step 2:
            // Make the trains run in treads
        }
    }
}
