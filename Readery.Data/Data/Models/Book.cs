using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Readery.Domain.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int PagesCount { get; set; }

        [Required, MaxLength(20)]
        public string Language { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required, MaxLength(200)]
        public string ImagePath { get; set; } = string.Empty;

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; } = null!;

        [Required]
        public int PublisherId { get; set; }

        [ForeignKey(nameof(PublisherId))]
        public Publisher Publisher { get; set; } = null!;

        [Required]
        public DateTime WrittenOn { get; set; }

        [Required]
        public DateTime AddedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [Required]
        public bool IsRemoved { get; set; }

        public ICollection<OrderBook> OrderBooks { get; set; } = new List<OrderBook>();
    }
}
