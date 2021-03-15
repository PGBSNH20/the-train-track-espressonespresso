using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace TrainEngine
{
    class DistanceInformation
    {
        public int Id { get; set; }
        public int DepartureStationId { get; set; }
        public int ArrivalStationId { get; set; }
        public int Distance { get; set; }

        public static List<DistanceInformation> CsvReader()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = "," };
            using var reader = new StreamReader(@"Data\traintrack.txt");
            using var csv = new CsvReader(reader, config);

            return csv.GetRecords<DistanceInformation>().ToList();
        }

        public static List<DistanceInformation> trainTrackList = new List<DistanceInformation>();

        internal static string DestinationDistance(TrainInfo departureStation, TrainInfo arrivalStation)
        {
            var distance = trainTrackList.Where(t => t.DepartureStationId == departureStation.StationId && t.ArrivalStationId == arrivalStation.StationId).Select(t => t.Distance).FirstOrDefault();

            return "Distance " + distance * 100 + " km";
        }
    }
}
