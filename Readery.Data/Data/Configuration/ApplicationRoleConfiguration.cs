using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Domain.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            var data = new DataSeeder();

            builder.HasData(new ApplicationRole[] { data.AuthorRole });
        }
    }
}
