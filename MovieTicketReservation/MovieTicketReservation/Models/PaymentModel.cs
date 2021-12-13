using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketReservation.Models
{
    public class PaymentModel
    {
        [Key]
        public int paymentId { get; set; }
        public string paymentType { get; set; }
        public long cardNumber { get; set; }
    }
}
