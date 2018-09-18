using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALCodeFirstEF
{
    public class Airplane
    {
        public int AirplaneId { get; set; }
        public string Title { get; set; }
        public float TakeoffEffort { get; set; }
        public float FuelConsumption { get; set; }

        public int AirportId { get; set; }
        public virtual Airport Airport { get; set; }
    }
}
