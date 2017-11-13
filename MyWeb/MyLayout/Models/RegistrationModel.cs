using System.ComponentModel.DataAnnotations;


namespace MyLayout.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Password Can not be empty")]
        [StringLength(25, ErrorMessage = "must be between 5 to 25 characters", MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Email must be valid")]
        public string Email { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "must be between 5 to 25 characters", MinimumLength = 5)]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public System.DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Password Can not be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}