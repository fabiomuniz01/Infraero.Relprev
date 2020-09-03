using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("CAD_USUARIO");

            builder.Property(t => t.CodUsuario)
                .HasColumnName("SEQ_USUARIO")
                .IsRequired().HasComment("Sequencial da tabela");

            builder.Property(t => t.CodUsuarioLogin)
                .HasColumnName("COD_USUARIO_LOGIN").HasComment("Código do login do usuário");

            builder.Property(t => t.NomUsuario)
                .HasColumnName("NOM_USUARIO")
                .HasMaxLength(60)
                .IsRequired().HasComment("Descrição completa do nome do usuário");

            builder.Property(t => t.NumCpf)
                .HasColumnName("NUM_CPF")
                .HasMaxLength(14)
                .IsRequired().HasComment("Número do CPF do usuário");

            builder.Property(t => t.NumTelefone)
                .HasColumnName("NUM_TELEFONE")
                .HasMaxLength(14)
                .IsRequired().HasComment("Telefone de contato do usuário");

            builder.Property(t => t.Email)
                .HasColumnName("END_ENDERECO_ELETRONICO")
                .HasMaxLength(150)
                .IsRequired().HasComment("Endereço eletrônico válido do usuário");

            builder.Property(t => t.NomPerfil)
                .HasColumnName("NOM_PERFIL")
                .HasMaxLength(150).HasComment("Nome d perfil do usuário");

            builder.Property(t => t.CodUnidadeInfraestrutura)
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA").HasComment("Código sequencial do unidade de infraestrutura");

            builder.Property(t => t.CodPerfil)
                .HasColumnName("COD_PERFIL")
                .HasMaxLength(250).HasComment("Código do perfil do usuário");

            builder.Property(t => t.CodEmpresa)
                .HasColumnName("COD_EMPRESA").HasComment("Código sequencial da empresa");


            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasMaxLength(256).HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasMaxLength(256).HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }
    }
}
