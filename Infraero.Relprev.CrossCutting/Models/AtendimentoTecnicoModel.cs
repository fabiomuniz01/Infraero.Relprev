using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class AtendimentoTecnicoModel
    {
        public int CodUnidadeInfraestrutura { get; set; }
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public int CodResponsavel { get; set; }
        public SelectList ListResponsavel { get; set; }
        public GridRelato ListRelato { get; set; }
    }
}
