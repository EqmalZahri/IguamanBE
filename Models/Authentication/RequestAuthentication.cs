using System.ComponentModel.DataAnnotations;

namespace Iguaman.Models.Authentication
{
    public class RequestAuthentication
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
