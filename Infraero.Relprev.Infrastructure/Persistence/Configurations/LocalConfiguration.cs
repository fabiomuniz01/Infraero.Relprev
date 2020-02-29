using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class LocalConfiguration : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.Property(t => t.DscLocal)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(t => t.CodUnidadeInfraestrutura)
                .IsRequired();
        }
    }
}
