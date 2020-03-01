using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;

namespace Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals
{
    public class SubLocalDto : IMapFrom<Domain.Entities.SubLocal>
    {

        public int CodSubLocal { get; set; }
        public string DscSubLocal { get; set; }
        public int CodLocal { get; set; }

        public LocalDto Local { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public UnidadeInfraEstruturaDto UnidadeInfraestrutura { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.SubLocal, SubLocalDto>();
        }
    }
}
