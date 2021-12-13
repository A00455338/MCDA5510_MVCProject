using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketReservation.Models
{
    public class AuditoriumModel
    {
        [Key]
        public int auditoriumId { get; set; }
        public int theatreId { get; set; }
    }
}
