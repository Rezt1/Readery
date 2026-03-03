using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Readery.Domain.Data.Constants.PublisherConstants;

namespace Readery.Domain.Data.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(EmailMaxLength)]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}