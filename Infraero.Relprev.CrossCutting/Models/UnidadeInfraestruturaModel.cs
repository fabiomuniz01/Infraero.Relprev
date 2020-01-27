using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class UnidadeInfraestruturaModel
    {
        public string dep_codigo;
        public UnidadeInfraEstruturaDto UnidadeInfraestrutura { get; set; }
        public SelectList ListDependencia { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodDependencia { get; set; }
    }
}
