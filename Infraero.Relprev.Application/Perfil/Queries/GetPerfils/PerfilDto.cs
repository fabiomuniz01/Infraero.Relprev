using System;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.Perfil.Queries.GetPerfils
{
    public class PerfilDto : IMapFrom<Domain.Entities.Perfil>
    {
        public int CodPerfil { get; set; }
        public string NomPerfil { get; set; }
        public string DscPerfil { get; set; }
        public string FlgAtivo { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Perfil, PerfilDto>();
        }
    }

    

}
