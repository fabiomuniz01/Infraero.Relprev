using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class RelatoArquivoConfiguration : IEntityTypeConfiguration<RelatoArquivo>
    {
        public void Configure(EntityTypeBuilder<RelatoArquivo> builder)
        {
            builder.ToTable("CAD_RELATO_ARQUIVO");

            builder.Property(t => t.CodRelatoArquivo)
                .HasColumnName("SEQ_RELATO_ARQUIVO")
                .IsRequired();

            builder.Property(t => t.CodRelato)
                .HasColumnName("COD_RELATO")
                .IsRequired();

            builder.Property(t => t.Arquivo)
                .HasColumnName("NOM_ARQUIVO_UNICO")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(t => t.Caminho)
                .HasColumnName("NOM_CAMINHO")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(t => t.NomeArquivo)
                .HasColumnName("NOM_ARQUIVO")
                .HasMaxLength(200)
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
