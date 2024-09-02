using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Data.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder
                .HasOne(a => a.Address)
                .WithOne(a => a.Author)
                .HasForeignKey<Address>(a => a.AuthorId);

            builder
                .HasOne(a => a.User)
                .WithOne(u => u.Author)
                .HasForeignKey<ApplicationUser>(u => u.AuthorId);

            var seeder = new DataSeeder();
            builder.HasData(new[] { seeder.Author });
        }
    }
}
