using System;
using System.IO;

namespace TrainEngine
{
    public class Station
    {
        public int StationId { get; set; }
        public string StationName { get; set; }
        public string EndStation { get; set; }

        //var fileStream = new FileStream("", FileMode.Open);

        public static void ReadStations()
        {
            var lines = File.ReadAllLines("Data/stations.txt");
            var csv = from line in lines
                      select (line.Split(',')).ToArray();

            var csv = lines.

            csv[0] = StationId;
            csv[1] = StationName;
            csv[2] = EndStation;
        }

       

    }
}
