using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Domain.Data.Models;

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
            builder.HasData(new[] { seeder.Book1, seeder.Book2, seeder.Book3, seeder.Book4, seeder.Book5, seeder.Book6, seeder.Book7, seeder.Book8, seeder.Book9, seeder.Book10 });
        }
    }
}
