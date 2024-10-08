﻿using System.ComponentModel.DataAnnotations;
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
        public int DeliveryInformationId { get; set; }

        [ForeignKey(nameof(DeliveryInformationId))]
        public DeliveryInformation DeliveryInformation { get; set; } = null!;

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        public ICollection<OrderBook> OrderBooks { get; set; } = new List<OrderBook>();
    }
}
