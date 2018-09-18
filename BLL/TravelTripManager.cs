using System;
using System.Collections.Generic;
using System.Text;
using DALCodeFirstEF;
using System.Collections.Generic;
using DTO;
using System.Device.Location;

namespace BLL
{
    public static class TravelTripManager
    {
            public static List<TraveltriprecordDTO> LoadDataTraveltrip()
            {
                return new TravelTripRepository().LoadDataTraveltriprecord();
            }

        public static void SaveDataTraveltrip(TraveltriprecordDTO record, int airplane)
        {
            TravelTripRepository repos = new TravelTripRepository();

            GeoCoordinate depart = repos.getGPS(record.DepartureAirportId);
            GeoCoordinate arrival = repos.getGPS(record.ArrivalAirportId);
            double distance = arrival.GetDistanceTo(depart);
            record.Distance = distance;
            float[] flightTime = repos.getFuelAndEffort(airplane);

            record.FlightTime = flightTime[0] + flightTime[1];

            repos.SaveDataTraveltriprecord(record);
        }

        

    }
}