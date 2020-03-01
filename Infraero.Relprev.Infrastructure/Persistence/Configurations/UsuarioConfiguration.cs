using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(t => t.NomUsuario)
                .HasMaxLength(60)
                .IsRequired();
            builder.Property(t => t.NumCpf)
                .HasMaxLength(14)
                .IsRequired();
            builder.Property(t => t.NumTelefone)
                .HasMaxLength(14)
                .IsRequired();
            builder.Property(t => t.Email)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
