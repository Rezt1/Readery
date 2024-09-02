using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Data.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder
                .HasOne(p => p.Address)
                .WithOne(a => a.Publisher)
                .HasForeignKey<Address>(a => a.PublisherId);

            var seeder = new DataSeeder();
            builder.HasData(new[] { seeder.Publisher });
        }
    }
}
