using System.ComponentModel.DataAnnotations;

namespace universite_psycho_canine_api.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}