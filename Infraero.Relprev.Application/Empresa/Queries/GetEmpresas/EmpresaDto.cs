using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa;

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
        public int CodVinculoUnidadeEmpresa { get; set; }

        [ForeignKey("CodEmpresa")]
        public ICollection<VinculoUnidadeEmpresaDto> VinculoUnidadeEmpresaList { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Empresa, EmpresaDto>();
        }
    }
}
