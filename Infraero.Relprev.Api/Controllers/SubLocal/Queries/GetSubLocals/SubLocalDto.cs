using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;

namespace Infraero.Relprev.Api.Controllers.SubLocal.Queries.GetSubLocals
{
    public class SubLocalDto : IMapFrom<Domain.Entities.SubLocal>
    {
        public int CodSubLocal { get; set; }
        public string DscSubLocal { get; set; }
        public int CodLocal { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.SubLocal, SubLocalDto>();
        }
    }
}
