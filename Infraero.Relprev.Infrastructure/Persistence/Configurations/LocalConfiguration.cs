using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class LocalConfiguration : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.ToTable("CAD_LOCAL");

            builder.Property(t => t.CodLocal)
                .HasColumnName("SEQ_LOCAL")
                .IsRequired()
                .HasComment("Sequencial da tabela");

            builder.Property(t => t.DscLocal)
                .HasColumnName("DSC_LOCAL")
                .HasMaxLength(255)
                .IsRequired()
                .HasComment("Descrição do local da ocorrencia");

            builder.Property(t => t.CodUnidadeInfraestrutura)
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA")
                .IsRequired()
                .HasComment("Codigo sequencial da unidade de infraestrutura");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }
    }
}
