using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresa;

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
        public bool FlagGestorSgso { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }

        [ForeignKey("CodResponsavelTecnico")]
        public List<VinculoResponsavelEmpresaDto> ListVinculoResponsavelEmpresa { get; set; }
        public string DscEmpresa { get; internal set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.ResponsavelTecnico, ResponsavelTecnicoDto>();

        }
    }
}
