using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.IO;

namespace u23614286_HW01_INF272.Models
{
	public class VehicleRepository
	{
		public static List<Vehicle> Vehicles = new List<Vehicle>()
		{
			new Vehicle
			{
				VehicleID = 1,
				Type = "ALS Ambulance",
				RegistrationNumber = "ALSXA1103",
				ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Vehicles/vehicle1.jpg"),
				ServiceID = 1
			},
            new Vehicle {
                VehicleID = 2,
                Type = "BLS Ambulance",
                RegistrationNumber = "BLSXA3103",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Vehicles/vehicle2.jpg"),
                ServiceID = 2
            },
            new Vehicle {
                VehicleID = 3,
                Type = "Patient Transport",
                RegistrationNumber = "SPTXA5506",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Vehicles/vehicle3.jpg"),
                ServiceID = 3
            },
            new Vehicle {
                VehicleID = 4,
                Type = "Utility Vehicle",
                RegistrationNumber = "ULVXA2200",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Vehicles/vehicle4.png"),
                ServiceID = 4
            },
            new Vehicle {
                VehicleID = 5,
                Type = "Event Ambulance",
                RegistrationNumber = "EVTXA7040",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Vehicles/vehicle5.jpg"),
                ServiceID = 5
            },
            new Vehicle {
                VehicleID = 6,
                Type = "Air Ambulance",
                RegistrationNumber = "AIRXA3999",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Vehicles/vehicle6.jpg"),
                ServiceID = 6
            },
        };
        public static class ImageHelper
        {
            public static string ImageToBase64(string relativePath)
            {
                var absolutePath = HostingEnvironment.MapPath(relativePath);
                if (absolutePath == null || !File.Exists(absolutePath))
                    return null;

                byte[] imageBytes = File.ReadAllBytes(absolutePath);
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}