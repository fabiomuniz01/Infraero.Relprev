using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class ResponsavelTecnicoModel
    {
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public SelectList ListEmpresa { get; set; }
        public ResponsavelTecnicoDto ResponsavelTecnico { get; set; }
    }
}
