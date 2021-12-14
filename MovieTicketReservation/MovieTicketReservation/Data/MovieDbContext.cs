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
    }
}
