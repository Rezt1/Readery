using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Domain.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class ShippingAddressConfiguration : IEntityTypeConfiguration<ShippingAddress>
    {
        public void Configure(EntityTypeBuilder<ShippingAddress> builder)
        {
            builder
                .HasOne(sa => sa.User)
                .WithMany(u => u.ShippingAddresses)
                .HasForeignKey(sa => sa.UserId);
        }
    }
}
