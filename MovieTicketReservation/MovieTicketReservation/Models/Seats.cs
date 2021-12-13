using System;
using System.ComponentModel.DataAnnotations;

namespace MovieTicketReservation.Models
{
    public class Seats
    {
        public Seats()
        {
        }

        [Key]
        public string seatId { get; set; }
    }
}
