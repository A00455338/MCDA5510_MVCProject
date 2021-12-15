using System;
using Microsoft.EntityFrameworkCore;
using MovieTicketReservation.Models;



namespace MovieTicketReservation.Data
{
    public class MovieDbContext : DbContext
    { 

        public MovieDbContext(DbContextOptions<MovieDbContext> options): base(options)
        {
        }


        public DbSet<SeatsModel> Seats { get; set; }
        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<AuditoriumModel> Auditorium { get; set; }
        public DbSet<BookingModel> Booking { get; set; }
        public DbSet<MoviesModel> Movies { get; set; }
        public DbSet<PaymentModel> Payment { get; set; }
        public DbSet<ShowModel> Show { get; set; }
        public DbSet<TheatreModel> Theatre { get; set; }
        public DbSet<TransactionModel> Transaction { get; set; }

        public DbSet<UserModel> USR { get; set; }
    }
}
