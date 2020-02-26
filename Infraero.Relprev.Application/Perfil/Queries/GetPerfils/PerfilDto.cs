using System;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Claims;

namespace Infraero.Relprev.Application.Perfil.Queries.GetPerfils
{
    public class PerfilDto : IMapFrom<Domain.Entities.Perfil>
    {
        public string CodPerfil { get; set; }
        public string NomPerfil { get; set; }
        public ListDictionary ListClaims { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Perfil, PerfilDto>();
        }
    }

    

}
