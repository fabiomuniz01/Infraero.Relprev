using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class SubLocalConfiguration : IEntityTypeConfiguration<SubLocal>
    {
        public void Configure(EntityTypeBuilder<SubLocal> builder)
        {
            builder.ToTable("CAD_SUBLOCAL");

            builder.Property(t => t.CodSubLocal)
                .HasColumnName("SEQ_SUBLOCAL")
                .IsRequired();
            builder.Property(t => t.DscSubLocal)
                .HasColumnName("DSC_SUBLOCAL")
                .HasMaxLength(300)
                .IsRequired();
            builder.Property(t => t.CodUnidadeInfraestrutura)
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA")
                .IsRequired();
            builder.Property(t => t.CodLocal)
                .HasColumnName("COD_LOCAL")
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
