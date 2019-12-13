using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.Empresas.Queries.GetEmpresas
{
    public class EmpresaDto : IMapFrom<Empresa>
    {
        public int CodEmpresa { get; set; }

        public string NomRazaoSocial { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Empresa, EmpresaDto>();
        }
    }
}
