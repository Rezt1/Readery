using System.ComponentModel.DataAnnotations;

namespace Readery.Domain.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        public ICollection<DeliveryInformation> DeliveryInformation { get; set; } = new List<DeliveryInformation>();
    }
}