using CsvHelper;
using CsvHelper.Configuration;
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

        public static List<Station> CsvReader()
        {
            var list = new List<Station>();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = "|"
            };
            using (var reader = new StreamReader(@"Data\stations.txt"))
            using (var csv = new CsvReader(reader, config))
            {
                foreach (var item in csv.GetRecords<Station>())
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
