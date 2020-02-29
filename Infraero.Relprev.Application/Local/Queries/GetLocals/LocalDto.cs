using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.Local.Queries.GetLocals
{
    public class LocalDto : IMapFrom<Domain.Entities.Local>
    {
        public int CodLocal { get; set; }
        public string DscUnidade { get; set; }
        public string DscLocal { get; set; }
        public UnidadeInfraEstruturaDto UnidadeInfraestrutura { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Local, LocalDto>().ForMember(
                d => d.CodLocalStr, opt => opt.MapFrom(s => s.CodLocal.ToString()));
        }

        public string CodLocalStr { get; set; }
    }
}
