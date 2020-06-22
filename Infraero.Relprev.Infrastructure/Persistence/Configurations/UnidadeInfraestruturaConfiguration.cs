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
                .IsRequired();//.HasComment("Sequencial da tabela");

            builder.Property(t => t.CodUnidade)
                .HasColumnName("COD_UNIDADE")
                .IsRequired();//.HasComment("Código da unidade");

            builder.Property(t => t.Sigla)
                .HasColumnName("SIG_UNIDADE")
                .HasMaxLength(8)
                .IsRequired();//.HasComment("Sigla da unidade");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");//.HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");//.HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");//.HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");//.HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");//.HasComment("Indicador de registro ativo");
        }

        
    }
}
