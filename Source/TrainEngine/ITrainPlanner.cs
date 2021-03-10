using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITrainPlanner
    {
        ITrainPlanner FollowSchedule(TimeTable timeTable);
        ITrainPlanner LevelCrossing();
        ITrainPlanner CloseAt();
        ITrainPlanner OpenAt();
        ITrainPlanner SetSwitch();
        ITrainPlanner StartTrainAt();
        ITrainPlanner StopTrainAt();
        ITrainPlanner ToPlan();
    }
}
