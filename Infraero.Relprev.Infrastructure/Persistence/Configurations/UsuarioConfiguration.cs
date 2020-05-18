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
                .HasColumnName("SEQ_USUARIO").IsRequired();

            builder.Property(t => t.CodUsuarioLogin)
                .HasColumnName("COD_USUARIO_LOGIN");

            builder.Property(t => t.NomUsuario)
                .HasColumnName("NOM_USUARIO")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(t => t.NumCpf)
                .HasColumnName("NUM_CPF")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(t => t.NumTelefone)
                .HasColumnName("NUM_TELEFONE")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(t => t.Email)
                .HasColumnName("DSC_EMAIL")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.NomPerfil)
                .HasColumnName("NOM_PERFIL")
                .HasMaxLength(150);

            builder.Property(t => t.CodUnidadeInfraestrutura)
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA");

            builder.Property(t => t.CodPerfil)
                .HasColumnName("COD_PERFIL")
                .HasMaxLength(250);

            builder.Property(t => t.CodEmpresa)
                .HasColumnName("COD_EMPRESA");


            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");
        }
    }
}
