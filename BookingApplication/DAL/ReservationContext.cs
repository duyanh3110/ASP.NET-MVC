using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookingApplication.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BookingApplication.DAL
{
    public class ReservationContext : DbContext
    {
        public ReservationContext() : base("ReservationContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}