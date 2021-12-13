using System;
namespace MovieTicketReservation.Models
{
    public class TransactionModel
    {
        public TransactionModel()
        {
        }
        public int transactionId { get; set; }
        public int paymentId { get; set; }
        public int userId { get; set; }
        public DateTime date { get; set; }
    }
}
