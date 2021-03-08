using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class TrainPlanner : ITrainPlanner
    {
        

        public void GetTrainInfo()
        {
            var trainList = new List<Train>();

            string[] lines = System.IO.File.ReadAllLines("trains.txt");

            foreach (var line in lines)
            {
                string[] split = line.Split(',');

                var trainModel = new Train
                {
                    //Föröska få in HH:MM i Start och EndTime propsen.
                    Id = Convert.ToInt32(split[0]),
                    Name = split[1],
                    MaxSpeed = Convert.ToInt32(split[2]),
                    Operated = Convert.ToBoolean(split[3])
                };
                trainList.Add(trainModel);
            }


        }

        public TrainPlanner(string train)
        {
            

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
            throw new NotImplementedException();
        }
    }
}
