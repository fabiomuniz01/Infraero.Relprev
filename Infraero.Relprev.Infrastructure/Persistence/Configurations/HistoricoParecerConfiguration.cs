using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class HistoricoParecerConfiguration : IEntityTypeConfiguration<HistoricoParecer>
    {
        public void Configure(EntityTypeBuilder<HistoricoParecer> builder)
        {
            builder.ToTable("HST_CAD_PARECER");

            builder.Property(t => t.CodHistoricoParecer)
                .HasColumnName("SEQ_HISTORICO_PARECER")
                .IsRequired();//.HasComment("Sequencial da tabela");

            builder.Property(t => t.CodParecer)
                .HasColumnName("COD_PARECER")
                .IsRequired();//.HasComment("Codigo sequencial do Parecer");

            builder.Property(t => t.DscUltimaOcorrencia)
                .HasColumnName("DSC_ULTIMA_OCORRENCIA")
                .HasMaxLength(255);//.HasComment("Descriçao da última Ocorrência");

            builder.Property(t => t.DscParecer)
                .HasColumnName("DSC_PARECER")
                .HasMaxLength(255);//.HasComment("Descriçao do parecer");

            builder.Property(t => t.DscComplementoParecer)
                .HasColumnName("DSC_COMPLEMENTO_PARECER")
                .HasMaxLength(255);//.HasComment("Descriçao do complemento do parecer");

            builder.Property(t => t.DscMotivoDevolucao)
                .HasColumnName("DSC_MOTIVO_DEVOLUCAO")
                .HasMaxLength(255);//.HasComment("Descriçao do motivo da devolução");

            builder.Property(t => t.FlgStatusParecer)
             .HasColumnName("FLG_STATUS_RELATO")
             .IsRequired();//.HasComment("Status do parecer");     

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");//.HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");//.HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");//.HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");//.HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");//.HasComment("Indicador de registro ativo");
        }

        
    }
}
