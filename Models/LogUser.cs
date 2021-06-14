using System.ComponentModel.DataAnnotations;

namespace SimpleLogin.Models
{
    public class LogUser
    {
        [Required(ErrorMessage = "is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}