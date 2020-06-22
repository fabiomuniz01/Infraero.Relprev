using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("CAD_EMPRESA");

            builder.Property(t => t.CodEmpresa)
                .HasColumnName("SEQ_EMPRESA")
                .IsRequired();//.HasComment("Sequencial da tabela");
            
            builder.Property(t => t.NomRazaoSocial)
                .HasColumnName("NOM_RAZAO_SOCIAL")
                .HasMaxLength(250)
                .IsRequired();//.HasComment("Empresa órgão público");

            builder.Property(t => t.NumCnpj)
                .HasColumnName("NUM_CNPJ")
                .HasMaxLength(18)
                .IsRequired();//.HasComment("CNPJ da empresa / órgão público");

            builder.Property(t => t.NumTelefone)
                .HasColumnName("NUM_TELEFONE")
                .HasMaxLength(14);//.HasComment("Telefone da empresa");

            builder.Property(t => t.CpfCriadoPor)
                .HasColumnName("NUM_CPF_CRIADO_POR")
                .HasMaxLength(18);//.HasComment("Numero cpf criado por");

            builder.Property(t => t.DthRegistro)
                .HasColumnName("DTH_REGISTRO");//.HasComment("Data Hora de registro");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");//.HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");//.HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");//.HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");//.HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");//.HasComment("Indicador de registro ativo");


        }
    }
}
