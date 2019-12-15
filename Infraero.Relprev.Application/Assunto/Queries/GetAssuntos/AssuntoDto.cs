using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos
{
    public class UnidadeInfraEstruturaDto : IMapFrom<Assunto>
    {
        public int CodAssunto { get; set; }
        public string DscAssunto { get; set; }

        public virtual ICollection<Relato> Relato { get; set; }
        public virtual ICollection<SubAssunto> SubAssunto { get; set; }

        //public Assunto Assunto { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Assunto, UnidadeInfraEstruturaDto>();
        }
    }
}
