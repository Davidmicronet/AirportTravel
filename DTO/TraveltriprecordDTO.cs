using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TraveltriprecordDTO
    {
        public int TraveltriprecordId { get; set; }
        public string CustomerName { get; set; }
        public int DepartureAirportId { get; set; }
        public int ArrivalAirportId { get; set; }
        public double Distance { get; set; }
        public double FlightTime { get; set; }
    }
}
