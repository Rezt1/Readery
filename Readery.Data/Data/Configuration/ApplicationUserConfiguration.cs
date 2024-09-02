using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Data.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var seeder = new DataSeeder();
            builder.HasData(new[] { seeder.CommonUser, seeder.AuthorUser });
        }
    }
}
