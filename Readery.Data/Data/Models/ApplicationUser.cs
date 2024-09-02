using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Readery.Data.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public int? AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author? Author { get; set; }

        public int? ShippingAddressId { get; set; }

        [ForeignKey(nameof(ShippingAddressId))]
        public ShippingAddress? ShippingAddress { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
