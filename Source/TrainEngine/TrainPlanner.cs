using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

        public TimeTable FollowSchedule(TimeTable timeTable)
        {
            timeTableList.Add(timeTable);
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
