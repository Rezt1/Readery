using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Domain.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            var seeder = new DataSeeder();
            builder.HasData(new[] { seeder.Country1, seeder.Country2, seeder.Country3, seeder.Country4 });
        }
    }
}
