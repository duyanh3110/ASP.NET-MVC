using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingApplication.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int UserID { get; set; }
        public string Hair { get; set; }
        public DateTime ReservationDate { get; set; }
        public virtual User User { get; set; }
    }
}