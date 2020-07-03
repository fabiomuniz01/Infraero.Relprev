using System;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.Application.ConfigurarAmbiente.Queries.GetConfigurarAmbientes;

using Infraero.Relprev.Application.HistoricoParecer.Queries.GetHistoricoParecer;

namespace Infraero.Relprev.Application.Relato.Queries.GetRelatos
{
    public class ParecerDto : IMapFrom<Domain.Entities.Parecer>
    {
        public int CodParecer { get; set; }
        public string DscPasrecer { get; set; }
        public string DscComplementoParecer { get; set; }
        public int FlgStatusParecer { get; set; }
        public string StatusParecer { get; set; }

        [ForeignKey("CodParecer")]
        public List<ParecerArquivoDto> ListArquivo { get; set; }
        [ForeignKey("CodParecer")]
        public HistoricoParecerDto HistoricoParecer { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Parecer, ParecerDto>();
        }


    }
}
