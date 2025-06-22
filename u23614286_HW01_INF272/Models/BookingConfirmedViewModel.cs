using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_HW01_INF272.Models
{
	public class BookingConfirmedViewModel
	{
        public Booking Booking { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}