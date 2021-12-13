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

        public DbSet<Seats> Seats { get; set; }
    }
}
