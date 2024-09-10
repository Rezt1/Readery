using static Readery.Domain.Data.Constants.ShippingAddressConstants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Readery.Domain.Data.Models
{
    public class ShippingAddress
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(StreetMaxLength)]
        public string Street { get; set; } = string.Empty;

        [Required, MaxLength(CityMaxLength)]
        public string City { get; set; } = string.Empty;

        [Required]
        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [Required, MaxLength(ZipCodeMaxLength)]
        public string ZipCode { get; set; } = string.Empty;

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int Version { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
