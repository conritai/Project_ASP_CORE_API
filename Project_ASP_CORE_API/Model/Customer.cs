using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Model
{
    public class Customer
    {
        [Key]
        public Guid Customer_id { get; set; }

        [Required(ErrorMessage = "Please fill in this blank !!")]
        public string Full_name { get; set; }

        [Required(ErrorMessage = "Please fill in this blank !!")]
        [Phone(ErrorMessage = "Invalid PhoneNumber")]
        public string Phone_number { get; set; }

        [Required(ErrorMessage = "Please fill in this blank !!")]
        [EmailAddress(ErrorMessage = "Invalid Email Adress")]
        public string Email { get; set; }
        public DateTime Submit_on { get; set; }

        [Required]
        public string Domain_name { get; set; }

    }
}
