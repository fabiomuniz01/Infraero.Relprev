using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;

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

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.ResponsavelTecnico, ResponsavelTecnicoDto>();
        }
    }
}
