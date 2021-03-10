using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace TrainEngine
{
    public class TimeTable
    {
        public int TrainId { get ;set;}
        public int StationId { get; set; }
        public int DepartureTime { get; set; }
        public int ArrivalTime { get; set; }
        
        public static List<TimeTable> CsvReader()
        {
            var list = new List<TimeTable>();
            using (var reader = new StreamReader(@"Data\timetable.txt"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                foreach (var item in csv.GetRecords<TimeTable>())
                {
                    list.Add(item);
                }
            }
            return list;
        }
        //public TimeTable(int trainId, int stationId, string departureTime, string arrivalTime)
        //{
        //    TrainId = trainId;
        //    StationId = stationId;
        //    DepartureTime = departureTime;
        //    ArrivalTime = arrivalTime;
        //}

    }

}
