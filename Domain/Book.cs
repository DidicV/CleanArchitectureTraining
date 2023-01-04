using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Book
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;
    }
}