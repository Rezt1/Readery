using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Data.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            var seeder = new DataSeeder();
            builder.HasData(new[] { seeder.AuthorAddress, seeder.PublisherAddress });
        }
    }
}
