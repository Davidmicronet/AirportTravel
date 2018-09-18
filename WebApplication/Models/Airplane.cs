using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Airplane
    {
        public int AirplaneId { get; set; }
        public string Title { get; set; }
        public float TakeoffEffort { get; set; }
        public float FuelConsumption { get; set; }
    }

    public class AirplaneData
    {
        public List<Airplane> getAllAirplane()
        {
            List<Airplane> result = new List<Airplane>();
            List<AirplaneDTO> list = AirportAirplaneManager.LoadDataAirplane();
            foreach (var p in list)
            {
                Airplane airplane = new Airplane();
                airplane.AirplaneId = p.AirplaneId;
                airplane.Title = p.Title;
                result.Add(airplane);
            }
            return result;
        }
    }

    }