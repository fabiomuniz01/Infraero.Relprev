using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class ParecerArquivoConfiguration : IEntityTypeConfiguration<ParecerArquivo>
    {
        public void Configure(EntityTypeBuilder<ParecerArquivo> builder)
        {
            builder.ToTable("CAD_PARECER_ARQUIVO");

            builder.Property(t => t.CodParecerArquivo)
                .HasColumnName("SEQ_PARECER_ARQUIVO")
                .IsRequired().HasComment("Sequencial da tabela");

            builder.Property(t => t.CodParecer)
                .HasColumnName("COD_PARECER")
                .IsRequired().HasComment("Codigo sequencial do PARECER");

            builder.Property(t => t.Arquivo)
                .HasColumnName("NOM_ARQUIVO_UNICO")
                .HasMaxLength(500)
                .IsRequired().HasComment("Nome unico do arquivo");

            builder.Property(t => t.Caminho)
                .HasColumnName("DIR_CAMINHO")
                .HasMaxLength(500)
                .IsRequired().HasComment("Diretorio do arquivo");

            builder.Property(t => t.NomeArquivo)
                .HasColumnName("NOM_ARQUIVO")
                .HasMaxLength(200)
                .IsRequired().HasComment("Nome original do arquivo");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasMaxLength(256).HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasMaxLength(256).HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }

        
    }
}
