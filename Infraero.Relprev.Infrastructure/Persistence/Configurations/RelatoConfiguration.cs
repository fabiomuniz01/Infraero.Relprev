
using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class RelatoConfiguration : IEntityTypeConfiguration<Relato>
    {
        public void Configure(EntityTypeBuilder<Relato> builder)
        {
            builder.ToTable("CAD_RELATO");

            builder.Property(t => t.CodRelato)
                .HasColumnName("SEQ_RELATO")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(t => t.DatOcorrencia)
                .HasColumnName("DAT_OCORRENCIA")
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
