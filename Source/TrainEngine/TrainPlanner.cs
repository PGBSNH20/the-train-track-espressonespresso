using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace TrainEngine
{
    public class TrainPlanner : ITrainPlanner
    {
        public Train TrainName { get; set; }
        public List<ITrain> trainList = new List<ITrain>();
        public List<TimeTable> timeTableList = new List<TimeTable>();

        public TrainPlanner(ITrain trainName)
        {
            trainList.Add(trainName);
        }
        public ITrainPlanner CloseAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner FollowSchedule(TimeTable timeTable)
        {
            timeTableList = TimeTable.CsvReader();
            var query = trainList.Join(
                timeTableList, 
                Train => Train.Id , 
                TimeTable => TimeTable.TrainId, 
                (Train, TimeTable) => new { 
                    trainId = Train.Id, 
                    trainName = Train.Name, 
                    trainSpeed = Train.MaxSpeed,
                    trainOperated = Train.Operated,
                    trainArrival = TimeTable.ArrivalTime,
                    trainDeparture = TimeTable.DepartureTime,
                    trainStationId = TimeTable.StationId
                }
                );
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

            return this;
        }
    }
}
