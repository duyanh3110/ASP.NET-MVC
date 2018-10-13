using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookingApplication.Models;

namespace BookingApplication.DAL
{
    public class ReservationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ReservationContext>
    {
        protected override void Seed(ReservationContext context)
        {
            var users = new List<User>
            {
            new User{UserName="John"},
            new User{UserName="Minh Anh"},
            new User{UserName="Joe"},
            new User{UserName="Luis"},
            new User{UserName="Huy"},
            new User{UserName="Chuong"},
            new User{UserName="Danny"},
            new User{UserName="Nemo"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var reservations = new List<Reservation>
            {
            new Reservation{UserID=1,Hair="Navy",ReservationDate=DateTime.Parse("2018-09-01")},
            new Reservation{UserID=2,Hair="Two Block",ReservationDate=DateTime.Parse("2018-09-02")},
            new Reservation{UserID=3,Hair="Side part",ReservationDate=DateTime.Parse("2018-09-03")},
            new Reservation{UserID=2,Hair="Quizz",ReservationDate=DateTime.Parse("2018-09-04")},
            new Reservation{UserID=5,Hair="Pompadour",ReservationDate=DateTime.Parse("2018-09-05")},
            new Reservation{UserID=1,Hair="Undercut",ReservationDate=DateTime.Parse("2018-09-06")},
            new Reservation{UserID=2,Hair="Korean Style",ReservationDate=DateTime.Parse("2018-09-07")}
            };
            reservations.ForEach(s => context.Reservations.Add(s));
            context.SaveChanges();

        }
    }
}