using static Readery.Domain.Data.Constants.PersonalDeliveryInformationConstants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Readery.Domain.Data.Models
{
    public class PersonalDeliveryInformation
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
