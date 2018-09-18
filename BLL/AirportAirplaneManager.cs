using DTO;
using DALCodeFirstEF;
using System;
using System.Collections.Generic;

namespace BLL
{
    public static class AirportAirplaneManager
    {

        public static List<AirportDTO> LoadDataAirport()
        {
            return new AirportAirplaneProvider().LoadDataAirport();
        }
        public static List<AirplaneDTO> LoadDataAirplane()
        {
            return new AirportAirplaneProvider().LoadDataAirplane();
        }
    }
}
