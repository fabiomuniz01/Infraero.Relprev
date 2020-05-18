using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class UnidadeInfraestruturaConfiguration : IEntityTypeConfiguration<UnidadeInfraestrutura>
    {
        public void Configure(EntityTypeBuilder<UnidadeInfraestrutura> builder)
        {
            builder.ToTable("CAD_UNIDADE_INFRAESTRUTURA");

            builder.Property(t => t.CodUnidadeInfraestrutura)
                .HasColumnName("SEQ_UNIDADE_INFRAESTRUTURA")
                .IsRequired();

            builder.Property(t => t.CodUnidade)
                .HasColumnName("COD_UNIDADE")
                .IsRequired();

            builder.Property(t => t.Sigla)
                .HasColumnName("SIG_UNIDADE")
                .HasMaxLength(8)
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
