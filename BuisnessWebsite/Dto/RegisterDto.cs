using System.ComponentModel.DataAnnotations;

namespace BuisnessWebsite.Dto
{
    public class RegisterDto
    {
        
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
