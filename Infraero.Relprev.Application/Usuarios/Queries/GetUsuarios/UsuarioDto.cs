﻿using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios
{
    public class UsuarioDto : IMapFrom<Usuario>
    {
        public int CodUsuario { get; set; }

        public string NomRazaoSocial { get; set; }
        public string NumCnpj { get; set; }
        public string NumTelefone { get; set; }

        public string NomUnidadeInfraestrutura { get; set; }

        //public UnidadeInfraestrutura UnidadeInfraestrutura { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Usuario, UsuarioDto>();
        }
    }
}
