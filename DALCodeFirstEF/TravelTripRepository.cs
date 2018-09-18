using DTO;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALCodeFirstEF
{
    public class TravelTripRepository
    {
        public List<TraveltriprecordDTO> LoadDataTraveltriprecord()
        {
            List<TraveltriprecordDTO> list = new List<TraveltriprecordDTO>();

            using (var db = new TravelAirportContext())
            {
                var query = from b in db.Traveltriprecords
                            orderby b.CustomerName
                            select b;
                foreach (var item in query)
                {
                    TraveltriprecordDTO p = new TraveltriprecordDTO();
                    p.CustomerName = item.CustomerName;
                    p.DepartureAirportId = item.DepartureAirportId;
                    p.Distance = item.Distance;
                    p.ArrivalAirportId = item.ArrivalAirportId;
                    p.FlightTime = item.FlightTime;
                    list.Add(p);
                }
            }
            return list;
        }

        public void SaveDataTraveltriprecord(TraveltriprecordDTO travel)
        {
            using (var db = new TravelAirportContext())
            {
                var traveltriprecord = new Traveltriprecord { TraveltriprecordId = 5, CustomerName = travel.CustomerName, ArrivalAirportId = travel.ArrivalAirportId, DepartureAirportId = travel.DepartureAirportId, Distance = travel.Distance, FlightTime = travel.FlightTime };
                db.SaveChanges();
            }
        }

        public GeoCoordinate getGPS(int airport)
        {
            GeoCoordinate gpscoord = new GeoCoordinate();

            using (var db = new TravelAirportContext())
            {
                var query = from b in db.Airports
                            where b.AirportId == airport
                            select b.GPS;
                gpscoord = query.First();
            }
            return gpscoord;
        }
   
        public float[] getFuelAndEffort(int airplaine)
        {
            float[] flightTime = new float[2];
            using (var db = new TravelAirportContext())
            {
                var fuel = from b in db.Airplanes
                            where b.AirplaneId == airplaine
                            select b.FuelConsumption;
                var effort = from b in db.Airplanes
                           where b.AirplaneId == airplaine
                           select b.TakeoffEffort;

                flightTime[0] = effort.First();
                flightTime[1] = fuel.First();
            }
            return flightTime;

        }

    }
}
