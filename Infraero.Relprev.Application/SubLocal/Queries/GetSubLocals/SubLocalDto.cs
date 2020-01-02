using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.Local.Queries.GetLocals;

namespace Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals
{
    public class SubLocalDto : IMapFrom<Domain.Entities.SubLocal>
    {
        public int CodSubLocal { get; set; }
        public string DscSubLocal { get; set; }
        public string DscLocal { get; set; }
        public int CodLocal { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public virtual LocalDto Local { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.SubLocal, SubLocalDto>();
        }
    }
}
