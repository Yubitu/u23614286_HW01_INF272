using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_HW01_INF272.Models
{
	public class Vehicle
	{
		public int VehicleID { get; set; }
		public int ServiceID { get; set; }
		public string RegistrationNumber { get; set; }
		public string ImagePath { get; set; }
		public string Type { get; set; }
	}
}