using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Readery.Domain.Data.Constants.DeliveryInformationConstants;

namespace Readery.Domain.Data.Models
{
    public class DeliveryInformation
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = string.Empty;

        [Required, MaxLength(EmailMaxLength)]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = string.Empty;

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
