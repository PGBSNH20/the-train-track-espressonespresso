using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TrainEngine
{
    public enum SwitchDirection
    {
        Left,
        Right
    }
    public class SwitchModel

    {
        public void GetTrainTrackInfo()
        {
            var trainList = new List<Train>();

            string[] lines = File.ReadAllLines(@"Data\traintrack.txt");

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
        }
    }
}
