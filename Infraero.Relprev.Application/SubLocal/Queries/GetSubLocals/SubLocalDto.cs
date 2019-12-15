using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.SubLocals.Queries.GetSubLocals
{
    public class SubLocalDto : IMapFrom<SubLocal>
    {
        public int CodSubLocal { get; set; }
        public string DscSubLocal { get; set; }
        public int CodLocal { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SubLocal, SubLocalDto>();
        }
    }
}
