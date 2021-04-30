using System.ComponentModel.DataAnnotations;

namespace vvvas.Models
{
    public class Note
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(length: 100)]
        public string Body { get; set; }
    }
}