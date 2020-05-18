using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class SubAssuntoConfiguration : IEntityTypeConfiguration<SubAssunto>
    {
        public void Configure(EntityTypeBuilder<SubAssunto> builder)
        {
            builder.ToTable("CAD_SUBASSUNTO");

            builder.Property(t => t.CodSubAssunto)
                .HasColumnName("SEQ_SUBASSUNTO").IsRequired();

            builder.Property(t => t.DscSubAssunto)
                .HasColumnName("DSC_SUBASSUNTO")
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(t => t.CodAssunto)
                .HasColumnName("COD_ASSUNTO")
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
