using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Content { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Answer { get; set; } = string.Empty;
    }
}
