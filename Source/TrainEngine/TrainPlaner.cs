using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class TrainPlaner : ITrainPlaner
    {
        Train train = new Train();
        //string[] line = s.split(',');



        public TrainPlaner(string train)
        {
            

        }
        public ITrainPlaner CloseAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlaner FollowSchedule()
        {
            throw new NotImplementedException();
        }

        public ITrainPlaner LevelCrossing()
        {
            throw new NotImplementedException();
        }

        public ITrainPlaner OpenAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlaner SetSwitch()
        {
            throw new NotImplementedException();
        }

        public ITrainPlaner StartTrainAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlaner StopTrainAt()
        {
            throw new NotImplementedException();
        }

        public ITrainPlaner ToPlan()
        {
            throw new NotImplementedException();
        }
    }
}
