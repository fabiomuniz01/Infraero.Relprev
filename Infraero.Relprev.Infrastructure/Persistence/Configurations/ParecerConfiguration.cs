using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class ParecerConfiguration : IEntityTypeConfiguration<Parecer>
    {
        public void Configure(EntityTypeBuilder<Parecer> builder)
        {
            builder.ToTable("CAD_PARECER");

            builder.Property(t => t.CodParecer)
                .HasColumnName("SEQ_PARECER")
                .IsRequired();//.HasComment("Sequencial da tabela");

            builder.Property(t => t.DscParecer)
                .HasColumnName("DSC_PARECER")
                .HasMaxLength(500)
                .IsRequired();//.HasComment("Descrição do parecer");

            builder.Property(t => t.DscMotivoDevolucao)
               .HasColumnName("DSC_MOTIVO_DEVOLUCAO")
               .HasMaxLength(500)
               .IsRequired();//.HasComment("Descrição do motivo da devolucao");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");//.HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");//.HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");//.HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");//.HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");//.HasComment("Indicador de registro ativo");
        }
    }
}
