using System.ComponentModel.DataAnnotations;

namespace BuisnessWebsite.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string MessageType { get; set; } = string.Empty;
        [Required]
        public string Messagestored { get; set; } = string.Empty;
    }
}
