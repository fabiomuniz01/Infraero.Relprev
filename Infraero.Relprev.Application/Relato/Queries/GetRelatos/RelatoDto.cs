using System;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string DscMotivoRelator { get; set; }
        [ForeignKey("CodRelato")]
        public virtual List<RelatoArquivoDto> ListArquivo { get; set; }
        [ForeignKey("CodUnidadeInfraestrutura")]
        public UnidadeInfraEstruturaDto UnidadeInfraestrutura { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }
        public int CodLocal { get; set; }
        public int CodSubLocal { get; set; }
        public int CodAssunto { get; set; }
        public int CodSubAssunto { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Relato, RelatoDto>();
        }


    }
}
