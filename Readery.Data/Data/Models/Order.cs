using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Readery.Domain.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int PersonalDeliveryInformationId { get; set; }

        [ForeignKey(nameof(PersonalDeliveryInformationId))]
        public PersonalDeliveryInformation PersonalDeliveryInformation { get; set; } = null!;

        [Required]
        public int ShippingAddressId { get; set; }

        [ForeignKey(nameof(ShippingAddressId))]
        public ShippingAddress ShippingAddress { get; set; } = null!;

        [Required]
        public DateTime OrderDate { get; set; }

        public ICollection<OrderBook> OrderBooks { get; set; } = new List<OrderBook>();
    }
}
