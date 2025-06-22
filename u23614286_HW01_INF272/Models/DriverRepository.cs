using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static u23614286_HW01_INF272.Models.VehicleRepository;

namespace u23614286_HW01_INF272.Models
{
	public class DriverRepository
	{
        public static List<Driver> Drivers = new List<Driver>
        {
            new Driver
            {
                DriverID = 1,
                FirstName = "Thompson",
                LastName = "Valoid",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver1.jpg"),
                PhoneNumber = "078 132 8633",
                ServiceID = 1
            },
            new Driver
            {
                DriverID = 2,
                FirstName = "Jen",
                LastName = "Payne",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver2.jpg"),
                PhoneNumber = "076 002 1896",
                ServiceID = 2
            },
            new Driver
            {
                DriverID = 3,
                FirstName = "John",
                LastName = "Medic",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("/Images/Drivers/driver3.jpg"),
                PhoneNumber = "082 447 0647",
                ServiceID = 3
            },
            new Driver
            {
                DriverID = 4,
                FirstName = "Victor",
                LastName = "Vansen",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver4.jpg"),
                PhoneNumber = "083 901 7876",
                ServiceID = 4
            },
            new Driver
            {
                DriverID = 5,
                FirstName = "Lauren",
                LastName = "Castenhoff",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver5.jpg"),
                PhoneNumber = "085 678 9012",
                ServiceID = 5
            },
            new Driver
            {
                DriverID = 6,
                FirstName = "Greg",
                LastName = "Airson",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver6.jpg"),
                PhoneNumber = "079 333 9021",
                ServiceID = 6
            },

            new Driver
            {
                DriverID = 7,
                FirstName = "Tessa",
                LastName = "Gauze",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver7.png"),
                PhoneNumber = "071 842 5963",
                ServiceID = 1
            },

            new Driver
            {
                DriverID = 8,
                FirstName = "Nina",
                LastName = "Syringo",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver8.png"),
                PhoneNumber = "082 103 9847",
                ServiceID = 2
            },

            new Driver
            {
                DriverID = 9,
                FirstName = "Kyle",
                LastName = "Band-Ayden",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver9.png"),
                PhoneNumber = "076 229 8475",
                ServiceID = 3
            },

            new Driver
            {
                DriverID = 10,
                FirstName = "Benny",
                LastName = "Lynn",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver10.jpg"),
                PhoneNumber = "061 758 2034",
                ServiceID = 4
            },

            new Driver
            {
                DriverID = 11,
                FirstName = "Cammy",
                LastName = "Plastero",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver11.jpg"),
                PhoneNumber = "083 416 9820",
                ServiceID = 5
            },

            new Driver
            {
                DriverID = 12,
                FirstName = "Barry",
                LastName = "Airson",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Images/Drivers/driver12.jpg"),
                PhoneNumber = "079 635 7401",
                ServiceID = 6
            },
        };
    }
}