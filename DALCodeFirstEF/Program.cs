using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Data.Entity;

namespace DALCodeFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TravelAirportContext())
            {
                // Create and save a new Airport
                Console.Write("Enter a name for a new Airport: ");
                var name = Console.ReadLine();
                Console.Write("Enter a latitude for a new Airport: ");
                var latitude = Console.ReadLine();
                Console.Write("Enter a longitude for a new Airport: ");
                var longitude = Console.ReadLine();
                Console.Write("Enter a id for a new Airport: ");
                var idap = Console.ReadLine();

                var airport = new Airport { AirportId = int.Parse(idap), Name = name, GPS = new GeoCoordinate {Latitude = byte.Parse(latitude), Longitude = byte.Parse(longitude) } };
                db.Airports.Add(airport);
                db.SaveChanges();

                // Display all Airports from the database
                var query = from b in db.Airports
                            orderby b.Name
                            select b;

                Console.WriteLine("All airports in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
                
                // Create and save a new Airplane
                Console.Write("Enter a name for a new Airplane: ");
                var title = Console.ReadLine();
                Console.Write("Enter a latitude for a new Airplane: ");
                var takeoffEffort = Console.ReadLine();
                Console.Write("Enter a longitude for a new Airplane: ");
                var fuelConsumption = Console.ReadLine();
                Console.Write("Enter an id for a new Airplane: ");
                var idpl = Console.ReadLine();

                var airplane = new Airplane { AirplaneId = int.Parse(idpl), Title = title, TakeoffEffort = float.Parse(takeoffEffort), FuelConsumption = float.Parse(fuelConsumption) };
                db.Airplanes.Add(airplane);
                db.SaveChanges();

                // Display all Airports from the database
                var query2 = from b in db.Airplanes
                             orderby b.Title
                             select b;

                Console.WriteLine("All airplanes in the database:");
                foreach (var item in query2)
                {
                    Console.WriteLine(item.Title);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
       
    }
}
