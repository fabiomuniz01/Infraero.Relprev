using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class FuncionalidadeConfiguration : IEntityTypeConfiguration<Funcionalidade>
    {
        public void Configure(EntityTypeBuilder<Funcionalidade> builder)
        {
            builder.ToTable("TAB_FUNCIONALIDADE");

            builder.Property(t => t.CodFuncionalidade)
                .HasColumnName("SEQ_FUNCIONALIDADE")
                .IsRequired().HasComment("Sequencial da tabela");

                builder.Property(t => t.NomFuncionalidade)
                    .HasColumnName("NOM_FUNCIONALIDADE")
                    .HasMaxLength(100)
                    .IsRequired().HasComment("Descriçao do Funcionalidade");

                builder.Property(t => t.CodModulo)
                    .HasColumnName("COD_MODULO")
                    .IsRequired().HasComment("Descriçao do Funcionalidade");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasMaxLength(256).HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasMaxLength(256).HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }

        
    }
}
