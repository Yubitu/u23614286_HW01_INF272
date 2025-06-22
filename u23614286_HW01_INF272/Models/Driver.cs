using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_HW01_INF272.Models
{
	public class Driver
	{
		public int DriverID { get; set; }
		public int ServiceID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string ImagePath { get; set; }
		//Prefer string for phone number due to area codes i.e string of characters
		public string PhoneNumber { get; set; }
	}
}