using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALCodeFirstEF
{
    public class TravelAirportContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Traveltriprecord> Traveltriprecords { get; set; }
    }
}
