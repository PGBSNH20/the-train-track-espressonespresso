using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITrainPlanner
    {
        ITrainPlanner FollowSchedule();
        ITrainPlanner LevelCrossing();
        ITrainPlanner CloseAt();
        ITrainPlanner OpenAt();
        ITrainPlanner SetSwitch(SwitchModel switch1, SwitchDirection switchDirection);
        ITrainPlanner StartTrainAt();
        ITrainPlanner StopTrainAt();
        ITrainPlanner ToPlan();
    }
}
