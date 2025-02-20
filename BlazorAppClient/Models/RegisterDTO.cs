using System.ComponentModel.DataAnnotations;

namespace BlazorAppClient.Models
{
    public class RegisterDTO
    {
        [Required(ErrorMessage ="User name is required")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
