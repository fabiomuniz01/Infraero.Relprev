using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;

namespace Infraero.Relprev.Application.Empresa.Queries.GetEmpresas
{
    public class EmpresaDto : IMapFrom<Domain.Entities.Empresa>
    {
        public int CodEmpresa { get; set; }
        public string NomRazaoSocial { get; set; }
        public string NumCnpj { get; set; }
        public string NumTelefone { get; set; }
        public string NomUnidadeInfraestrutura { get; set; }
        public string CpfCriadoPor { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Empresa, EmpresaDto>();
        }
    }
}
