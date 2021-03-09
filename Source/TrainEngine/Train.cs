using System;
using System.Collections.Generic;
using System.IO;

namespace TrainEngine
{
    public class Train : ITrain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public bool Operated { get; set; }
        public List<Train> GetTrainInfo()
        {
            var trainList = new List<Train>();

            string[] lines = File.ReadAllLines(@"Data\trains.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(',');
                if (i != 0)
                {
                    var trainModel = new Train
                    {
                        Id = Convert.ToInt32(split[0]),
                        Name = split[1],
                        MaxSpeed = Convert.ToInt32(split[2]),
                        Operated = Convert.ToBoolean(split[3])
                    };
                    trainList.Add(trainModel);
                }

            }
            return trainList;
        }
    }


}
