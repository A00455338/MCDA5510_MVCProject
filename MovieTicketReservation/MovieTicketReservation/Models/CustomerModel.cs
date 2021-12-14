using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketReservation.Models
{
    public class CustomerModel
    {
        [Key]
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Please enter a valid Email Address.")]
        public string Email { get; set; }

        public string Password { get; set; }

    }
}
