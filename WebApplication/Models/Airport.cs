using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public GeoCoordinate GPS { get; set; }
    }

    public class AirportData
    {
        public List<Airport> getAllAirport()
        {
            List<Airport> result = new List<Airport>();
            List<AirportDTO> list = AirportAirplaneManager.LoadDataAirport();
            foreach (var p in list)
            {
                Airport airport = new Airport();
                airport.AirportId = p.AirportId;
                airport.Name = p.Name;
                result.Add(airport);
            }
            return result;
        }
    }
}