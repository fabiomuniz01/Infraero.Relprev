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
                .HasColumnName("SEQ_RESPONSAVEL_TECNICO").IsRequired();

            builder.Property(t => t.NomResponsavelTecnico)
                .HasColumnName("NOM_RESPONSAVEL_TECNICO")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(t => t.NumCpf)
                .HasColumnName("NUM_CPF")
                .HasMaxLength(14)
                .IsRequired();
            builder.Property(t => t.NumTelefone)
                .HasColumnName("NUM_TELEFONE")
                .HasMaxLength(14)
                .IsRequired();
            builder.Property(t => t.NumDocumento)
                .HasColumnName("NUM_DOCUMENTO")
                .HasMaxLength(15);
            builder.Property(t => t.EndEmail)
                .HasColumnName("END_RESPONSAVEL_TECNICO")
                .HasMaxLength(50);
            builder.Property(t => t.CodUnidadeInfraestrutura)
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA")
                .IsRequired();
            builder.Property(t => t.CodEmpresa)
                .HasColumnName("COD_EMPRESA")
                .IsRequired();

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");
        }
    }
}
