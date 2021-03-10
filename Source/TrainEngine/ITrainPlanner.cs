using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITrainPlanner
    {
        public List<TrainInfo> TrainInfos { get; set; }
        ITrainPlanner FollowSchedule();
        ITrainPlanner LevelCrossing();
        ITrainPlanner CloseAt();
        ITrainPlanner OpenAt();
        ITrainPlanner SetSwitch();
        ITrainPlanner StartTrainAt();
        ITrainPlanner StopTrainAt();
        ITrainPlanner ToPlan();
        void Start();
    }
}
