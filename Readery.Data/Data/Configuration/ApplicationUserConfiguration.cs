using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Domain.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(au => au.DeliveryInformation)
                .WithOne(di => di.User)
                .HasForeignKey(di => di.UserId);

            var seeder = new DataSeeder();
            builder.HasData(new[] { seeder.CommonUser, seeder.AuthorUser });
        }
    }
}
