using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Domain.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(au => au.PersonalDeliveryInformation)
                .WithOne(pdi => pdi.User)
                .HasForeignKey(pdi => pdi.UserId);

            var seeder = new DataSeeder();
            builder.HasData(new[] { seeder.CommonUser, seeder.AuthorUser });
        }
    }
}
