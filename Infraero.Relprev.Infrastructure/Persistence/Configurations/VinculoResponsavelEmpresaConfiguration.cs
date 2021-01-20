using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    class VinculoResponsavelEmpresaConfiguration : IEntityTypeConfiguration<VinculoResponsavelEmpresa>
    {
        public void Configure(EntityTypeBuilder<VinculoResponsavelEmpresa> builder)
        {
            builder.ToTable("CAD_VINCULO_RESPONSAVEL_EMPRESA");

            builder.Property(t => t.CodVinculoResponsavelEmpresa)
                .HasColumnName("SEQ_VINCULO_RESPONSAVEL_EMPRESA")
                .IsRequired().HasComment("Sequencial da tabela");

            builder.Property(t => t.CodUnidadeInfraestrutura)
                .IsRequired()
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA").HasComment("Sequencial da tabela unidade de infraestrutura");

            builder.Property(t => t.CodEmpresa)
                .IsRequired()
                .HasColumnName("COD_EMPRESA").HasComment("Sequencial da tabela empresa");

            builder.Property(t => t.CodResponsavelTecnico)
                .HasColumnName("COD_RESPONSAVEL_TECNICO").HasComment("Sequencial da tabela responsavel tecnico");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO").HasMaxLength(256).HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO").HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO").HasMaxLength(256).HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO").HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO").HasComment("Indicador de registro ativo");
        }
    }
}