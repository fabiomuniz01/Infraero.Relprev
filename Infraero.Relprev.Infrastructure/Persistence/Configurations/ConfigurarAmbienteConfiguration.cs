using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class ConfigurarAmbienteConfiguration : IEntityTypeConfiguration<ConfigurarAmbiente>
    {
        public void Configure(EntityTypeBuilder<ConfigurarAmbiente> builder)
        {
            builder.ToTable("CAD_CONFIG_AMBIENTE");

            builder.Property(t => t.CodConfigurarAmbiente)
                .HasColumnName("SEQ_CONFIG_AMBIENTE")
                .IsRequired().HasComment("Sequencial da tabela");

            builder.Property(t => t.ParecerTecnico)
                .HasColumnName("QTD_PARECER_TECNICO")
                .IsRequired().HasComment("Tempo que o técnico deve ter para responder um parecer técnico");

            builder.Property(t => t.DevolvidoParaComplemento)
                .HasColumnName("QTD_DEVOLVIDO_PARA_COMPLEMENTO")
                .IsRequired().HasComment("Tempo de resposta do parecer técnico quando o mesmo é rejeitado e devolvido para complemento");

            builder.Property(t => t.TempoNotificacaoParaResponder)
                .HasColumnName("QTD_TEMPO_NOTIFICACAO_PARA_RESPONDER")
                .IsRequired().HasComment("Tempo em que dever ser notificado por e-mail as Respostas dos Pareceres Técnicos");

            builder.Property(t => t.TextoMotivoCancelamento)
                .HasColumnName("TXT_MOTIVO_CANCELAMENTO")
                .HasMaxLength(1000)
                .IsRequired().HasComment("Texto descritivo a ser inserido no e-mail de notificação em caso de cancelamento do relato");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasMaxLength(256).HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasMaxLength(256).HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }
    }
}
