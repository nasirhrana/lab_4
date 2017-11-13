using System.ComponentModel.DataAnnotations;


namespace MyLayout.Models
{
    public class PasswordModel
    {
        
        [Required(ErrorMessage = "Password Can not be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password Can not be empty")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}