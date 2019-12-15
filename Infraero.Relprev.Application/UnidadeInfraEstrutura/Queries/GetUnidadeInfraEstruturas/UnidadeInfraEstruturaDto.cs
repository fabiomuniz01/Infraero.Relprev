using System;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas
{
    public class UnidadeInfraEstruturaDto : IMapFrom<UnidadeInfraestrutura>
    {
        public int CodUnidadeInfraestrutura { get; set; }
        public string CodUnidade { get; set; }
        public string Sigla { get; set; }

        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public DateTime DtIniVigencia { get; set; }
        public DateTime DtFimVigencia { get; set; }

        //public UnidadeInfraestrutura UnidadeInfraestrutura { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UnidadeInfraestrutura, UnidadeInfraEstruturaDto>();
        }
    }
}
