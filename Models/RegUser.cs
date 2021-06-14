using System.ComponentModel.DataAnnotations;

namespace SimpleLogin.Models
{
    public class RegUser
    {
        [Required(ErrorMessage = "is required")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "is required")]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "is required")]
        [Compare("Password",ErrorMessage = "Passwords must match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}