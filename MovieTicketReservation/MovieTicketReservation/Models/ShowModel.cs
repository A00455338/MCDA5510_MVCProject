using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketReservation.Models
{
    public class ShowModel
    {
        public ShowModel()
        {
        }
        [Key]
        public int showId { get; set; }
        [ForeignKey("TheatreModel")]
        public int theatreId { get; set; }
        [ForeignKey("AuditoriumModel")]
        public int audiId { get; set; }
        public DateTime time { get; set; }

        public virtual TheatreModel theatreModel { get; set; }
        public virtual AuditoriumModel auditoriumModel { get; set; }
    }
}
