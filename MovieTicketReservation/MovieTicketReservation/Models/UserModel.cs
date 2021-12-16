using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketReservation.Models
{
    public class UserModel
    {
        public UserModel()
        {
        }
        [Key]
        [ForeignKey("CustomerModel")]
        public int userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }


    }
}