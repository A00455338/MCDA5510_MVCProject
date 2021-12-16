using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketReservation.Models
{
    public class ShowModel
    {
        
        [Key]
        public int showId { get; set; }
        [ForeignKey("AuditoriumModel")]
        public int audiId { get; set; }
        public DateTime time { get; set; }
        public virtual AuditoriumModel auditoriumModel { get; set; }
    }
    public class showModel
    {
        public List<showModel> showList { get; set; }
    }
}
