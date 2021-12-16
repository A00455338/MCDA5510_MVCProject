using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketReservation.Models
{
    public class ShowTimingsModel
    {
        [Key]
        public int showId { get; set; }
        public TimeSpan timings { get; set; }
    }
}
