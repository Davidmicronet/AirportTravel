using BLL;
using DTO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication.Models
{
    public class TripPath
    {
        public int ID { get; set; }
        [Display(Name = "Destination")]
        public int DestinationAirport { get; set; }
        [Display(Name = "Départ")]
        public int DepartureAirport { get; set; }
        [Display(Name = "CompagnieAvion")]
        public int Airplane { get; set; }
        [Display(Name = "Durée de vol")]
        public double FlightTime { get; set; }
        [Display(Name = "Distance")]
        public double Distance { get; set; }
        public IEnumerable<SelectListItem> airportitems { get; set; }
        public IEnumerable<SelectListItem> airplanetitems { get; set; }
    }
    public class TripPathData
    {
        public List<TripPath> getAllrecordTripPath()
        {
            List<TripPath> result = new List<TripPath>();
            List<TraveltriprecordDTO> list = TravelTripManager.LoadDataTraveltrip();
            foreach (var p in list)
            {
                TripPath tripath = new TripPath();
                tripath.DepartureAirport = p.DepartureAirportId;
                tripath.DestinationAirport = p.ArrivalAirportId;
                result.Add(tripath);
            }
            return result;
        }


        public void SaveDataTraveltrip(TripPath tripath)
        {
            TraveltriprecordDTO record = new TraveltriprecordDTO();
            record.DepartureAirportId = tripath.DepartureAirport;
            record.ArrivalAirportId = tripath.DestinationAirport;
            record.CustomerName = "exercice";

            TravelTripManager.SaveDataTraveltrip(record, tripath.Airplane);
        }
      
    }


   






}