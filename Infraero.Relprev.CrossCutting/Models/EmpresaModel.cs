using Microsoft.AspNetCore.Mvc.Rendering;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class EmpresaModel
    {
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public EmpresaDto Empresa { get; set; }
        public GridVinculoUnidadeEmpresa GridVinculoUnidadeEmpresa { get; set; }
    }
}
