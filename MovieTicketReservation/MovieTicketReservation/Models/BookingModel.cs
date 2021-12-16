using System;
using System.Collections.Generic;
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
        
        public TimeSpan timings { get; set; }
        public string seatId { get; set; }
        //public DateTime date { get; set; }

    }
    public class BookingList
    {
        public List<BookingModel> bookingList { get; set; }
    }
}
