using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALCodeFirstEF
{
    public class Traveltriprecord
    {
        public int TraveltriprecordId { get; set; }
        public string CustomerName { get; set; }
        public int DepartureAirportId { get; set; }
        public int ArrivalAirportId { get; set; }
        public double Distance { get; set; }
        public double FlightTime { get; set; }
    }
}
