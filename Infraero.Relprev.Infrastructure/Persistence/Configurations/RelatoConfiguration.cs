﻿
using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraero.Relprev.Infrastructure.Persistence.Configurations
{


    public class RelatoConfiguration : IEntityTypeConfiguration<Relato>
    {
        public void Configure(EntityTypeBuilder<Relato> builder)
        {
            builder.ToTable("CAD_RELATO");

            builder.Property(t => t.CodRelato)
                .HasColumnName("SEQ_RELATO")
                .IsRequired();

            builder.Property(t => t.DatOcorrencia)
                .HasColumnName("DAT_OCORRENCIA")
                .IsRequired();

            builder.Property(t => t.HorOcorrencia)
                .HasColumnName("HOR_OCORRENCIA")
                .HasMaxLength(5)
                .IsRequired();

            builder.Property(t => t.DscLocalOcorrenciaRelator)
               .HasColumnName("DSC_LOCAL_OCORRENCIARELATOR")
               .HasMaxLength(200)
               .IsRequired();

            builder.Property(t => t.DscEnvolvidosOcorrencia)
               .HasColumnName("DSC_ENVOLVIDO_OCORRENCIA")
               .HasMaxLength(200)
               .IsRequired();

            builder.Property(t => t.DscEnvolvidosOcorrencia)
              .HasColumnName("DSC_ENVOLVIDO_OCORRENCIA")
              .HasMaxLength(500)
              .IsRequired();

            builder.Property(t => t.NomRelator)
              .HasMaxLength(100)
              .HasColumnName("NOM_RELATOR");

            builder.Property(t => t.EmailRelator)
              .HasMaxLength(100)
              .HasColumnName("EMAIL_RELATOR");

            builder.Property(t => t.NumTelefoneRelator)
                .HasMaxLength(11)
              .HasColumnName("NUM_TELEFONE_RELATOR");

            builder.Property(t => t.NomEmpresaRelator)
              .HasMaxLength(100)
              .HasColumnName("NOM_EMPRESA_RELATOR");

            builder.Property(t => t.DscRelato)
              .HasColumnName("DSC_RELATO")
              .HasMaxLength(1000)
              .IsRequired();

            builder.Property(t => t.CodUnidadeInfraestrutura)
              .HasColumnName("COD_UNIDADE_ESINFRAESTRUTURA")
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
