using System;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.Application.ConfigurarAmbiente.Queries.GetConfigurarAmbientes;
using Infraero.Relprev.Application.HistoricoRelato.Queries.GetHistoricoRelatos;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;

namespace Infraero.Relprev.Application.Relato.Queries.GetRelatos
{
    public class RelatoDto : IMapFrom<Domain.Entities.Relato>
    {
        public int CodRelato { get; set; }
        public string NumRelato { get; set; }
        public DateTime DatOcorrencia { get; set; }
        public string HorOcorrencia { get; set; }
        public string DscLocalOcorrenciaRelator { get; set; }
        public string DscEnvolvidosOcorrencia { get; set; }
        public string DscOcorrenciaRelator { get; set; }
        public string NomRelator { get; set; }
        public string EmailRelator { get; set; }
        public string NumTelefoneRelator { get; set; }
        public string NomEmpresaRelator { get; set; }
        public int FlgStatusRelato { get; set; }
        public string StatusRelato { get; set; }
        public string DscMotivoCancelamento { get; set; }
        [ForeignKey("CodRelato")]
        public List<RelatoArquivoDto> ListArquivo { get; set; }
        [ForeignKey("CodRelato")]
        public HistoricoRelatoDto HistoricoRelato { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        [ForeignKey("CodUnidadeInfraestrutura")]
        public UnidadeInfraEstruturaDto UnidadeInfraestrutura { get; set; }
        public int CodLocal { get; set; }
        [ForeignKey("CodLocal")]
        public LocalDto Local { get; set; }
        public int CodSubLocal { get; set; }
        [ForeignKey("CodSubLocal")]
        public SubLocalDto SubLocal { get; set; }
        public int CodAssunto { get; set; }
        [ForeignKey("CodAssunto")]
        public AssuntoDto Assunto { get; set; }
        public int CodSubAssunto { get; set; }
        [ForeignKey("CodSubAssunto")]
        public SubAssuntoDto SubAssunto { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Relato, RelatoDto>();
        }


    }
}
