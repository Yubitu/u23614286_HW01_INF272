using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_HW01_INF272.Models
{
	public class Booking
	{
		public Guid BookingID { get; set; }
		public string FullName { get; set; }
		public DateTime PickupTime { get; set; }
		public DateTime BookingDate { get; set; }
		public bool IsSOS { get; set; }
		public int DriverID { get; set; }
		public int VehicleID { get; set; }
		public int ServiceID { get; set; }
		public int ReasonID { get; set; }
		public string PickupAddress { get; set; }
		public string Phone { get; set;  }
	}
}