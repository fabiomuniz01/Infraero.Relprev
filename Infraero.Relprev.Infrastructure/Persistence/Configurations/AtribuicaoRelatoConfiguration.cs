using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class AtribuicaoRelatoConfiguration : IEntityTypeConfiguration<AtribuicaoRelato>
    {
        public void Configure(EntityTypeBuilder<AtribuicaoRelato> builder)
        {
            builder.ToTable("CAD_ATRIBUICAO_RELATO");

            builder.Property(t => t.CodAtribuicaoRelato)
                .HasColumnName("SEQ_ATRIBUICAO_RELATO")
                .IsRequired().HasComment("Sequencial da tabela");

            builder.Property(t => t.CodResponsavelTecnico)
                 .HasColumnName("COD_RESPONSAVEL_TECNICO").HasComment("Código do responsavel SGSO da atribuicao do relato");

            builder.Property(t => t.CodRelato)
                .HasColumnName("COD_RELATO")
                .IsRequired().HasComment("Código sequencial do relato");

            builder.Property(t => t.CodSituacaoAtribuicao)
                .HasColumnName("COD_SITUACAO_ATRIBUICAO").HasComment("Código de situação da atribuição");

            builder.Property(t => t.DscParecerTecnico)
                .HasColumnName("DSC_PARECER_TECNICO")
                .HasMaxLength(455).HasComment("Descrição do parecer técnico");

            builder.Property(t => t.CodUsuarioAtribuidor)
                .HasColumnName("COD_USUARIO_ATRIBUIDOR")
                .HasMaxLength(455).HasComment("Código sequencial do usuário atribuidor. OBS: caso valor nulo, usuario atribuidor igual a SistemaRelprev");

            builder.Property(t => t.DthAtribuicao)
                .HasColumnName("DTH_ATRIBUICAO").HasComment("Data Hora da atribuição");

            builder.Property(t => t.DthFimAtendimento)
                .HasColumnName("DTH_FIM_ATENDIMENTO").HasComment("Data Hora fim do atendimento");

            builder.Property(t => t.ObsAtribuicao)
                .HasColumnName("DSC_OBS_ATRIBUICAO")
                .HasMaxLength(455).HasComment("Descrição da observação da atribuição");




            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasMaxLength(256).HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasMaxLength(256).HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }
    }
}
