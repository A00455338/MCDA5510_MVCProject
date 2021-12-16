using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketReservation.Models
{
    public class BookingModel
    {
        public BookingModel()
        {
        }
        [Key]
        public int bookingId { get; set; }
        
        public string movieName { get; set; }
        
        public string timings { get; set; }
        public string seatId { get; set; }
        //public DateTime date { get; set; }

    }
}
