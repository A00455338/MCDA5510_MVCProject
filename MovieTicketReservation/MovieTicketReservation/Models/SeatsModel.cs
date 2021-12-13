using System;
using System.ComponentModel.DataAnnotations;

namespace MovieTicketReservation.Models
{
    public class SeatsModel
    {
        public SeatsModel()
        {
        }

        [Key]
        public string seatId { get; set; }
    }
}
