using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Domain.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class DeliveryInformationConfiguration : IEntityTypeConfiguration<DeliveryInformation>
    {
        public void Configure(EntityTypeBuilder<DeliveryInformation> builder)
        {
            builder.HasOne(di => di.User)
                .WithMany(u => u.DeliveryInformation)
                .HasForeignKey(di => di.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
