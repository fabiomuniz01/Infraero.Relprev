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
                .HasColumnName("SEQ_EMPRESA").IsRequired();
            
            builder.Property(t => t.NomRazaoSocial)
                .HasColumnName("NOM_RAZAO_SOCIAL")
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(t => t.NumCnpj)
                .HasColumnName("NUM_CNPJ")
                .HasMaxLength(18)
                .IsRequired();

            builder.Property(t => t.NumTelefone)
                .HasColumnName("NUM_TELEFONE")
                .HasMaxLength(14);

            builder.Property(t => t.CpfCriadoPor)
                .HasColumnName("NUM_CPF_CRIADO_POR")
                .HasMaxLength(18);

            builder.Property(t => t.DthRegistro)
                .HasColumnName("DTH_REGISTRO");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");


        }
    }
}
