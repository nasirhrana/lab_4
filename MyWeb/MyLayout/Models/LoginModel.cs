using System;
using System.ComponentModel.DataAnnotations;


namespace MyLayout.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Password Can not be empty")]
        [StringLength(25, ErrorMessage = "must be between 5 to 25 characters", MinimumLength = 5)]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

       // public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
       // public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}