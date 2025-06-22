using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23614286_HW01_INF272.Models;

namespace u23614286_HW01_INF272.Controllers
{
    public class VehicleController : Controller
    {
        [HttpPost]
        public ActionResult Create(Vehicle vehicle, HttpPostedFileBase ImageFile)
        {
            // Assign a unique VehicleID
            vehicle.VehicleID = VehicleRepository.Vehicles.Any()
                ? VehicleRepository.Vehicles.Max(v => v.VehicleID) + 1
                : 1;

            // Handle image upload
            if (ImageFile != null && ImageFile.ContentLength > 0)
            {
                var fileName = Path.GetFileName(ImageFile.FileName);
                var path = Path.Combine(Server.MapPath("~/Images/Vehicles/"), fileName);
                ImageFile.SaveAs(path);
                vehicle.ImagePath = "~/Images/Vehicles/" + fileName;
            }
            else
            {
                // Fallback image if none uploaded
                vehicle.ImagePath = "~/Images/Vehicles/default.jpg";
            }

            VehicleRepository.Vehicles.Add(vehicle);
            return RedirectToAction("Manage", "Home");
        }

        [HttpPost]
        public ActionResult Update(Vehicle updatedVehicle)
        {
            var existing = VehicleRepository.Vehicles.FirstOrDefault(v => v.VehicleID == updatedVehicle.VehicleID);
            if (existing != null)
            {
                existing.Type = updatedVehicle.Type;
                existing.RegistrationNumber = updatedVehicle.RegistrationNumber;
                updatedVehicle.ImagePath = existing.ImagePath;

                existing.ImagePath = updatedVehicle.ImagePath;
                existing.ServiceID = updatedVehicle.ServiceID;
            }
            return RedirectToAction("Manage", "Home");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var vehicle = VehicleRepository.Vehicles.FirstOrDefault(v => v.VehicleID == id);
            if (vehicle != null)
            {
                VehicleRepository.Vehicles.Remove(vehicle);
            }
            return RedirectToAction("Manage", "Home");
        }

        [HttpPost]
        public FileResult Export()
        {
            var lines = VehicleRepository.Vehicles.Select(v =>
                $"Type: {v.Type}, Reg: {v.RegistrationNumber}, Service: {v.ServiceID}");

            var content = string.Join("\n", lines);
            var bytes = System.Text.Encoding.UTF8.GetBytes(content);

            return File(bytes, "text/plain", "vehicles.txt");
        }
    }
}