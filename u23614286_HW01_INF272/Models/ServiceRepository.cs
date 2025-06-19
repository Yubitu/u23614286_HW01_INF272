using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_HW01_INF272.Models
{
	public class ServiceRepository
	{
        public static List<Service> Services = new List<Service>
        {
            new Service {
                ServiceID = 1,
                Name = "ALS (Advanced Life Support)",
                Description = "ALS is used to transport critical patients in need of high-level care. Staffed by a Paramedic.",
                ImagePath = "~/Images/Services/advanced.png",
                Drivers = new List<Driver>(),
                Vehicles = new List<Vehicle>()
            },
            new Service {
                ServiceID = 2,
                Name = "BLS (Basic Life Support)",
                Description = "BLS is used to transport patients in non-life-threatening condition. Basic support only.",
                ImagePath = "~/Images/Services/basic.png",
                Drivers = new List<Driver>(),
                Vehicles = new List<Vehicle>()
            },
            new Service {
                ServiceID = 3,
                Name = "Patient Transport",
                Description = "The most basic type of transport for patients requiring ambulatory support to and from the hospital.",
                ImagePath = "~/Images/Services/ambulance.jpg",
                Drivers = new List<Driver>(),
                Vehicles = new List<Vehicle>()
            },
            new Service {
                ServiceID = 4,
                Name = "Medical Utility Vehicle",
                Description = "A small or large van designed to facilitate the movement and transport of patients.",
                ImagePath = "~/Images/Services/utility.png",
                Drivers = new List<Driver>(),
                Vehicles = new List<Vehicle>()
            },
            new Service {
                ServiceID = 5,
                Name = "Event Medical Ambulance",
                Description = "Ambulances that are stationed at events, like concerts, sport-games and festivals to provide medical assistance.",
                ImagePath = "~/Images/Services/event.jpg",
                Drivers = new List<Driver>(),
                Vehicles = new List<Vehicle>()
            },
            new Service {
                ServiceID = 6,
                Name = "Air Ambulance",
                Description = "An air ambulance is used in the transfer of patients across long distances in both emergency and non-emergency situations.",
                ImagePath = "~/Images/Services/air.jpg",
                Drivers = new List<Driver>(),
                Vehicles = new List<Vehicle>()
            }
        };
    }
}