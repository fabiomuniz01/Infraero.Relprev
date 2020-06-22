using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    public class ResponsavelTecnicoConfiguration : IEntityTypeConfiguration<ResponsavelTecnico>
    {
        public void Configure(EntityTypeBuilder<ResponsavelTecnico> builder)
        {
            builder.ToTable("CAD_RESPONSAVEL_TECNICO");

            builder.Property(t => t.CodResponsavelTecnico)
                .HasColumnName("SEQ_RESPONSAVEL_TECNICO")
                .IsRequired();//.HasComment("Sequencial da tabela");

            builder.Property(t => t.NomResponsavelTecnico)
                .HasColumnName("NOM_RESPONSAVEL_TECNICO")
                .HasMaxLength(50)
                .IsRequired();//.HasComment("Nome do Responsável Técnico  ");

            builder.Property(t => t.NumCpf)
                .HasColumnName("NUM_CPF")
                .HasMaxLength(14)
                .IsRequired();//.HasComment("Número do CPF do Responsável Técnico ");

            builder.Property(t => t.NumTelefone)
                .HasColumnName("NUM_TELEFONE")
                .HasMaxLength(14)
                .IsRequired();//.HasComment("Número do telefone");

            builder.Property(t => t.NumDocumento)
                .HasColumnName("NUM_DOCUMENTO")
                .HasMaxLength(15);//.HasComment("Número do documento de correspondência");

            builder.Property(t => t.EndEmail)
                .HasColumnName("END_RESPONSAVEL_TECNICO")
                .HasMaxLength(50);//.HasComment("Endereço eletrônico do Responsável Técnico ");

            builder.Property(t => t.CodUnidadeInfraestrutura)
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA")
                .IsRequired();//.HasComment("Codigo sequencia da unidade de infraestrutura");

            builder.Property(t => t.CodEmpresa)
                .HasColumnName("COD_EMPRESA")
                .IsRequired();//.HasComment("Codigo sequencial da empresa");

            builder.Property(t => t.FlagGestorSgso)
                .HasColumnName("FLG_GESTOR_SGSO");//.HasComment("Flag gestor sgso site");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");//.HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");//.HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");//.HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");//.HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");//.HasComment("Indicador de registro ativo");
        }
    }
}
