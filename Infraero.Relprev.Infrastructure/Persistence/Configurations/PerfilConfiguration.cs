using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    

    public class PerfilConfiguration : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("CAD_PERFIL");

            builder.Property(t => t.CodPerfil)
                .HasColumnName("SEQ_PERFIL")
                .IsRequired();
                //.HasComment("Sequencial da tabela");

                builder.Property(t => t.NomPerfil)
                    .HasColumnName("NOM_PERFIL")
                    .HasMaxLength(100)
                    .IsRequired();
                //.HasComment("Nome do Perfil");

                builder.Property(t => t.DscPerfil)
                    .HasColumnName("DSC_PERFIL")
                    .HasMaxLength(255)
                    .IsRequired();
                //.HasComment("Descriçao do Perfil");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");//.HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");//.HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");//.HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");//.HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");//.HasComment("Indicador de registro ativo");
        }

        
    }
}
