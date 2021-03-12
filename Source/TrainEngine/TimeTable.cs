using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace TrainEngine
{
    public class TimeTable
    {
        public int TrainId { get ;set;}
        public int StationId { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        
        public static List<TimeTable> CsvReader()
        {
            using var reader = new StreamReader(@"Data\timetable.txt");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<TimeTable>().ToList();
        }
    }

}
