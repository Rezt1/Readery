﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Readery.Domain.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public int? AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author? Author { get; set; }

        public ICollection<DeliveryInformation> DeliveryInformation { get; set; } = new List<DeliveryInformation>();

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
