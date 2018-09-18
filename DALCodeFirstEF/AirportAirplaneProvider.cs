using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALCodeFirstEF
{
   public class AirportAirplaneProvider
    {
        public List<AirportDTO> LoadDataAirport()
        {
            List<AirportDTO> list = new List<AirportDTO>();

            using (var db = new TravelAirportContext())
            {
                var query = from b in db.Airports
                            orderby b.Name
                            select b;
                foreach (var item in query)
                {
                    AirportDTO p = new AirportDTO();
                    p.Name = item.Name;
                    p.GPS = item.GPS;
                    p.listAirplane = new List<AirplaneDTO>();
                    foreach (var airplaneitem in item.Airplanes)
                    {
                        AirplaneDTO airplane = new AirplaneDTO();
                        airplane.AirplaneId = airplaneitem.AirplaneId;
                        airplane.FuelConsumption = airplaneitem.FuelConsumption;
                        airplane.TakeoffEffort = airplaneitem.TakeoffEffort;
                        airplane.Title = airplaneitem.Title;
                        p.listAirplane.Add(airplane);
                    }
                    list.Add(p);
                }
            }

            return list;
        }
        public List<AirplaneDTO> LoadDataAirplane()
        {
            List<AirplaneDTO> list = new List<AirplaneDTO>();

            using (var db = new TravelAirportContext())
            {
                var query = from b in db.Airplanes
                            orderby b.Title
                            select b;
                foreach (var item in query)
                {
                    AirplaneDTO p = new AirplaneDTO();
                    p.Title = item.Title;
                    p.TakeoffEffort = item.TakeoffEffort;
                    p.FuelConsumption = item.FuelConsumption;
                    list.Add(p);
                }
            }

            return list;
        }

    }
}
