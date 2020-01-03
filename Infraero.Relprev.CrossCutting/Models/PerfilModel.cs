using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class PerfilModel
    {
        public string CodPerfil { get; set; }
        public SelectList ListPerfil { get; set; }
    }
}
