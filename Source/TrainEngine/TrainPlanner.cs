using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;

namespace TrainEngine
{
    public class TrainInfo
    {
        public int Id;
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
        //public Clock Clock { get; set; }
        public Train TrainName { get; set; }
        public List<TrainInfo> TrainInfos { get; set; }

        public List<ITrain> trainList = new List<ITrain>();
        public List<TimeTable> timeTableList = new List<TimeTable>();
        private List<TrainInfo> _trainInfos = new List<TrainInfo>();
        private List<Station> stationsList = new List<Station>();

        public TrainPlanner(ITrain trainName)
        {
            trainList.Add(trainName);
        }
        public ITrainPlanner CloseAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner FollowSchedule()
        {
            timeTableList = TimeTable.CsvReader();
            stationsList = Station.CsvReader();

            //Join the lists and create a TrainInfo object. Then convert to list and add to trainInfo list.
            var s =
                from train in trainList
                join time in timeTableList on train.Id equals time.TrainId
                join station in stationsList on time.StationId equals station.Id
                orderby time.DepartureTime
                select new TrainInfo()
                {
                    Name = train.Name,
                    Speed = train.MaxSpeed,
                    Operated = train.Operated,
                    ArrivalTime = time.ArrivalTime,
                    DepartureTime = time.DepartureTime,
                    StationName = station.StationName,
                    EndStation = station.EndStation

                };

            _trainInfos = s.ToList();

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
        public void Start()
        {

            //Better code, still not optimal though.

            Console.WriteLine($"[{TrainInfos[0].Name}] Starting at {TrainInfos[0].StationName}. Leaving for {TrainInfos[1].StationName} at {TrainInfos[0].DepartureTime}");

            for (int i = 0; i < TrainInfos.Count - 1; i++)
            {
                while (Clock.TimeDisplay() != TrainInfos[i].DepartureTime)
                    Thread.Sleep(1000);
                if (Clock.TimeDisplay() == TrainInfos[i].DepartureTime)
                    Console.WriteLine($"[{TrainInfos[i].Name}] Leaving for {TrainInfos[i + 1].StationName}");
                while (Clock.TimeDisplay() != TrainInfos[i].ArrivalTime)
                    Thread.Sleep(1000);
                if (Clock.TimeDisplay() == TrainInfos[i].ArrivalTime)
                    Console.WriteLine($"[{TrainInfos[i].Name}] Arrived to {TrainInfos[i + 1].StationName}");
            }
        }

    }
}
