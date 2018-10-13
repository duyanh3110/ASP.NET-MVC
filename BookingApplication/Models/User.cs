using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingApplication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Hair { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}