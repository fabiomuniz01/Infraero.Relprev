using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class SubAssuntoConfiguration : IEntityTypeConfiguration<SubAssunto>
    {
        public void Configure(EntityTypeBuilder<SubAssunto> builder)
        {
            builder.Property(t => t.DscSubAssunto)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(t => t.CodAssunto)
                .IsRequired();
        }
    }
}
