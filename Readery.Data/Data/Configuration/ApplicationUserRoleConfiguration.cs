using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Guid = System.Guid;

namespace Readery.Domain.Data.Configuration
{
    internal class ApplicationUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            var data = new DataSeeder();

            var userRole = new IdentityUserRole<Guid>()
            {
                UserId = data.AuthorUser.Id,
                RoleId = data.AuthorRole.Id,
            };

            builder.HasData(new IdentityUserRole<Guid>[] { userRole });
        }
    }
}
