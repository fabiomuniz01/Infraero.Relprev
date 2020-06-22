using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{
    public class VinculoUnidadeEmpresaConfiguration : IEntityTypeConfiguration<VinculoUnidadeEmpresa>
    {
        public void Configure(EntityTypeBuilder<VinculoUnidadeEmpresa> builder)
        {
            builder.ToTable("CAD_VINCULO_UNIDADE_EMPRESA");

            builder.Property(t => t.CodVinculoUnidadeEmpresa)
                .HasColumnName("SEQ_VINCULO_UNIDADE_EMPRESA")
                .IsRequired();//.HasComment("Sequencial da tabela");

            builder.Property(t => t.CodEmpresa)
                .HasColumnName("COD_EMPRESA");//.HasComment("Sequencial da tabela empresa");

            builder.Property(t => t.CodUnidadeInfraestrutura)
                .HasColumnName("COD_UNIDADE_INFRAESTRUTURA");//.HasComment("Sequencial da tabela unidade de infraestrutura");

            builder.Property(t => t.NomEmpresa)
                .HasColumnName("NOM_EMPRESA")
                .HasMaxLength(255);//.HasComment("Nome da empresa");

            builder.Property(t => t.NomUnidadeInfraestrutura)
                .HasColumnName("NOM_UNIDADE_INFRAESTRUTURA")
                .HasMaxLength(255);//.HasComment("Nome da unidade de infraestrutura");

            //BaseEntity
            builder.Property(p => p.CriadoPor).HasColumnName("NOM_USU_INCLUSAO");//.HasComment("Usuário que realizou a inclusão");
            builder.Property(p => p.DataCriacao).HasColumnName("DTH_INCLUSAO");//.HasComment("Data da inclusão");
            builder.Property(p => p.AlteradoPor).HasColumnName("NOM_USU_ALTERACAO");//.HasComment("Usuário de realizou a alteração");
            builder.Property(p => p.DataAlteracao).HasColumnName("DTH_ALTERACAO");//.HasComment("Data de alteração");
            builder.Property(p => p.FlagAtivo).HasColumnName("FLG_ATIVO");//.HasComment("Indicador de registro ativo");
        }
    }
}