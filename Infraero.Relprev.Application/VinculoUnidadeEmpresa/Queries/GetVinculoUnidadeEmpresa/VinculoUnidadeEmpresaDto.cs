using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;

namespace Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa
{
    public class VinculoUnidadeEmpresaDto : IMapFrom<Domain.Entities.VinculoUnidadeEmpresa>
    {
        public int CodVinculoUnidadeEmpresa { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public string NomUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public string NomEmpresa { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.VinculoUnidadeEmpresa, VinculoUnidadeEmpresaDto>();
        }
    }
}
