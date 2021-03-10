﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace TrainEngine
{
    public class TrainInfo 
    {
        public int Id;
        public string Name;
        public int Speed;
        public bool Operated;
        public string ArrivalTime;
        public string DepartureTime;
        public int StationId;
    }

    public class TrainPlanner : ITrainPlanner
    {
        public Train TrainName { get; set; }
        public List<TrainInfo> TrainInfos { get; set; }

        public List<ITrain> trainList = new List<ITrain>();
        public List<TimeTable> timeTableList = new List<TimeTable>();
        private List<TrainInfo> _trainInfos = new List<TrainInfo>();

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
            _trainInfos = trainList.Join(
                timeTableList, 
                Train => Train.Id , 
                TimeTable => TimeTable.TrainId, 
                (Train, TimeTable) => new TrainInfo{ 
                    Id = Train.Id, 
                    Name = Train.Name, 
                    Speed = Train.MaxSpeed,
                    Operated = Train.Operated,
                    ArrivalTime = TimeTable.ArrivalTime,
                    DepartureTime = TimeTable.DepartureTime,
                    StationId = TimeTable.StationId
                }
                ).OrderBy(t => t.DepartureTime).ToList();

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
    }
}
