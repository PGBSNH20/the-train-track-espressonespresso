using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace TrainEngine
{
    public class Station
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public string EndStation { get; set; }

        [Ignore] // Tell CSVHelper to ignore this prop when mapping.
        public bool Occupied { get; set; }

        public static List<Station> CsvReader()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = "|" };
            using var reader = new StreamReader(@"Data\stations.txt");
            using var csv = new CsvReader(reader, config);
            return csv.GetRecords<Station>().ToList();
        }

        public static List<Station> StationsList = new List<Station>(); // Needs access everywhere.


        private static readonly object MyLocker = new object(); // Object to use

        //Two methods for getting list information. By using these methods instead of the list directly, we don't have to worry about deadlocks.
        //public static Station ReturnAllStations()
        //{
        //    return StationsList.All()
        //}

        public static List<Station> AllStations()
        {
            lock (MyLocker)
            {
                return StationsList;
            }
        }
        public static Station FindStation(string stationName)
        {
            lock (MyLocker)
            {
                return StationsList.Find(a => a.StationName == stationName);
            }
        }

        public static bool Occupy(string stationName, bool isOccupied)
        {
            lock (MyLocker)
            {
                return StationsList.Find(a => a.StationName == stationName).Occupied = isOccupied;
            }
        }
    }
}
