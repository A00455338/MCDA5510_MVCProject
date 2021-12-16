using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketReservation.Models
{
    public class MoviesModel
    {
        [Key]
        public int movieId { get; set; }
        public string movieName { get; set; }
        public string movieGenre { get; set; }
        public string lang { get; set; }
        public int year { get; set; }
        public TimeSpan len { get; set; }
        public string movieDesc { get; set; }
        public double ratings { get; set; }

        //[ForeignKey("TheatreId")]
        //public TheatreModel theatre { get; set; }
        [ForeignKey("theatreId")]
        public virtual TheatreModel theatreModel { get; set; }

    }
    public class MoviesList
    {
        public List<MoviesModel> moviesList { get; set; }
    }
}
