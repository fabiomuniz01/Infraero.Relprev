using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class HistoricoRelatoConfiguration : IEntityTypeConfiguration<HistoricoRelato>
    {
        public void Configure(EntityTypeBuilder<HistoricoRelato> builder)
        {
            builder.ToTable("HST_CAD_RELATO");

            builder.Property(t => t.CodHistoricoRelato)
                .HasColumnName("SEQ_HISTORICO_RELATO")
                .IsRequired()
                .HasComment("Sequencial da tabela");

            builder.Property(t => t.CodRelato)
                .HasColumnName("COD_RELATO")
                .IsRequired()
                .HasComment("Codigo sequencial do relato");

            builder.Property(t => t.DscUltimaOcorrencia)
                .HasColumnName("DSC_ULTIMA_OCORRENCIA")
                .HasMaxLength(255)
                .HasComment("Descriçao do assunto");

            builder.Property(t => t.DscNaoIniciado)
                .HasColumnName("DSC_NAO_INICIADO")
                .HasMaxLength(255)
                .HasComment("Descriçao do status nao iniciado");

            builder.Property(t => t.DscAtribuicao)
                .HasColumnName("DSC_ATRIBUICAO")
                .HasMaxLength(255)
                .HasComment("Descriçao do status de atribuição");

            builder.Property(t => t.DscCancelamento)
                .HasColumnName("DSC_CANCELAMENTO")
                .HasMaxLength(255)
                .HasComment("Descriçao do status de cancelamento");

            builder.Property(t => t.DscClassificacao)
                .HasColumnName("DSC_CLASSIFICACAO")
                .HasMaxLength(255)
                .HasComment("Descriçao do status de classificação");

            builder.Property(t => t.DscFinalizacao)
                .HasColumnName("DSC_FINALIZACAO")
                .HasMaxLength(255)
                .HasComment("Descriçao do status de finalização");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }

        
    }
}
