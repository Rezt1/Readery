using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Readery.Data.Data.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Street { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string City { get; set; } = string.Empty;

        [Required]
        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        public int? AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author? Author { get; set; }

        public int? PublisherId { get; set; }

        [ForeignKey(nameof(PublisherId))]
        public Publisher? Publisher { get; set; }
    }
}
