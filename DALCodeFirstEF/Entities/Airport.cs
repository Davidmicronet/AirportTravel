using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALCodeFirstEF
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public GeoCoordinate GPS { get; set; }

        public virtual List<Airplane> Airplanes { get; set; }
    }
}
