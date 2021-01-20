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
                .IsRequired().HasComment("Sequencial da tabela");
            builder.Property(t => t.DscSubLocal)
                .HasColumnName("DSC_SUBLOCAL")
                .HasMaxLength(100)
                .IsRequired().HasComment("Descrição do sublocal da ocorrencia");
            builder.Property(t => t.CodUnidadeInfraestrutura)
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA")
                .IsRequired().HasComment("Código sequencial da unidade de infraestrutura");
            builder.Property(t => t.CodLocal)
                .HasColumnName("COD_LOCAL")
                .IsRequired().HasComment("Código sequencial do local");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasMaxLength(256).HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasMaxLength(256).HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }
    }
}
