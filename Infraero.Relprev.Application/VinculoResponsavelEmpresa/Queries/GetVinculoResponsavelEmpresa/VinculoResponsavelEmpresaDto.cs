using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;

namespace Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresa
{
    public class VinculoResponsavelEmpresaDto : IMapFrom<Domain.Entities.VinculoResponsavelEmpresa>
    {
        public int CodVinculoResponsavelEmpresa { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public int CodResponsavelTecnico { get; set; }

        [ForeignKey("CodEmpresa")]
        public EmpresaDto Empresa { get; set; }

        [ForeignKey("CodResponsavelTecnico")]
        public ResponsavelTecnicoDto Responsavel { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.VinculoResponsavelEmpresa, VinculoResponsavelEmpresaDto>();
        }
    }
}
