using System.ComponentModel.DataAnnotations;

namespace Readery.Data.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        public ICollection<ShippingAddress> ShippingAddresses { get; set; } = new List<ShippingAddress>();
    }
}