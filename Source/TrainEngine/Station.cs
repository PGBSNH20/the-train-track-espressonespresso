using System;
using System.IO;
using System.Linq;

namespace TrainEngine
{
    public class Station
    {
        public int StationId { get; set; }
        public string StationName { get; set; }
        public string EndStation { get; set; }

        public void ReadStations()
        {
            var lines = File.ReadAllLines("Data/stations.txt");
            foreach (var line in lines.Skip(1))
            {
                var split = line.Split('|');
                StationId = Convert.ToInt32(split[0]);
                StationName = split[1];
                EndStation = split[2];
            }
        }
    }
}
