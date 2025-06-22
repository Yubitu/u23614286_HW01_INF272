using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23614286_HW01_INF272.Models
{
    public class RideHistoryViewModel
    {
        public Booking Booking { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }

        // Convenience properties for the view
        public bool IsSOS => Booking.FullName == "Unknown";
        public string DisplayDate => Booking.BookingDate.ToString("dd/MM/yyyy") +
                                     (IsSOS ? " - S.O.S." : "");
        public string DisplayAddress => IsSOS ? "Hidden" : Booking.PickupAddress;
    }

}