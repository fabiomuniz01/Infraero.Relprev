using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class SubLocalConfiguration : IEntityTypeConfiguration<SubLocal>
    {
        public void Configure(EntityTypeBuilder<SubLocal> builder)
        {
            builder.Property(t => t.DscSubLocal)
                .HasMaxLength(300)
                .IsRequired();
            builder.Property(t => t.CodUnidadeInfraestrutura)
                .IsRequired();
            builder.Property(t => t.CodLocal)
                .IsRequired();
        }
    }
}
