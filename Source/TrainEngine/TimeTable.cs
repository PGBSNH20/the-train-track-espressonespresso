namespace TrainEngine
{
    public class TimeTable
    {
        public int TrainId { get ;set;}
        public int StationId { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }

        public TimeTable(int trainId, int stationId, string departureTime, string arrivalTime)
        {
            TrainId = trainId;
            StationId = stationId;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
        }

    }

}
