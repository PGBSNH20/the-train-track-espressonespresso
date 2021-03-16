using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TrainEngine
{

    public class TrainInfo // TrainInfo is a combination of Train and TimeTable class. It is used in the join query to create a list of type TrainInfo.
    {
        public string Name;
        public string StationName;
        public string EndStation;
        public int Speed;
        public bool Operated;
        public string ArrivalTime;
        public string DepartureTime;
        public int StationId;
        public int Distance;
    }
}
