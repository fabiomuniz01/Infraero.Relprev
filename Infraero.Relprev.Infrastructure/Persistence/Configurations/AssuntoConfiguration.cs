using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class AssuntoConfiguration : IEntityTypeConfiguration<Assunto>
    {
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            builder.ToTable("CAD_ASSUNTO");

            builder.Property(t => t.CodAssunto)
                .HasColumnName("SEQ_ASSUNTO")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(t => t.DscAssunto)
                .HasColumnName("DSC_ASSUNTO")
                .HasMaxLength(255)
                .IsRequired();

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");
        }

        
    }
}
