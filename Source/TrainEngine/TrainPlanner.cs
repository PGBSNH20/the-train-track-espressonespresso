using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TrainEngine
{
    public class TrainPlanner : ITrainPlanner
    {
        public Train TrainName { get; set; }
        public TrainPlanner(Train trainName)
        {
            TrainName = trainName;
            trainName.GetTrainInfo();
        }
        public ITrainPlanner CloseAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner FollowSchedule()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner LevelCrossing()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner OpenAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlanner SetSwitch(SwitchModel switch1, SwitchDirection switchDirection)
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
            throw new NotImplementedException();
        }
    }
}
