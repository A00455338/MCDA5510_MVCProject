using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketReservation.Models
{
    public class TransactionModel
    {
        public TransactionModel()
        {
        }
        [Key]
        public int transactionId { get; set; }
        [ForeignKey("PaymentModel")]
        public int paymentId { get; set; }
        [ForeignKey("CustomerModel")]
        public int userId { get; set; }
        public DateTime date { get; set; }

        public virtual CustomerModel customerModel { get; set; }
        public virtual PaymentModel paymentModel { get; set; }
    }
}
