using System;
using System.Collections.Generic;
using System.Device.Location;

namespace DTO
{
    public class AirportDTO
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public GeoCoordinate GPS { get; set; }
        public List<AirplaneDTO> listAirplane { get; set; }
    }
    

}
