using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class ModuloConfiguration : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.ToTable("TAB_MODULO");

            builder.Property(t => t.CodModulo)
                .HasColumnName("SEQ_MODULO")
                .IsRequired();
                //.HasComment("Sequencial da tabela");

                builder.Property(t => t.NomModulo)
                    .HasColumnName("NOM_Modulo")
                    .HasMaxLength(100)
                    .IsRequired();
                //.HasComment("Descriçao do Modulo");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");//.HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");//.HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");//.HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");//.HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");//.HasComment("Indicador de registro ativo");
        }

        
    }
}
