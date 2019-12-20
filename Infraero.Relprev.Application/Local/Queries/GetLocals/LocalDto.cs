using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;

namespace Infraero.Relprev.Application.Local.Queries.GetLocals
{
    public class LocalDto : IMapFrom<Domain.Entities.Local>
    {
        public int CodLocal { get; set; }
        public string DscUnidade { get; set; }
        public string DscLocal { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Local, LocalDto>()
                .ForMember(d => d.DscUnidade, opt => opt.MapFrom(s => (int)s.CodUnidadeInfraestrutura));
        }
    }
}
