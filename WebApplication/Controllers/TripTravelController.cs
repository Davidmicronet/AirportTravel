using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class TripTravelController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: TripTravel/ResumeDatas
        public ActionResult ResumeDatas()
        {
            TripPathData triptravel = new TripPathData();
            return View(triptravel.getAllrecordTripPath());
        }

        // nouveau vol qui a un aéroport de départ et un aéroport de destination
        public ActionResult Create()
        {
            AirportData airport = new AirportData();
            AirplaneData airplane = new AirplaneData();

            IEnumerable<SelectListItem> airportitems = airport.getAllAirport().Select(c => new SelectListItem
            {
                Value = c.AirportId.ToString(),
                Text = c.Name
            });
            IEnumerable<SelectListItem> airplaneitems = airplane.getAllAirplane().Select(c => new SelectListItem
            {
                Value = c.AirplaneId.ToString(),
                Text = c.Title
            });
            ViewBag.Airports = airportitems;
            ViewBag.Airplanes = airplaneitems;

            return View();
        }

        // POST: TripTravel/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "DestinationAirport,DepartureAirport,Airplane,ID")] TripPath tripPath)
        {
            if (ModelState.IsValid)
            {
                TripPathData triptravel = new TripPathData();
                triptravel.SaveDataTraveltrip(tripPath);


                return RedirectToAction("Index");
            }

            return View(tripPath);
        }
       
    }
}
