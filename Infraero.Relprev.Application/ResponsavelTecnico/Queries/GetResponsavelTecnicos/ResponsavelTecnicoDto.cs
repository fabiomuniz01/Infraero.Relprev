using System.Collections.Generic;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos
{
    public class ResponsavelTecnicoDto : IMapFrom<Domain.Entities.ResponsavelTecnico>
    {
        public int CodResponsavelTecnico { get; set; }
        public string NomResponsavelTecnico { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string NumDocumento { get; set; }
        public string EndEmail { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public EmpresaDto Empresa { get; set; }
        public string DscEmpresa { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.ResponsavelTecnico, ResponsavelTecnicoDto>();

        }
    }
}
