using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class UsuarioModel
    {
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public int CodPerfil { get; set; }
        public SelectList ListEmpresa { get; set; }
        public SelectList ListPerfil { get; set; }
    }
}
