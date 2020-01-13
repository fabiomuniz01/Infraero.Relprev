using System.Collections.Generic;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class PerfilModel
    {
        public PerfilModel(PerfilDto perfil)
        {
            Perfil = perfil;
        }

        public PerfilDto Perfil { get; set; }
        public string CodPerfil { get; set; }
        public SelectList ListPerfil { get; set; }
    }
}
