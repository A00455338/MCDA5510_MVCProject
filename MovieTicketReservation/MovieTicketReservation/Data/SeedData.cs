//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using MovieTicketReservation.Models;

//namespace MovieTicketReservation.Data
//{
//    public class SeedData
//    {
//        public static void Initialize(IServiceProvider serviceProvider)
//        {
//            using (var context = new MovieDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieDbContext>>()))
//            {
//                //Look for seats
//                if (context.Seats.Any()) { return; }

//                List<Seats> seats = new List<Seats>()
//                {
//                    new Seats(){seatId="A7"},
//                    new Seats(){seatId="A8"}
//                };

//                context.Seats.AddRange(seats);
//                context.SaveChanges();
//            }
//        }
//    }
//}
