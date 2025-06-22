using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using u23614286_HW01_INF272.Models;

namespace u23614286_HW01_INF272.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View(ServiceRepository.Services);
        }

        public ActionResult Bookings(int id)
        {
            //store selected service id
            ViewBag.ServiceID = id;

            //choosing compatible vehicles
            List<Vehicle> vehicles = VehicleRepository.Vehicles
                .Where(v => v.ServiceID == id)
                .ToList();
            ViewBag.Vehicles = vehicles;

            //drivers who can drive the vehicles
            List<Driver> drivers = DriverRepository.Drivers
                .Where(d => d.ServiceID == id)
                .ToList();
            ViewBag.Drivers = drivers;

            //take down the booking reasons
            List<Reason> reasons = ReasonRepository.Reasons;
            ViewBag.Reasons = reasons;

            return View();
        }
        public ActionResult CreateBooking(Booking booking)
        {
            if (booking == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, "Booking not found.");
            }

            //going to generate a new unique booking id
            booking.BookingID = Guid.NewGuid();

            //record the date and time the booking was made
            booking.BookingDate = DateTime.Now;

            //add booking to static list
            BookingRepository.Bookings.Add(booking);

            //build view model for confirmation screen
            BookingConfirmedViewModel model = new BookingConfirmedViewModel
            {
                Booking = booking,
                Driver = DriverRepository.Drivers.FirstOrDefault(d => d.DriverID == booking.DriverID),
                Vehicle = VehicleRepository.Vehicles.FirstOrDefault(v => v.VehicleID == booking.VehicleID)
            };

            //in case of error, I will use blank/fallback data
            if (model.Driver == null)
            {
                model.Driver = new Driver
                {
                    FirstName = "",
                    LastName = "",
                    PhoneNumber = "",
                    ImagePath = "~/Images/Drivers/driver1.jpg"
                };
            }

            if (model.Vehicle == null)
            {
                model.Vehicle = new Vehicle
                {
                    Type = "Unknown",
                    RegistrationNumber = "Unknown",
                    ImagePath = "~/Images/Vehicles/ambulance.jpg"
                };
            }
            return View("BookingConfirmed", model);
        }
        public ActionResult BookingConfirmed(Guid id)
        {
            //locate booking using the ID
            Booking booking = BookingRepository.Bookings.FirstOrDefault(b => b.BookingID == id);

            if (booking == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Booking not found.");
            }

            //build confirmation view model
            BookingConfirmedViewModel model = new BookingConfirmedViewModel
            {
                Booking = booking,
                Driver = DriverRepository.Drivers.FirstOrDefault(d => d.DriverID == booking.DriverID),
                Vehicle = VehicleRepository.Vehicles.FirstOrDefault(v => v.VehicleID == booking.VehicleID)
            };

            //fallback for missing data
            if (model.Driver == null)
            {
                model.Driver = new Driver
                {
                    FirstName = "",
                    LastName = "",
                    PhoneNumber = "",
                    ImagePath = "~/Images/Drivers/driver1.jpg"
                };
            }

            if (model.Vehicle == null)
            {
                model.Vehicle = new Vehicle
                {
                    Type = "Unknown",
                    RegistrationNumber = "Unknown",
                    ImagePath = "~/Images/Vehicles/ambulance.jpg"
                };
            }

            return View("BookingConfirmed", model);
        }
        public ActionResult SOSBooking()
        {
            var random = new Random();

            // Select a random service
            var services = ServiceRepository.Services;
            var selectedService = services[random.Next(services.Count)];

            // Get compatible drivers and vehicles
            var drivers = DriverRepository.Drivers
                .Where(d => d.ServiceID == selectedService.ServiceID)
                .ToList();

            var vehicles = VehicleRepository.Vehicles
                .Where(v => v.ServiceID == selectedService.ServiceID)
                .ToList();

            // Randomly choose driver and vehicle
            var selectedDriver = drivers[random.Next(drivers.Count)];
            var selectedVehicle = vehicles[random.Next(vehicles.Count)];

            // Create the booking
            var booking = new Booking
            {
                BookingID = Guid.NewGuid(),
                FullName = "Unknown",
                Phone = "Unknown",
                PickupAddress = "Tracking S.O.S ping address",
                PickupTime = DateTime.Now,
                BookingDate = DateTime.Now,
                DriverID = selectedDriver.DriverID,
                VehicleID = selectedVehicle.VehicleID
            };

            BookingRepository.Bookings.Add(booking);

            var model = new BookingConfirmedViewModel
            {
                Booking = booking,
                Driver = selectedDriver,
                Vehicle = selectedVehicle
            };

            return View("BookingConfirmed", model);
        }
        public ActionResult RideHistory()
        {
            var history = BookingRepository.Bookings
                .Select(b => new RideHistoryViewModel
                {
                    Booking = b,
                    Driver = DriverRepository.Drivers
                                  .FirstOrDefault(d => d.DriverID == b.DriverID),
                    Vehicle = VehicleRepository.Vehicles
                                  .FirstOrDefault(v => v.VehicleID == b.VehicleID)
                })
                .OrderByDescending(h => h.Booking.BookingDate) 
                .ToList();

            return View(history);  
        }

        public ActionResult Manage()
        {
            var model = new VehicleDriverViewModel
            {
                Drivers = DriverRepository.Drivers,
                Vehicles = VehicleRepository.Vehicles
            };

            return View(model);
        }

    }
}