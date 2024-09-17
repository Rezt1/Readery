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
                .HasForeignKey(di => di.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(au => au.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);

			var seeder = new DataSeeder();
            builder.HasData(new[] { seeder.CommonUser, seeder.AuthorUser });
        }
    }
}
