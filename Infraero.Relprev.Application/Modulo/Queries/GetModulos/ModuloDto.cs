using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.Modulo.Queries.GetModulos
{
    public class ModuloDto : IMapFrom<Domain.Entities.Modulo>
    {
       
        public int CodModulo { get; set; }
        public string NomModulo { get; set; }
        public List<Funcionalidade> ListFuncionalidades { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Modulo, ModuloDto>();
        }
    }
}
