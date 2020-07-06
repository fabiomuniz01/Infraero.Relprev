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
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA")
                .IsRequired();//.HasComment("Código da unidade");

            builder.Property(t => t.Descricao)
                .HasColumnName("DSC_UNIDADE_INFRAESTRUTURA")
                .IsRequired();//.HasComment("Detalhamento da Unidade de Infraestrutura");

            builder.Property(t => t.DtIniVigencia)
                .HasColumnName("DTH_INI_VIGENCIA")
                .IsRequired();//.HasComment("Data de Início do período de vigência da Unidade cadastrada");

            builder.Property(t => t.DtFimVigencia)
                .HasColumnName("DTH_FIM_VIGENCIA")
                .IsRequired();//.HasComment("Data de Fim do período de vigência da Unidade cadastrada");

            builder.Property(t => t.Endereco)
                .HasColumnName("END_UNIDADE_INFRAESTRUTURA")
                .IsRequired();//.HasComment("Localização da Unidade de Infraestrutura");

            builder.Property(t => t.NomUnidadeÌnfraestrutura)
                .HasColumnName("NOM_UNIDADE_INFRAESTRUTURA")
                .IsRequired();//.HasComment("Localização da Unidade de Infraestrutura");

            builder.Property(t => t.Sigla)
                .HasColumnName("SIG_UNIDADE_INFRAESTRUTURA")
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
