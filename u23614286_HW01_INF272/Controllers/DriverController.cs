using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23614286_HW01_INF272.Models;

namespace u23614286_HW01_INF272.Controllers
{
    public class DriverController : Controller
    {
        [HttpPost]
        public ActionResult Create(Driver driver, HttpPostedFileBase ImageFile)
        {
            // Assign new DriverID
            driver.DriverID = DriverRepository.Drivers.Any()
                ? DriverRepository.Drivers.Max(d => d.DriverID) + 1
                : 1;

            // TODO: Handle image upload
            if (ImageFile != null && ImageFile.ContentLength > 0)
            {
                // Save the image to your folder and set driver.ImagePath
                var fileName = Path.GetFileName(ImageFile.FileName);
                var path = Path.Combine(Server.MapPath("~/Images/Drivers/"), fileName);
                ImageFile.SaveAs(path);
                driver.ImagePath = "~/Images/Drivers/" + fileName;
            }
            else
            {
                // Default image path if none uploaded
                driver.ImagePath = "~/Images/Drivers/driver1.jpg";
            }

            DriverRepository.Drivers.Add(driver);
            return RedirectToAction("Manage", "Home");
        }


        [HttpPost]
        public ActionResult Update(Driver updatedDriver)
        {
            var existingDriver = DriverRepository.Drivers.FirstOrDefault(d => d.DriverID == updatedDriver.DriverID);
            if (existingDriver != null)
            {
                existingDriver.FirstName = updatedDriver.FirstName;
                existingDriver.LastName = updatedDriver.LastName;
                existingDriver.PhoneNumber = updatedDriver.PhoneNumber;

                if (!string.IsNullOrWhiteSpace(updatedDriver.ImagePath))
                {
                    existingDriver.ImagePath = updatedDriver.ImagePath;
                }

                existingDriver.ServiceID = updatedDriver.ServiceID;
            }
            return RedirectToAction("Manage", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var driver = DriverRepository.Drivers.FirstOrDefault(d => d.DriverID == id);
            if (driver != null)
            {
                DriverRepository.Drivers.Remove(driver);
            }
            return RedirectToAction("Manage", "Home");
        }


        [HttpPost]
        public ActionResult Search(string firstName, int? serviceID)
        {
            var filteredDrivers = DriverRepository.Drivers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(firstName))
                filteredDrivers = filteredDrivers.Where(d => d.FirstName.ToLower().Contains(firstName.ToLower()));

            if (serviceID.HasValue)
                filteredDrivers = filteredDrivers.Where(d => d.ServiceID == serviceID.Value);

            var model = new VehicleDriverViewModel
            {
                Drivers = filteredDrivers.ToList(),
                Vehicles = VehicleRepository.Vehicles //showing all vehicles regardless
            };

            return View("~/Views/Home/Manage.cshtml", model);
        }

    }
}