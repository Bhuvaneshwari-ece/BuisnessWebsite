using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BuisnessWebsite.Models
{
    public class User

    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password   { get; set; }=string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
