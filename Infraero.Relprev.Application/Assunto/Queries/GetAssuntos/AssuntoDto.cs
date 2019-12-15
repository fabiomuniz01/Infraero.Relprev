using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;

namespace Infraero.Relprev.Application.Assunto.Queries.GetAssuntos
{
    public class AssuntoDto : IMapFrom<Domain.Entities.Assunto>
    {
        public int CodAssunto { get; set; }
        public string DscAssunto { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Assunto, AssuntoDto>();
        }
    }
}
