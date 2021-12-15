using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    }
    public class MoviesList
    {
        public List<MoviesModel> moviesList { get; set; }
    }
}
