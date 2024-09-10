using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readery.Domain.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class PersonalDeliveryInformationConfiguration : IEntityTypeConfiguration<PersonalDeliveryInformation>
    {
        public void Configure(EntityTypeBuilder<PersonalDeliveryInformation> builder)
        {
            builder.HasOne(pdi => pdi.User)
                .WithMany(u => u.PersonalDeliveryInformation)
                .HasForeignKey(pdi => pdi.UserId);
        }
    }
}
