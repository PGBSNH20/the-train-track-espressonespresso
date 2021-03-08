using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITrackPlanner
    {
        ITrackPlanner FollowSchedule();
        ITrackPlanner LevelCrossing();
        ITrackPlanner CloseAt();
        ITrackPlanner OpenAt();
        ITrackPlanner SetSwitch();
        ITrackPlanner StartTrainAt();
        ITrackPlanner StopTrainAt();
        ITrackPlanner ToPlan();
    }
}
