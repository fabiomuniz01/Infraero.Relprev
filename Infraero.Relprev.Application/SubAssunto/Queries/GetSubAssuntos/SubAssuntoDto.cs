using System.Collections.Generic;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos
{
    public class SubAssuntoDto : IMapFrom<Domain.Entities.SubAssunto>
    {
        public int CodSubAssunto { get; set; }
        public string DscSubAssunto { get; set; }
        public int CodAssunto { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.SubAssunto, SubAssuntoDto>();
        }
    }
}
