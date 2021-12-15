using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketReservation.Models
{
    public class CustomerModel
    {
        [Key]
        public int userId { get; set; }

        [RegularExpression(@"^[a-zA-Z].*[\s\.]*$", ErrorMessage = "Please enter a valid Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string firstName { get; set; }

        [RegularExpression(@"^[a-zA-Z].*[\s\.]*$", ErrorMessage = "Please enter a valid Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string country { get; set; }

        [Required(ErrorMessage = "Postal/Zip Code is required")]
        public string postalcode { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid 10 digit Phone Number ###-###-####")]
        [Required(ErrorMessage = "Phone number is required")]
        public string phoneNumber { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }

        [NotMapped]
        [Compare("password", ErrorMessage = "Password doesn't match.")]
        public string confirmPassword { get; set; }
    }

    public class CustList
        {
        public List<CustomerModel> customers { get; set; }
    }

}
