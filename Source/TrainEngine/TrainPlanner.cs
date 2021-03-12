using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TrainEngine
{
    public class TrainInfo // TrainInfo is a combination of Train and TimeTable class. It is used in the join query to create a list of type TrainInfo.
    {
        public string Name;
        public string StationName;
        public string EndStation;
        public int Speed;
        public bool Operated;
        public string ArrivalTime;
        public string DepartureTime;
        public int StationId;
    }

    public class TrainPlanner : ITrainPlanner
    {
        public List<TrainInfo> TrainInfos { get; set; }

        private readonly List<ITrain> _trainList = new List<ITrain>();
        private List<TimeTable> _timeTableList = new List<TimeTable>();
        private List<TrainInfo> _trainInfos = new List<TrainInfo>();

        public TrainPlanner(ITrain trainName)
        {
            _trainList.Add(trainName);
        }
        public ITrainPlanner CloseAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner FollowSchedule()
        {
            _timeTableList = TimeTable.CsvReader();
            Station.StationsList = Station.CsvReader();

            //Join the lists and create a TrainInfo object. Then convert to list and add to trainInfo list.
            var query =
                from train in _trainList
                join time in _timeTableList on train.Id equals time.TrainId
                join station in Station.StationsList on time.StationId equals station.Id
                orderby time.DepartureTime
                select new TrainInfo()
                {
                    Name = train.Name,
                    Speed = train.MaxSpeed,
                    Operated = train.Operated,
                    ArrivalTime = time.ArrivalTime,
                    DepartureTime = time.DepartureTime,
                    StationName = station.StationName,
                    EndStation = station.EndStation,
                    StationId = station.Id
                };

            _trainInfos = query.ToList();

            return this;
        }

        public ITrainPlanner LevelCrossing()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner OpenAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner SetSwitch()
        {

            throw new NotImplementedException();
        }

        public ITrainPlanner StartTrainAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner StopTrainAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner ToPlan()
        {
            TrainInfos = _trainInfos;
            return this;
        }
        public void Start() // Possible deadlock scenario here, do not not not not let the threads use the list at same time at the moment.
        {
            //Set the starting station to occupied.
            Station.Occupy(TrainInfos[0].StationName, true);
            // Output the starting location.
            Console.WriteLine($"[{TrainInfos[0].Name}] Starting at {TrainInfos[0].StationName}. Leaving for {TrainInfos[1].StationName} at {TrainInfos[0].DepartureTime}");
            //Loop over the TrainInfo list and compare with the static stationList. We will use the stationlist to set occupy to true and false.
            for (int i = 0; i < TrainInfos.Count - 1; i++)
            {
                while (Clock.TimeDisplay() != TrainInfos[i].DepartureTime) // While clock is not departure time for the current thread, sleep for 1 second.
                    Thread.Sleep(1000);

                if (Clock.TimeDisplay() == TrainInfos[i].DepartureTime) // If the time is equal to departure time, set occupy in list for the current station to false and output.
                    Station.Occupy(TrainInfos[i].StationName, false);
                Console.WriteLine($"[{TrainInfos[i].Name}@{TrainInfos[i].StationName}] Leaving for {TrainInfos[i + 1].StationName}");

                while (Clock.TimeDisplay() != TrainInfos[i].ArrivalTime) // While clock is not arrival time for the current thread, sleep for 1 second.
                    Thread.Sleep(1000);

                if (Clock.TimeDisplay() == TrainInfos[i].ArrivalTime) // If the time is equal to arrival time, check if the current station is occupied. If true, output information.
                {
                    if (Station.FindStation(TrainInfos[i + 1].StationName).Occupied)
                    {
                        Console.WriteLine($"[{TrainInfos[i].Name}@Railway] Station is occupied, waiting for train at {TrainInfos[i + 1].StationName} to leave.");
                    }
                    while (Station.FindStation(TrainInfos[i + 1].StationName).Occupied) // While station is occupied, sleep for 3 seconds.
                    {
                        Thread.Sleep(3000);
                    }
                    // Occupy the new station
                    Station.Occupy(TrainInfos[i + 1].StationName, true); // Find the index in stationList using the stationname from traininfos. 
                    Console.WriteLine($"[{TrainInfos[i].Name}@{TrainInfos[i + 1].StationName}] Arrived to {TrainInfos[i + 1].StationName}");
                }
            }
        }

    }
}
