using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Data.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .HasOne(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(b => b.PublisherId)
                .OnDelete(DeleteBehavior.NoAction);

            var seeder = new DataSeeder();
            builder.HasData(new[] { seeder.Book1, seeder.Book2, seeder.Book3 });
        }
    }
}
