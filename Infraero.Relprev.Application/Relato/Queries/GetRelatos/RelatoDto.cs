using System;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.Relato.Queries.GetRelatos
{
    public class RelatoDto : IMapFrom<Domain.Entities.Relato>
    {
        public int CodRelato { get; set; }
        public DateTime DatOcorrencia { get; set; }
        public string HorOcorrencia { get; set; }
        public string DscLocalOcorrenciaRelator { get; set; }
        public string DscEnvolvidosOcorrencia { get; set; }
        public string DscOcorrenciaRelator { get; set; }
        public string NomRelator { get; set; }
        public string EmailRelator { get; set; }
        public string NumTelefoneRelator { get; set; }
        public string NomEmpresaRelator { get; set; }
        //public virtual ICollection<RelatoArquivoDto> Arquivos { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Relato, RelatoDto>();
        }

    }
}
