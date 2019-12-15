using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.SubAssuntos.Queries.GetSubAssuntos
{
    public class SubAssuntoDto : IMapFrom<SubAssunto>
    {
        public int CodSubAssunto { get; set; }
        public string DscSubAssunto { get; set; }
        public int CodAssunto { get; set; }

        public virtual Assunto CodAssuntoNavigation { get; set; }
        public virtual ICollection<Relato> Relato { get; set; }

        //public UnidadeInfraestrutura UnidadeInfraestrutura { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SubAssunto, SubAssuntoDto>();
        }
    }
}
