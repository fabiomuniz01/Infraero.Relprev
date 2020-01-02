using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class ResponsavelTecnicoModel
    {
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }

    }
}
