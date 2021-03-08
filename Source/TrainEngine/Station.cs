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

<<<<<<< HEAD
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
=======
        //var fileStream = new FileStream("", FileMode.Open);

        //public static void ReadStations()
        //{
        //    var lines = File.ReadAllLines("Data/stations.txt");
        //    var csv = from line in lines
        //              select (line.Split(',')).ToArray();

        //    var csv = lines.

        //    csv[0] = StationId;
        //    csv[1] = StationName;
        //    csv[2] = EndStation;
        //}

       

>>>>>>> f55ff18f65378ee446be5ae2aa5121242e5ea027
    }
}
