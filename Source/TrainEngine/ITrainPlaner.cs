using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITrainPlaner
    {
        ITrainPlaner FollowSchedule();
        ITrainPlaner LevelCrossing();
        ITrainPlaner CloseAt();
        ITrainPlaner OpenAt();
        ITrainPlaner SetSwitch();
        ITrainPlaner StartTrainAt();
        ITrainPlaner StopTrainAt();
        ITrainPlaner ToPlan();
    }
}
