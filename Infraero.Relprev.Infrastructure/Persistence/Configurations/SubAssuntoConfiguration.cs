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
                .HasColumnName("SEQ_SUBASSUNTO")
                .IsRequired()
                .HasComment("Sequencial da tabela");

            builder.Property(t => t.DscSubAssunto)
                .HasColumnName("DSC_SUBASSUNTO")
                .HasMaxLength(255)
                .IsRequired()
                .HasComment("Descrição do subassunto");
            builder.Property(t => t.CodAssunto)
                .HasColumnName("COD_ASSUNTO")
                .IsRequired()
                .HasComment("Código sequencial do subassunto");


            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }
    }
}
