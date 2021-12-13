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
        [ForeignKey("MoviesModel")]
        public int movieId { get; set; }
        [ForeignKey("CustomerModel")]
        public int userId { get; set; }
        [ForeignKey("TheatreModel")]
        public int theatreId { get; set; }
        [ForeignKey("ShowModel")]
        public int showId { get; set; }
        [ForeignKey("TransactionModel")]
        public int transactionId { get; set; }
        public DateTime date { get; set; }

        public virtual MoviesModel moviesModel { get; set; }
        public virtual CustomerModel customerModel { get; set; }
        public virtual TheatreModel theatreModel { get; set; }
        public virtual ShowModel showModel { get; set; }
        public virtual TransactionModel transactionModel { get; set; }
    }
}
