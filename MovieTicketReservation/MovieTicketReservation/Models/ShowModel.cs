using System;
namespace MovieTicketReservation.Models
{
    public class ShowModel
    {
        public ShowModel()
        {
        }
        public int showId { get; set; }
        public int theatreId { get; set; }
        public int audiId { get; set; }
        public DateTime time { get; set; }
    }
}
