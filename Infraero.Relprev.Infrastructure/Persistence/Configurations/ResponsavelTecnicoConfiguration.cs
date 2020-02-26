using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    public class ResponsavelTecnicoConfiguration : IEntityTypeConfiguration<ResponsavelTecnico>
    {
        public void Configure(EntityTypeBuilder<ResponsavelTecnico> builder)
        {
            builder.Property(t => t.NomResponsavelTecnico)
                .HasMaxLength(60)
                .IsRequired();
            builder.Property(t => t.NumCpf)
                .HasMaxLength(14)
                .IsRequired();
            builder.Property(t => t.NumTelefone)
                .HasMaxLength(14)
                .IsRequired();
            builder.Property(t => t.NumDocumento)
                .HasMaxLength(15);
            builder.Property(t => t.EndEmail)
                .HasMaxLength(60);
            builder.Property(t => t.CodUnidadeInfraestrutura)
                .IsRequired();
            builder.Property(t => t.CodEmpresa)
                .IsRequired();
        }
    }
}
