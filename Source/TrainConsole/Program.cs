using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TrainEngine;

namespace TrainConsole
{

    class Program
    {

        static List<TimeTable> timeTable = new List<TimeTable>();

        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)

            //Kio:
            //var travelPlan1 = new TrainPlaner(train1).FollowSchedule(scheduleTrain1).LevelCrossing().CloseAt("10:23").OpenAt("10:25").SetSwitch(switch1, SwitchDirection.Left).SetSwitch(switch2, SwitchDirection.Right).ToPlan();

            //var travelPlan2 = new TrainPlaner(train2).StartTrainAt("10:23").StopTrainAt("10:53").ToPlan();

            


            var trainList = new List<Train>();

            var train = new Train();

            trainList = train.GetTrainInfo();


            foreach (var trainElement in trainList)
            {
                var train1 = new Train
                {
                    Id = trainElement.Id,
                    Name = trainElement.Name,
                    MaxSpeed = trainElement.MaxSpeed,
                    Operated = trainElement.Operated,
                };

                if(train1.Id == 1)
                {
                    var travelplan1 = new TrainPlanner(train1);
                }

            }

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
         
    }
}
