using Project_ASP_CORE_API.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Model
{
    public class User
    {
        [Key]
        public Guid User_id { get; set; }

        [Required(ErrorMessage = "Please fill in this blank !!")]
        public string Full_name { get; set; }

        [Required(ErrorMessage = "Please fill in this blank !!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please fill in this blank !!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please fill in this blank !!")]
        [EmailAddress(ErrorMessage = "Invalid Email Adress")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please fill in this blank !!")]
        [Phone(ErrorMessage = "Invalid PhoneNumber")]
        public string Phone_number { get; set; }

        [Required(ErrorMessage = "You have not choose role for this user !!!")]
        public Guid Role_id { get; set; }

        [ForeignKey("Role_id")]
        public Role Role { get; set; }

        public User(string full_name, string username, string password, string email, string phone_number, Guid role_id)
        {
            Full_name = full_name;
            Username = username;
            Password = password;
            Email = email;
            Phone_number = phone_number;
            Role_id = role_id;
        }

        public User() { }    
    }
}
