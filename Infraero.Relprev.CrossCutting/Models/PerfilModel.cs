using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using Infraero.Relprev.Application.Modulo.Queries.GetModulos;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class PerfilModel
    {
        public PerfilDto Perfil { get; set; }
        public string CodPerfil { get; set; }
        public SelectList ListPerfil { get; set; }
        public List<ModuloDto> ListModulo { get; set; }
        public List<Claim> ListClaim { get; set; }
    }
}
