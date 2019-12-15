using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos
{
    public class AssuntoDto : IMapFrom<Assunto>
    {
        public int CodAssunto { get; set; }
        public string DscAssunto { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Assunto, AssuntoDto>();
        }
    }
}
