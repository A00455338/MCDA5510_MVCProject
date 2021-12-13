using System;
namespace MovieTicketReservation.Models
{
    public class BookingModel
    {
        public BookingModel()
        {
        }
        public int bookingId { get; set; }
        public int movieId { get; set; }
        public int userId { get; set; }
        public int theatreId { get; set; }
        public int showId { get; set; }
        public int transactionId { get; set; }
        public DateTime date { get; set; }
    }
}
