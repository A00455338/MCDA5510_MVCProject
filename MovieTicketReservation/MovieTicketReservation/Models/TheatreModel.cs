using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketReservation.Models
{
    public class TheatreModel
    {
        [Key]
        public int theatreId { get; set; }
        public string theatreName { get; set; }
        public string address { get; set; }
    }
    public class TheatreList
    {
        public List<TheatreModel> theatreList { get; set; }
    }
}
